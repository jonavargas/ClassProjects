using POS.Dto;
using ServiceStack;
using POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employee = POS.Dto.Employee;

namespace POS.API
{
    public class EmployeeService : Service
    {
    
   
        //Employee me va a traer todo -> get all employee
        //employee/{id}-> get employee by id


        public object Get(POS.Dto.Employee request) {

            var response = new EmployeeResponse();
            response.Result = "hola mundo";

            try
            {
                if (request.Id.HasValue)
                {
                    var employee=GetById(request.Id.Value);
                    response.Employee.Add(employee);
                    response.Result = "1 Employee was found";

                }
                else { 
                
                  //Get all
                    response.Employee = GetByAll();
                    response.Result = "All Employees was found";
                }
            }

            catch(Exception) {             
            
            }

            return response;        
        }

        private static Dto.Employee GetById(int id )
        {
            //jalamos  base de datos
            var entities = new POSEntities();
            var employeeTemp = entities.Employee.Find(id);

            //traducimos a dto bus
            var employee = new Employee();
            employee.Id = employeeTemp.id;
            employee.Name = employeeTemp.name;
            employee.LastName1 = employeeTemp.lastName1;
            employee.LastName2 = employeeTemp.lastName2;
            employee.Phone = employeeTemp.phone;
            employee.User= employeeTemp.user;
            employee.Pass = employeeTemp.pass;
           


            //retornamos  
            return employee;
          
        }
        

        private static List< Dto.Employee> GetByAll()
        {
            


            //jalamos  base de datos
            var entities = new POSEntities();
            var employeesTemp = entities.Employee;

            //creamos lista vacia de dto
            var listofEmployee = new List<Dto.Employee>();

            //recorremos la lista de employees temporal

            foreach (var item in employeesTemp)
            {

                //traducimos a dto employees
                var employee = new Employee();
                employee.Id = item.id;
                employee.Name = item.name;
                employee.LastName1 = item.lastName1;
                employee.LastName2 = item.lastName2;
                employee.Phone = item.phone;
                employee.User= item.user;
                employee.Pass = item.pass;
                
                listofEmployee.Add(employee);
            }


            return listofEmployee;
        }
    }
}