using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Autosave.Controllers
{
    public class AboutController
    {
        // GET: /<controller>/
        public string Phone()
        {
            return "1+24342324+1";
        }

        public string Address()
        {
            return "Australia";
        }
    }
}
