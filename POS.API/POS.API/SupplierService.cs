using POS.Dto;
using POS.Data;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Suppliers = POS.Dto.Suppliers;

namespace POS.API
{
    public class SupplierService : Service
    {
        public object Get(POS.Dto.Suppliers request)
        {
            var response = new SupplierResponse();

            try
            {
                if (request.Id.HasValue)  // si tiene valor entra aqui
                {
                    var supplier = GetById(request.Id.Value);
                    response.Supplier.Add(supplier);
                    response.Result = "1 Supplier was found";
                }
                else
                {
                    response.Supplier = GetAll();
                    response.Result = "All Suppliers was found";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }

        private static Dto.Suppliers GetById(int id)
        {
            var entities = new POSEntities();
            var suppliersTemp = entities.Suppliers.Find(id);

            var suppliers = new Suppliers();
            suppliers.Id = suppliersTemp.id;
            suppliers.Name = suppliersTemp.name;
            suppliers.Phone = suppliersTemp.phone;
            suppliers.Address = suppliersTemp.address;
            suppliers.Detail = suppliersTemp.detail;

            return suppliers;
        }

        private static List<Dto.Suppliers> GetAll()  
        {
            var entities = new POSEntities();
            var suppliersTemp = entities.Suppliers;

            var suppliersList = new List<Dto.Suppliers>();


            foreach (var item in suppliersTemp)
            {

                //traducimos a dto bus
                var suppliers = new Suppliers();
                suppliers.Id = item.id;
                suppliers.Name = item.name;
                suppliers.Phone = item.phone;
                suppliers.Address = item.address;
                suppliers.Detail = item.detail;
                suppliersList.Add(suppliers);
            }

            return suppliersList;
        }

    }
}