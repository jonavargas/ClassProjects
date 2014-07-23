using POS.Dto;
using ServiceStack;
using POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clients = POS.Dto.Clients;

namespace POS.API
{
    public class ClientService : Service
   
    {
    
   
        //Client me va a traer todo -> get all client
        //client/{id}-> get client by id


        public object Get(POS.Dto.Clients request) {

            var response = new ClientsResponse();

            try
            {
                if (request.Id.HasValue)
                {
                    var clients=GetById(request.Id.Value);
                    response.Clients.Add(clients);
                    response.Result = "1 Client was found";

                }
                else { 
                
                  //Get all
                    response.Clients = GetByAll();
                    response.Result = "All Clients was found";
                }
            }

            catch(Exception) {             
            
            }

            return response;        
        }

        private static Dto.Clients GetById(int id )
        {
            //jalamos  base de datos
            var entities = new POSEntities();
            var clientsTemp = entities.Client.Find(id);

            //traducimos a dto bus
            var clients = new Clients();
            clients.Id = clientsTemp.id;
            clients.Name = clientsTemp.name;
            clients.LastName1 = clientsTemp.lastName1;
            clients.LastName2 = clientsTemp.lastName2;
            clients.Address = clientsTemp.address;
            clients.Phone = clientsTemp.phone;           
                       


            //retornamos  
            return clients;
          
        }
        

        private static List< Dto.Clients> GetByAll()
        {
            


            //jalamos  base de datos
            var entities = new POSEntities();
            var clientsTemp = entities.Client;

            //creamos lista vacia de dto
            var listofClients = new List<Dto.Clients>();

            //recorremos la lista de employees temporal

            foreach (var item in clientsTemp)
            {

                //traducimos a dto employees
                var clients = new Clients();
                clients.Id = item.id;
                clients.Name = item.name;
                clients.LastName1 = item.lastName1;
                clients.LastName2 = item.lastName2;
                clients.Address = item.address;
                clients.Phone = item.phone;


                listofClients.Add(clients);
            }
            return listofClients;


        }
    }
}