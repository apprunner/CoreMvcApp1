using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMvcApp1.Models;

namespace CoreMvcApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> products=new List<string>();
            for(int i=0;i<10;i++)
            {
                products.Add($"Product{i}");
            }

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
