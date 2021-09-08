using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcdemo.Models;

namespace mvcdemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Mututwa", 
                Gender = "Male",
                City = "Lusaka"
            };

            return View(employee);
        }
    }
}
