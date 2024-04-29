using Assignment4_0501.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment4_0501.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchRoom(DateTime fromDate, DateTime toDate)
        {
            TempData["fromDate"] = fromDate;
            TempData["toDate"] = toDate;

            return RedirectToAction("Index", "Rooms");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}