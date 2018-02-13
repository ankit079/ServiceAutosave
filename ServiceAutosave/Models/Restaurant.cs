using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Autosave.Models
{
    public class Restaurant
    {
        public int id { get; set; }
        [Display(Name = "Restaurant Name")]
        [Required, MaxLength(80)]
        public string name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
