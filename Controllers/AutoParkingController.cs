using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoParking.Controllers
{
    public class AutoParkingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
