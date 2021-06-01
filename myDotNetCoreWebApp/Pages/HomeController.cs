using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myDotNetCoreWebApp.Pages
{
    public class HomeController : Controller
    {
        private ILogger logger;
        public IActionResult Index(ILogger<HomeController> _log)
        {
            this.logger = _log;
            this.logger.LogWarning("I am in Home Index View");

            return View();
        }
    }
}
