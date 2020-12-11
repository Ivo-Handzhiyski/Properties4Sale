namespace Properties4Sale.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Create()
        {
            return this.View();
        }

        public IActionResult All()
        {
            return this.View();
        }
    }
}
