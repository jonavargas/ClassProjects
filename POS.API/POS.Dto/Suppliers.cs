using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dto
{
    [Route("/Suppliers/")]
    [Route("/Suppliers/{Id}")]
    [Route("/Suppliers/{Name}")]
    public class Suppliers
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Detail { get; set; }
    }
}