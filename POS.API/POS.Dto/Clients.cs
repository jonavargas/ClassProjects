using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dto
{
    [Route("/Clients/")]
    [Route("/Clients/{Id}")]
    [Route("/Clients/{Name}")]
   public class Clients
    {
        public int? Id { get; set; }
       public string Name { get; set; }
       public string LastName1 { get; set; }
       public string LastName2 { get; set; }
       public string Address { get; set; }
       public int Phone { get; set; }

    }
}
