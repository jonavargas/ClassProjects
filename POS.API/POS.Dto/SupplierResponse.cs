using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dto
{
    public class SupplierResponse
    {
        /// <summary>
        /// Indicate if there was success or failure
        /// </summary>
        public string Result { get; set; }


        /// <summary>
        /// List of Products
        /// </summary>
        public List<Suppliers> Supplier { get; set; }

        public SupplierResponse() 
        {
            Supplier = new List<Suppliers>();
            Result = string.Empty;
        }
    }
}
