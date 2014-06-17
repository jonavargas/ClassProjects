using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantMenu.Models
{
    public class SearchModel
    {
        public string SearchText { get; set; }
        public List<RestaurantMenu.DataAccess.Restaurant> Restaurants { get; set; }
    }
}