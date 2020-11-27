namespace Properties4Sale.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Data;
    using Properties4Sale.Web.ViewModels.Property;

    public class PropertiesController : Controller
    {
        private readonly ITypeOfPropertiesService typeOfPropertiesService;
        private readonly IPropertiesService propertiesService;
        private readonly UserManager<ApplicationUser> userManager;

        public PropertiesController(
            ITypeOfPropertiesService typeOfPropertiesService,
            IPropertiesService propertiesService,
            UserManager<ApplicationUser> userManager)
        {
            this.typeOfPropertiesService = typeOfPropertiesService;
            this.propertiesService = propertiesService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreatePropertyInputModel();
            viewModel.TypeOfPropertiesItems = this.typeOfPropertiesService.GetAllKeyValuePairs();
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
            await this.propertiesService.CreateAsync(input, user.Id);

            return this.Redirect("/");
        }

        public IActionResult All(int id)
        {
            return this.View();
        }
    }
}
