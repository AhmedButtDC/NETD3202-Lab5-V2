using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETD3202_Lab5_V2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NETD3202_Lab5_V2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Returns Index page in Home folder
        public IActionResult Index()
        {
            return View();
        }

        //Unused
        public IActionResult Privacy()
        {
            return View();
        }

        //Unused
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
