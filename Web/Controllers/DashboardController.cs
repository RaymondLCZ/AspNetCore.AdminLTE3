using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Zee.AspNetCore.AdminLTE3.Web.Models;

namespace Zee.AspNetCore.AdminLTE3.Web.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public DashboardController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }
    }
}