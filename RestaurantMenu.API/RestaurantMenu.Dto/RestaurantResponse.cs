using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu.Dto
{
    public class RestaurantResponse
    {

        /// <summary>
        /// Indicate if there was success or failure 
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// List of restaurants
        /// </summary>
        public List<Restaurant> Restaurants { get; set; }

        public RestaurantResponse()
        {
            Restaurants = new List<Restaurant>();
            Result = string.Empty;
        }
    }
}
