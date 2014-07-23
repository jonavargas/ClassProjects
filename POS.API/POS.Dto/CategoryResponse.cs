using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dto
{
    public class CategoryResponse
    {
        //Indica si hubo exito o fallo
        public string Result { get; set; }

        //Lista de restaurantes
        public List<Category> Category { get; set; }

        public CategoryResponse()
        {
            Category = new List<Category>();
            Result = string.Empty;
        }
    }
}
