using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dto
{
    public class ClientsResponse
    {
        //Indica si hubo exito o fallo
        public string Result { get; set; }

        //Lista de restaurantes
        public List<Clients> Clients { get; set; }

        public ClientsResponse()
        {
            Clients = new List<Clients>();
            Result = string.Empty;
        }
    }
}
