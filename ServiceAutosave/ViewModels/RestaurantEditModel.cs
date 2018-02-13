using Autosave.Models;
using System.ComponentModel.DataAnnotations;

namespace Autosave.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        public string name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
