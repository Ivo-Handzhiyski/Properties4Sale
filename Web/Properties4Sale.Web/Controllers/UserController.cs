namespace Properties4Sale.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Data;
    using Properties4Sale.Web.ViewModels.Property;
    using Properties4Sale.Web.ViewModels.User;

    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPropertiesService propertiesService;

        public UserController(
            UserManager<ApplicationUser> userManager,
            IPropertiesService propertiesService)
        {
            this.userManager = userManager;
            this.propertiesService = propertiesService;
        }

        public IActionResult PropertiesForUser(string userId, int id = 1)
        {
            const int ItemsPerPage = 6;

            userId = this.userManager.GetUserId(this.User);

            var viewModel = new PropertiesForUserViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                Properties = this.propertiesService.GetPropertiesForUser<VisualisePropertiesViewModel>(userId, id, ItemsPerPage),
            };
            return this.View(viewModel);
        }
    }
}
