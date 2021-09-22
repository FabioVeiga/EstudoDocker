using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspnetcoremvc1.Models;
using aspnetcoremvc1.Interfaces;
using Microsoft.Extensions.Configuration;

namespace aspnetcoremvc1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository _repository;
        private string message;

        public HomeController(ILogger<HomeController> logger, IRepository repository, IConfiguration configuration )
        {
            _logger = logger;
            _repository = repository;
            message = configuration["MESSAGE"] ?? "ASP NET CORE MVC + DOCKER";
        }

        public IActionResult Index()
        {
            ViewBag.message = message;
            return View(_repository.Produtos);
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
