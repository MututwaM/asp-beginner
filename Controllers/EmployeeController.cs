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
        public IActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();

            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);

            return View(employee);
        }
    }
}
