﻿/* A view model represents the data that you want to display on your view/page,
   whether it be used for static text or for input values (like textboxes and dropdown lists) 
   that can be added to the database (or edited).*/

using Autosave.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Autosave.ViewModels
{
    public class DevicePageViewModel
    {
        public IEnumerable<Device> Devices { get; set; }           
    }
}
