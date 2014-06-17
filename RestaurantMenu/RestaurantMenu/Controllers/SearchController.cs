using RestaurantMenu.DataAccess;
using RestaurantMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantMenu.Controllers
{
    public class SearchController : Controller
    {
        private RestaurantMenuEntities db = new RestaurantMenuEntities();// Nos ayuda a conectarnos a la db y esta linea se obtuvo del RestController

        //
        // GET: /Search/

        public ActionResult Index() 
        {
            // get data from db
            var restaurants = db.Restaurants.ToList();

            // create model
            var model = new SearchModel();
            
            // fill restaurants in model
            model.Restaurants = restaurants;

            // return model to the view
            return View(model);
        }

        //public List<Restaurant> Restaurants { get; set; }


        //
        // POST: /Search/
        [HttpPost]
        public ActionResult Index(SearchModel model)
        {
            var search = model.SearchText;

            if (string.IsNullOrEmpty(search))
            {
                model.Restaurants = db.Restaurants.ToList();
            }
            else 
            {
                // fill restaurants in model
                model.Restaurants = db.Restaurants.Where(x => x.RestaurantCategory.Description.Contains(search)).ToList();
            }            

            // return model to the view
            return View(model);
        }
    }
}
