namespace Properties4Sale.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Data;
    using Properties4Sale.Web.ViewModels.Blog;

    public class BlogController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IBlogsService blogsService;
        private readonly IWebHostEnvironment environment;

        public BlogController(
            UserManager<ApplicationUser> userManager,
            IBlogsService blogsService,
            IWebHostEnvironment environment)
        {
            this.userManager = userManager;
            this.blogsService = blogsService;
            this.environment = environment;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreateBlogInputModel();

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBlogInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            try
            {
                await this.blogsService.CreateAsync(input, user.Id);
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                Console.WriteLine(ex.InnerException.Message);
                return this.View(input);
            }

            return this.Redirect("/");
        }

        public IActionResult All()
        {
            return this.View();
        }
    }
}
