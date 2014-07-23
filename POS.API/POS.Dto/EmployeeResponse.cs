using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dto
{
    public class EmployeeResponse
    {

        //Indica si hubo exito o fallo
        public string Result { get; set; }
        //Lista de restaurantes
        public List<Employee> Employee { get; set; }

        public EmployeeResponse()
        {
            Employee = new List<Employee>();
            Result = string.Empty;
        }
    }
}
