using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Autosave.Services;

namespace Autosave.Controllers
{
    public class DeviceController : Controller
    {
        private IDeviceData _deviceData;

        public DeviceController (IDeviceData deviceData)
        {
            _deviceData = deviceData;
        }

        //public IActionResult Index()
        //{
        //    var model = new HomePageViewModel();
        //    model.Restaurants = _restaurantData.GetAll();
        //    model.CurrentMessage = _greeter.GetMessageOfTheDay();
        //    return View(model);
        //}

        //public IActionResult Details(int id)
        //{
        //    var model = _restaurantData.Get(id);
        //    if (model == null)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View(model);
        //}
        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var model = _restaurantData.Get(id);
        //    if (model == null)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View(model);
        //}

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(RestaurantEditModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var newRestaurant = new Restaurant();
        //        newRestaurant.name = model.name;
        //        newRestaurant.Cuisine = model.Cuisine;
        //        newRestaurant = _restaurantData.Add(newRestaurant);
        //        return RedirectToAction("Details", new { id = newRestaurant.id });
        //    }
        //    else
        //    {
        //        return View();
        //    }
        }
    }
