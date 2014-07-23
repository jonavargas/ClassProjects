using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantMenu.API
{
    public class AppHost : AppHostBase
    {
        //Tell ServiceStack the name of your application and where to find your services
        public AppHost() : base("Restaurant Web Services", typeof(RestaurantService).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            //register any dependencies your services use, e.g:            
        }
    }

}