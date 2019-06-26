using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_test.Models;

namespace MVC_test.Controllers
{
    public class HomeController : Controller
    {
        static IList<Employee> employeeList = new List<Employee>();
        public IActionResult Index()
        {
            return View(employeeList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            employeeList.Add(employee);
            return RedirectToAction("Index");
        }
    }
}
