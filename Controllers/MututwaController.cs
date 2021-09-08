using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdemo.Controllers
{
    public class MututwaController : Controller
    {
        public String Index()
        {
            return "Hello from Mututwa";
        }

        //Method 1: Passing data to the view using (ViewBag)
        /*public ActionResult WirePick()
        {
            ViewBag.Countries = new List<string>() {
                "Zambia",
                "New Zealand",
                "Russia"
            };

            return View();
        }*/

        //Method 2: Passing data to the view using (ViewData)
        public ActionResult WirePick()
        {
            ViewData["Countries"] = new List<string>() {
                "Zambia",
                "New Zealand",
                "Russia"
            };

            return View();
        }
    }
}
