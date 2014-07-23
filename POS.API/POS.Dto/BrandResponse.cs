using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dto
{
    public class BrandResponse
    {
        public string Result { get; set; }


        /// <summary>
        /// List of Products
        /// </summary>
        public List<Brand> Brand { get; set; }

        public BrandResponse() 
        {
            Brand = new List<Brand>();
            Result = string.Empty;
        }
    }
}
