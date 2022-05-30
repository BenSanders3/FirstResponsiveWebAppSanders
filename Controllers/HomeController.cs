using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppSanders.Models;

namespace FirstResponsiveWebAppSanders.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.ATY = "";
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(AgeCalcModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ATY = model.AgeThisYear();
            }
            else
            {
                ViewBag.ATY = "";
            }
            return View(model);
        }
    }
}
