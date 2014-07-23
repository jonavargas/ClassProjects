using RestaurantMenu.DataAccess;
using RestaurantMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMenu.Controllers
{
    public class MenuController : Controller
    {
        private RestaurantMenuEntities db = new RestaurantMenuEntities();
        //
        // GET: /Menu/

        public ActionResult Index(int id = 0)
        {
            //model = db.Restaurant.Where(model => model.Id).ToList();
            Restaurant restaurant = db.Restaurants.Find(id);
            var menu = new MenuModel()
            {
                name = restaurant.Name,
                category = restaurant.RestaurantCategory.Name,
                meals = restaurant.Meals.ToList(),
                telefono = restaurant.Telephone
            };

            return View(menu);
        }


    }
}
