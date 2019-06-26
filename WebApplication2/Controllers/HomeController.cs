using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    //hasgacel es vonc en add anum, vonc update, vonc get? vortexic piti haskanayi :D ba esqan jamanak inch es anum?
    // henc hima mihat es controlleri mej static list sargi u index actionum get ara et liste cuyc tur!!!!!!!!!!!!!!!
    /// <summary>
    /// arandz panika
    /// </summary>
    public class HomeController : Controller
    {
        static IList<Student> studentList = new List<Student>();//che arden usha du actionov es add anelu mi sksi vaaaaay de,ba
        //hima inch em anum// hima sargum es action vore qo liste cuyca talu? heto action vor et listum add a anelu, heto update
        // sksi!


        public IActionResult Index()
        {
            return View(studentList); //senc kareli a?qez karelia , aysinnqn chi kareli :D
            //yes aveli hesht ban ei asum, bayc ok ara)
        }

        //Piti 2 action unenas, mihat httpPost mihat httpGet, get-ov et ejn es bacum vor post anes!
        //ksharunakes? chee vore inchi hamara? qnum es? che, stex em, bayc chgitem
        //en mer grace jnjel es? che, de baci
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student model)
        {
            return View();
        }
    }
}
