using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoParking.Models;
namespace AutoParking.Controllers
{
    public class AutoParkingController : Controller
    {
        public IActionResult Index()
        {
            var auto = new AutoParkingModel()
            {
                Marka = "Audi",
                Model = "Q5",
                pojemnoscsilnik = 2000,
                Rokprod = 2015,
                cena = 159000,
                czysprzedany = false
            };
            var AutoParkingManager = new AutoParkingManager();
            AutoParkingManager.AddAuto(auto);
            return View();
        }
    }
}
