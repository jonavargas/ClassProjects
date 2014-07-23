using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dto
{
    [Route("/Products/")]
    [Route("/Products/{Id}")]
    [Route("/Products/{Name}")]
    public class Products
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public decimal CostPrice { get; set; }
        public int Category_Id { get; set; }
        public int Brand_Id { get; set; }
    }
}
