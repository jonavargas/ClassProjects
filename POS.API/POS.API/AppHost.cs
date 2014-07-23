using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POS.API
{
    public class AppHost : AppHostBase
    {
        //Tell ServicesStacks the name of yoye application and where to find your services
        public AppHost() : base("Products Web Services", typeof(ProductService).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            //register any dependencies your services use, e.g:           
        }
    }
}