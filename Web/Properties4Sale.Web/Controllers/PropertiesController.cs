namespace Properties4Sale.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Data;
    using Properties4Sale.Services.Messaging;
    using Properties4Sale.Web.ViewModels.Property;
    using SendGrid;
    using SendGrid.Helpers.Mail;

    public class PropertiesController : Controller
    {
        private readonly ITypeOfPropertiesService typeOfPropertiesService;
        private readonly IPropertiesService propertiesService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment environment;
        private readonly Services.Messaging.IEmailSender emailSender;

        public PropertiesController(
            ITypeOfPropertiesService typeOfPropertiesService,
            IPropertiesService propertiesService,
            UserManager<ApplicationUser> userManager,
            IWebHostEnvironment environment,
            Services.Messaging.IEmailSender emailSender)
        {
            this.typeOfPropertiesService = typeOfPropertiesService;
            this.propertiesService = propertiesService;
            this.userManager = userManager;
            this.environment = environment;
            this.emailSender = emailSender;
        }

        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreatePropertyInputModel
            {
                TypeOfPropertiesItems = this.typeOfPropertiesService.GetAllKeyValuePairs(),
            };
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreatePropertyInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.TypeOfPropertiesItems = this.typeOfPropertiesService.GetAllKeyValuePairs();
                return this.View(input);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            try
            {
                await this.propertiesService.CreateAsync(input, user.Id, $"{this.environment.WebRootPath}/images");
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                input.TypeOfPropertiesItems = this.typeOfPropertiesService.GetAllKeyValuePairs();
                return this.View(input);
            }

            return this.Redirect("/");
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var inputModel = this.propertiesService.GetById<EditPropertyInputModel>(id);
            inputModel.TypeOfPropertiesItems = this.typeOfPropertiesService.GetAllKeyValuePairs();

            return this.View(inputModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditPropertyInputModel property)
        {
            if (!this.ModelState.IsValid)
            {
                property.TypeOfPropertiesItems = this.typeOfPropertiesService.GetAllKeyValuePairs();
                return this.View();
            }

            await this.propertiesService.UpdateAsync(id, property);

            return this.RedirectToAction("ById", new { id = id });
        }

        public IActionResult All(int id = 1)
        {
            const int ItemsPerPage = 6;

            var viewModel = new PropertiesListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                PropertiesCount = this.propertiesService.GetCount(),
                Properties = this.propertiesService.GetAll<VisualisePropertiesViewModel>(id, ItemsPerPage),
            };
            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            this.ViewBag.userId = this.userManager.GetUserId(this.HttpContext.User);

            var property = this.propertiesService.GetById<PropertiesDetailsViewModel>(id);
            return this.View(property);
        }

        public IActionResult SortByPriceAsc(int id = 1)
        {
            const int ItemsPerPage = 6;

            var viewModel = new PropertiesListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                PropertiesCount = this.propertiesService.GetCount(),
                Properties = this.propertiesService.GetAll<VisualisePropertiesViewModel>(id, ItemsPerPage).OrderByDescending(x => x.Price),
            };
            return this.View(viewModel);
        }

        public IActionResult SortByPriceDesc(int id = 1)
        {
            const int ItemsPerPage = 6;

            var viewModel = new PropertiesListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                PropertiesCount = this.propertiesService.GetCount(),
                Properties = this.propertiesService.GetAll<VisualisePropertiesViewModel>(id, ItemsPerPage).OrderBy(x => x.Price),
            };
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            await this.propertiesService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.All));
        }

        [HttpPost]
        public async Task<IActionResult> SendToEmail(int id)
        {
            return this.RedirectToAction(nameof(this.ById), new { id });
        }
    }
}
