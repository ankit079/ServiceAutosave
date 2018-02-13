using Autosave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autosave.Services
{
    public interface IDeviceData
    {
        IEnumerable<Device> GetAll();
        Device Get(string functionalLocation);
        Device Add(Device device);
        Device Update(Device device);
    }
}
