﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Autosave.Models;
using Autosave.Services;

namespace Autosave.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private IRestaurantData _restaurantData;
        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public EditModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        public IActionResult OnGet(int id)
        {
            Restaurant = _restaurantData.Get(id);
            if(Restaurant == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                _restaurantData.Update(Restaurant);
                return RedirectToAction("Details", "Home", new { id = Restaurant.id });
            }
            return Page();
        }
    }
}