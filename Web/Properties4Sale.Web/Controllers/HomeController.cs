namespace Properties4Sale.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using Properties4Sale.Data;
    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Data;
    using Properties4Sale.Web.ViewModels;
    using Properties4Sale.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IGetCountService countService;

        public HomeController(IGetCountService countService)
        {
            this.countService = countService;
        }

        public IActionResult Index()
        {
            var counts = this.countService.GetCounts();
            var viewModel = new IndexViewModel
            {
                PropertiesCount = counts.PropertiesCount,
                TypesOfPropertiesCount = counts.TypesOfPropertiesCount,
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
