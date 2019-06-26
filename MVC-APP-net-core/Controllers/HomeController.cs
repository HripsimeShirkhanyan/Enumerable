using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_APP_net_core.Models;

namespace MVC_APP_net_core.Controllers
{
    public class HomeController : Controller 
    {
        public static List<Person> list = new List<Person>();

        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", list);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("AddPerson");
        }
       
        [HttpPost]
        public IActionResult Add(Person person)
        {
            list.Add(person);
            return RedirectToAction("Index"); 
        }
    }
}
