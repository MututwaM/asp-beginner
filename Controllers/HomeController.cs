using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdemo.Controllers
{
    public class HomeController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        public String Index()
        {
            return "Home Controller stuff";
        }
    }
}
