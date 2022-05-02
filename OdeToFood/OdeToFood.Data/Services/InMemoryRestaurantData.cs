using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        IEnumerable<Restaurant> Restaurants;

        public InMemoryRestaurantData()
        {
            Restaurants = new List<Restaurant>()
            {
                new Restaurant() { Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian },
                new Restaurant() { Id = 2, Name = "Tersiguels", Cuisine = CuisineType.French },
                new Restaurant() { Id = 3, Name = "Mango Grove", Cuisine = CuisineType.Indian },
                new Restaurant() { Id = 4, Name = "Laguna Grill", Cuisine = CuisineType.Caribbean }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return Restaurants.OrderBy(r => r.Name);
        }
    }
}
