using POS.Dto;
using POS.Data;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Products = POS.Dto.Products;

namespace POS.API
{
    public class ProductService : Service
    {
        // /products    -> Get All Products
        // products/{id}  -> Get Products by id
        public object Get(POS.Dto.Products request) 
        {
            var response = new ProductsResponse();

            try
            {
                if (request.Id.HasValue)  // si tiene valor entra aqui
                {                    
                    var products = GetById(request.Id.Value);
                    response.Products.Add(products);
                    response.Result = "1 Product was found";
                }
                else 
                {
                    response.Products = GetAll();
                    response.Result = "All Products was found";
                }
            }
            catch (Exception)
            {
                throw;
            }


            return response;
        }

        // Get by Id
        private static Dto.Products GetById(int id)
        {
            var entities = new POSEntities();
            var productsTemp = entities.Products.Find(id);

            var products = new Products();
            products.Id = productsTemp.id;
            products.Name = productsTemp.name;
            products.Code = productsTemp.code;
            products.CostPrice = productsTemp.costPrice;
            products.Category_Id = productsTemp.category_Id;
            products.Brand_Id = productsTemp.brand_Id;

            return products;
        }

        private static List<Dto.Products> GetAll() 
        {
            var entities = new POSEntities();
            var productsTemp = entities.Products;

            var productsList = new List<Dto.Products>();

            foreach (var item in productsTemp)
            {

                //traducimos a dto bus
                var products = new Products();
                products.Id = item.id;
                products.Name = item.name;
                products.Code = item.code;
                products.CostPrice = item.costPrice;
                products.Category_Id = item.category_Id;
                products.Brand_Id = item.brand_Id;
                productsList.Add(products);
            }
            return productsList;
        }
    }
}