using System.Diagnostics;
using FourthGroup_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FourthGroup_1.Controllers
{
    public class HomeController : Controller
    {
   
        public IActionResult Index()
        {
            //return Content("Hello World!");

            //ViewBag .name  ="Ahmad";
            //ViewBag.ID = "1";
            //ViewBag.xxx = "Ahmad";
            //ViewBag.xxxx = "Ahmad";

            //Employeecs m = new Employeecs();
            //m.Id = 1;
            //m.Name = "Ahmad";
            //m.Email = "aaaaa";



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
 
    }
}
