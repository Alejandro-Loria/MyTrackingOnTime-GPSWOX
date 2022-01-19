using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MyTrackingOnTime.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyTrackingOnTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Message = TempData["Message"];
            return View();
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
