using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu.Dto
{
    [Route("/restaurants/")]
    [Route("/restaurants/{Id}")]    
    public class Restaurant
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RestaurantCategory { get; set; }
    }
}
