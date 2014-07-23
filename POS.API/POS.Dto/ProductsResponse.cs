using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dto
{
    
    public class ProductsResponse
    {

        /// <summary>
        /// Indicate if there was success or failure
        /// </summary>
        public string Result { get; set; }


        /// <summary>
        /// List of Products
        /// </summary>
        public List<Products> Products { get; set; }

        public ProductsResponse() 
        {
            Products = new List<Products>();
            Result = string.Empty;
        }

    }
}
