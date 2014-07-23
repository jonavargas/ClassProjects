using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantMenu.Models
{
    public class MenuModel
    {
        public string name { get; set; }
        public string category { get; set; }
        public List<RestaurantMenu.DataAccess.Meal> meals { get; set; }
        public string telefono { get; set; }
        public List<RestaurantMenu.DataAccess.Meal> menu { get; set; }
    }
}