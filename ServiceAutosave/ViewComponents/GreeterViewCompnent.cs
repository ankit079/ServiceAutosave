using Microsoft.AspNetCore.Mvc;
using Autosave.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autosave.ViewComponents
{
    public class GreeterViewCompnent :ViewComponent
    {
        private IGreeter _greeter;

        public GreeterViewCompnent(IGreeter greeter)
        {
            _greeter = greeter;
        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            var model = _greeter.GetMessageOfTheDay();
            return Task.FromResult<IViewComponentResult>(View("Default", model));
        }
    }
}
