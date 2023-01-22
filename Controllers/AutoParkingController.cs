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

        AutoParkingManager AutoParkingManager = new AutoParkingManager();
        public IActionResult Index()
        {
           

           var list = AutoParkingManager.GetAutos();
            return View(list);
        }
        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add(AutoParkingModel automodel)
        {
            
            AutoParkingManager.AddAuto(automodel);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Remove(int id)
        {
            var auto = AutoParkingManager.GetAuto(id);
            return View(auto);
        }
        [HttpPost]
        public IActionResult RemoveConfirm(int id) 
        {
            AutoParkingManager.RemoveAuto(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
           var auto= AutoParkingManager.GetAuto(id);
            return View(auto);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var auto = AutoParkingManager.GetAuto(id);
            return View(auto);
        }
        [HttpPost]
        public IActionResult Edit(AutoParkingModel automodel)
        {
            AutoParkingManager.UpdateAuto(automodel);
            return RedirectToAction("Index"); 
        }
        public IActionResult SprzedajAuto(int id)
        {
            var auto = AutoParkingManager.GetAuto(id);
            AutoParkingManager.sprzedajAuto(auto);
            return RedirectToAction("Index");
        }
    }
}
