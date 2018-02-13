using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autosave.Data;
using Autosave.Models;

namespace Autosave.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private AutosaveDbContext _context;

        public SqlRestaurantData(AutosaveDbContext context)
        {
            _context = context;

        }
        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(x => x.id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {   
            return _context.Restaurants.OrderBy(x => x.name);
        }

        public Restaurant Update(Restaurant restaurant)
        {
            _context.Attach(restaurant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return restaurant;
        }
    }
}
