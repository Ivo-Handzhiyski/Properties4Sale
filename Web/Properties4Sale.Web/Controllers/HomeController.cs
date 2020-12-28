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
    using Properties4Sale.Web.ViewModels.Blog;
    using Properties4Sale.Web.ViewModels.Home;
    using Properties4Sale.Web.ViewModels.Property;

    public class HomeController : BaseController
    {
        private readonly IGetCountService countService;
        private readonly IPropertiesService propertiesService;
        private readonly IBlogsService blogsService;

        public HomeController(
            IGetCountService countService,
            IPropertiesService propertiesService,
            IBlogsService blogsService)
        {
            this.countService = countService;
            this.propertiesService = propertiesService;
            this.blogsService = blogsService;
        }

        public IActionResult Index()
        {
            var counts = this.countService.GetCounts();
            var viewModel = new IndexViewModel
            {
                PropertiesCount = counts.PropertiesCount,
                TypesOfPropertiesCount = counts.TypesOfPropertiesCount,
                VisualiseProperties = this.propertiesService.GetProperties<IndexPropertyVisualizerViewModel>(5),
                VisualisePropertiesRandom = this.propertiesService.GetPropertiesRandom<IndexPropertyVisualizerViewModel>(5),
                VisualiseBlog = this.blogsService.GetBlogs<VisualizeBlogViewModel>(5),
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
