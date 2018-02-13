using Microsoft.EntityFrameworkCore;
using Autosave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autosave.Data
{
    public class DeviceDbContext : DbContext
    {
        public DeviceDbContext (DbContextOptions options) : base(options)
        {

        }
        public DbSet<Device> Devices { get; set; }
    }
}
