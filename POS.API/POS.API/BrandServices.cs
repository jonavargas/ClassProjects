using POS.Dto;
using POS.Data;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Brand = POS.Dto.Brand;

namespace POS.API
{
    public class BrandServices : Service
    {
        public object Get(POS.Dto.Brand request)
        {

            var response = new BrandResponse();
            response.Result = "1 Brand was found";

            try
            {
                if (request.Id.HasValue)
                {
                    var brand = GetById(request.Id.Value);
                    response.Brand.Add(brand);
                    response.Result = "All Brands was found";

                }
                else
                {

                    //Get all
                    response.Brand = GetByAll();
                    response.Result = "was faund all";
                }
            }

            catch (Exception)
            {
                throw;
            }

            return response;
        }

        private static Dto.Brand GetById(int id)
        {
            //jalamos  base de datos
            var entities = new POSEntities();
            var brandTemp = entities.Brand.Find(id);

            //traducimos a dto bus
            var brand = new Brand();
            brand.Id = brandTemp.id;
            brand.Name = brandTemp.name;
            //retornamos  
            return brand;
        }

        private static List<Dto.Brand> GetByAll()
        {
            //jalamos  base de datos
            var entities = new POSEntities();
            var brandTemp = entities.Brand;

            //creamos lista vacia de dto
            var brandList = new List<Dto.Brand>();

            //recorremos la lista de buises temporal

            foreach (var item in brandTemp)
            {

                //traducimos a dto bus
                var brand = new Brand();
                brand.Id = item.id;
                brand.Name = item.name;
                brandList.Add(brand);
            }

            return brandList;
        }
    }
}