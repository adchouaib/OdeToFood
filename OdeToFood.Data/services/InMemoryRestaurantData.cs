using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {ID = 1, Name="Scott's Pizza" , Cuisine=Cuisine.Italien },
                new Restaurant {ID = 2, Name="Tersiguels" , Cuisine=Cuisine.French },
                new Restaurant {ID = 3, Name="Mango Grove" , Cuisine=Cuisine.Indien },
            };
        }


        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public Restaurant GetById(int id)
        {
            return restaurants.FirstOrDefault(r => r.ID == id);
        }

        public void Add(Restaurant restaurant)
        {
            restaurant.ID = restaurants.Max(r => r.ID) + 1;
            restaurants.Add(restaurant);
        }

        public void Update(Restaurant restaurant)
        {
            var existingRestaurant = GetById(restaurant.ID);
            if(existingRestaurant != null)
            {
                existingRestaurant.Name = restaurant.Name;
                existingRestaurant.Cuisine = restaurant.Cuisine;
            }
        }

        public void Delete(int id)
        {
            var r = GetById(id);
            if(r != null)
            {
                restaurants.Remove(r);
            }
        }
        
    }
}