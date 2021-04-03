using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReadFromTXT.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
namespace ReadFromTXT.Controllers
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
            string filePath = @"C:\Users\Khan\Desktop\buraxilis - 2 yoxlama.txt";

            List<string> lines = System.IO.File.ReadAllLines(filePath).ToList();
            ViewBag.Lines = lines;
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
