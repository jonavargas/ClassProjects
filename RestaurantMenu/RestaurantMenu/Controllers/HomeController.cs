using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMenu.Models;

namespace RestaurantMenu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            // get data from DB
                  
            // create model
            var model = new HomeAboutModel
            {
                Test1 = "Esto es una prueba",
                Name = "Carlos Castillo",
                Description = "UTN. Programacion en Ambiente",
                Date = DateTime.Now
            };

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
