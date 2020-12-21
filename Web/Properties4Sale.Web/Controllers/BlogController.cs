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
                await this.blogsService.CreateAsync(input, user.Id, $"{this.environment.WebRootPath}/images");
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                Console.WriteLine(ex.InnerException.Message);
                return this.View(input);
            }

            return this.Redirect("/");
        }

        public IActionResult All(int id = 1)
        {
            const int itemsPerPage = 6;

            var viewModel = new BlogListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                BlogsCount = this.blogsService.GetCount(),
                Blogs = this.blogsService.GetAll<VisualizeBlogViewModel>(id, itemsPerPage),
            };

            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var blog = this.blogsService.GetById<BlogDetailsViewModel>(id);

            return this.View(blog);
        }

        public IActionResult Edit(int id)
        {
            var inputModel = this.blogsService.GetById<EditBlogInputModel>(id);

            return this.View(inputModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditBlogInputModel property)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.blogsService.UpdateAsync(id, property);

            return this.RedirectToAction("ById", new { id = id });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            await this.blogsService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.All));
        }
    }
}
