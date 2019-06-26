using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpecialTemplateSample.Models;

namespace SpecialTemplateSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Person person = new Person();
            person.Id = 1;
            person.Name = "Hripsime";
            person.Role = Role.User;
            return View(person);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
