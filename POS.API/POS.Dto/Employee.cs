using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dto
{
    [Route("/Employee/")]
    [Route("/Employee/{Id}")]
    [Route("/Employee/{Name}")]
   public class Employee
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public int Phone { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
    }

}
