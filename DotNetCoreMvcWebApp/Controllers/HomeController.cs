using DotNetCoreMvcWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreMvcWebApp.Controllers
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
            this._logger.LogDebug("HomeController - Index - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            return View();
        }

        public IActionResult Privacy()
        {
            this._logger.LogWarning("HomeController - Privacy - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            this._logger.LogError("HomeController - Error - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
