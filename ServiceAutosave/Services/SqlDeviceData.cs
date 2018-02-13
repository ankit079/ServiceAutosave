using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autosave.Data;
using Autosave.Models;

namespace Autosave.Services
{
    public class SqlDeviceData : IDeviceData
    {
        private DeviceDbContext _context;

        public SqlDeviceData (DeviceDbContext context)
        {
            _context = context;
        }
        public Device Add(Device device)
        {
            _context.Devices.Add(device);
            _context.SaveChanges();
            return device;
        }

        public Device Get(string functionalLocation)
        {
            return _context.Devices.FirstOrDefault(x => x.FunctionalLocationNumber == functionalLocation);
        }

        public IEnumerable<Device> GetAll()
        {
            return _context.Devices.OrderBy(x => x.FunctionalLocationNumber);
        }

        public Device Update(Device device)
        {
            _context.Attach(device).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return device;
        }
    }
}
