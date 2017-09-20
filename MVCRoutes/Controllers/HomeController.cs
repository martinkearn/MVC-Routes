using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCRoutes.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MVCRoutes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Codes()
        {
            var data = RouteData.Values["data"];
            var dataValue = (data != null) ? RouteData.Values["data"].ToString() : string.Empty;


            var vm = new CodesViewModel() { Data = dataValue };

            return View(vm);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
