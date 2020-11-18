namespace Properties4Sale.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Properties4Sale.Services.Data;
    using Properties4Sale.Web.ViewModels.Property;

    public class PropertiesController : Controller
    {
        private readonly ITypeOfPropertiesService typeOfPropertiesService;
        private readonly IPropertiesService propertiesService;

        public PropertiesController(
            ITypeOfPropertiesService typeOfPropertiesService,
            IPropertiesService propertiesService)
        {
            this.typeOfPropertiesService = typeOfPropertiesService;
            this.propertiesService = propertiesService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreatePropertyInputModel();
            viewModel.TypeOfPropertiesItems = this.typeOfPropertiesService.GetAllKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePropertyInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.TypeOfPropertiesItems = this.typeOfPropertiesService.GetAllKeyValuePairs();
                return this.View(input);
            }

            await this.propertiesService.CreateAsync(input);

            return this.Redirect("/");
        }
    }
}
