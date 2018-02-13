using Autosave.Models;
using System.Collections.Generic;

namespace Autosave.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }  

    }
}
