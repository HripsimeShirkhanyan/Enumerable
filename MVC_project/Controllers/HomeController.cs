using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_project.Models;

namespace MVC_project.Controllers
{
    public class HomeController : Controller
    {

        static IList<Book> bookList = new List<Book>();
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult Add(int id)
        //{
        //    return View(bookList);
        //}
        
    }
}
