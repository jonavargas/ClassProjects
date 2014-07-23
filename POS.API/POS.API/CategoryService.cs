using POS.Dto;
using ServiceStack;
using POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Category = POS.Dto.Category;

namespace POS.API
{
    public class CategoryService : Service
    {

        public object Get(POS.Dto.Category request)
        {

            var response = new CategoryResponse();

            try
            {
                if (request.Id.HasValue)
                {
                    var category = GetById(request.Id.Value);
                    response.Category.Add(category);
                    response.Result = "1 Category was found";
                }
                else
                {
                    //Get all
                    response.Category = GetByAll();
                    response.Result = "All Categorys was found";
                }
            }
            catch (Exception)
            {

            }

            return response;
        }

        private static Dto.Category GetById(int id)
        {
            //jalamos  base de datos
            var entities = new POSEntities();
            var categoryTemp = entities.Category.Find(id);

            //traducimos a dto bus
            var category = new Category();
            category.Id = categoryTemp.id;
            category.Name = categoryTemp.name;
            category.Description = categoryTemp.description;            

            //retornamos  
            return category;
        }

        private static List<Dto.Category> GetByAll()
        {
            //jalamos  base de datos
            var entities = new POSEntities();
            var categoryTemp = entities.Category;

            //creamos lista vacia de dto
            var listofCategory = new List<Dto.Category>();

            //recorremos la lista de employees temporal

            foreach (var item in categoryTemp)
            {

                //traducimos a dto employees
                var category = new Category();
                category.Id = item.id;
                category.Name = item.name;
                category.Description = item.description;               

                listofCategory.Add(category);
            }
            return listofCategory;
        }
    }
}