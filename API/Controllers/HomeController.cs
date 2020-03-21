using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.Models;
using BLL.Services;

namespace API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly CoronaService _coronaService;

        public HomeController(ILogger<HomeController> logger, CoronaService coronaService)
        {
            _coronaService = coronaService;
            _logger = logger;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult _Index()
        {
            return View(_coronaService.GetTodayResult());
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
