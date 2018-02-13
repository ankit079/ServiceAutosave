using Autosave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autosave.Services
{
    //public class InMemoryRestaurantData :IRestaurantData
    //{
    //    public InMemoryRestaurantData()
    //    {
    //        _restaurants = new List<Restaurant>
    //        {
    //            new Restaurant {id = 1, name = "Scot's Pizza Place"},
    //            new Restaurant {id = 2, name = "Bob's Bakery"},
    //            new Restaurant {id = 3, name = "Tony's IceCream Shop"}
    //        };
    //    }
        
    //    public IEnumerable<Restaurant> GetAll()
    //    {
    //        return _restaurants.OrderBy(x => x.name);
    //    }

    //    public Restaurant Get(int id)
    //    {
    //        return _restaurants.FirstOrDefault(x => x.id == id);
    //    }

    //    public Restaurant Add(Restaurant restaurant)
    //    {
    //        restaurant.id = _restaurants.Max(r => r.id) + 1;
    //        _restaurants.Add(restaurant);
    //        return restaurant;
    //    }

    //    List<Restaurant> _restaurants;
    //}
}
