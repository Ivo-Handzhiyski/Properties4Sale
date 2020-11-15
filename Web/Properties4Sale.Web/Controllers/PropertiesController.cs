using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Properties4Sale.Web.Controllers
{
    public class PropertiesController : Controller
    {
        public IActionResult ForSale()
        {
            return this.View();
        }

        public IActionResult ForRent()
        {
            return this.View();
        }
    }
}
