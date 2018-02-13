using Microsoft.EntityFrameworkCore;
using Autosave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autosave.Data
{
    public class AutosaveDbContext : DbContext
    {
        public AutosaveDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
