using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dto
{
    [Route("/Brand/")]
    [Route("/Brand/{Id}")]
    [Route("/Brand/{Name}")]
    public class Brand
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }
}
