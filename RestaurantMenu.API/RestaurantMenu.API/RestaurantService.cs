using RestaurantMenu.Data;
using RestaurantMenu.Dto;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantMenu.API
{
    public class RestaurantService : Service
    {
        // /restaurants    -> Get All Restaurants
        // /restaurants/{Id} -> Get Restaurant By Id
        public object Get(RestaurantMenu.Dto.Restaurant request)
        {
            var response = new RestaurantResponse();

            try
            {
                if (request.Id.HasValue)
                {
                    var restaurant = GetById(request.Id.Value);
                    response.Restaurants.Add(restaurant);
                    response.Result = "1 Restaurant was found";
                }
                else
                {
                    response.Restaurants = GetAll();
                    response.Result = "3 Restaurants were found";
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
            return response;
        }

        private static Dto.Restaurant GetById(int id)
        {
            // Get by id
            var restaurant = new RestaurantMenu.Dto.Restaurant
            {
                Id = id,
                Name = "Coca Loca",
                Email = "coca@loca.com",
                RestaurantCategory = "Steak House"
            };

            return restaurant;
        }

        private static List<Dto.Restaurant> GetAll()
        {
            // Get by id
            var restaurant1 = new RestaurantMenu.Dto.Restaurant
            {
                Id = 1,
                Name = "Coca Loca",
                Email = "coca@loca.com",
                RestaurantCategory = "Steak House"
            };

            var restaurant2 = new RestaurantMenu.Dto.Restaurant
            {
                Id = 2,
                Name = "Charlies Burger",
                Email = "charlies@burger.com",
                RestaurantCategory = "comida chatarra"
            };

            var restaurant3 = new RestaurantMenu.Dto.Restaurant
            {
                Id = 3,
                Name = "Mcdonalds",
                Email = "mc@donalds.com",
                RestaurantCategory = "comida gringa chatarra"
            };

            var listOfRestaurants = new List<Dto.Restaurant>();

            listOfRestaurants.Add(restaurant1);
            listOfRestaurants.Add(restaurant2);
            listOfRestaurants.Add(restaurant3);

            return listOfRestaurants;
        }
    }
}