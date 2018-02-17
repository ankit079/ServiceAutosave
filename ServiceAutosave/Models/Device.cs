using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autosave.Models
{
    public class Device
    {   [Key]
        public string FunctionalLocationNumber { get; set; }
        public string Description { get; set; }
        [Required, MaxLength(100)]
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        [Required, MaxLength(100)]
        public string DeviceType { get; set; }
        public string ConfigurationSoftware { get; set; }
    }
}
