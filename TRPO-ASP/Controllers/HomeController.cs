using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TRPO_Lab3.Lib;

namespace TRPO_ASP.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string BRadius, string sradius, string height)
        {
            double Square = new Math_1().Formula(Convert.ToDouble(BRadius), Convert.ToDouble(sradius), Convert.ToDouble(height));
            ViewBag.Result = Square;
            return View();
        }
        
        
    }
}