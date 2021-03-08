using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutureInvestmentCalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureInvestmentCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FutureValue = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel fv)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FutureValue = fv.Calculate().ToString("c2");
            }
            else
            {
                ViewBag.FutureValue = "";
            }

            return View();
        }
    }
}
