using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wikiapp.Models;
using wikiapp.Services;

namespace wikiapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var fetch = new FetchApi();
            return View();
        }

        public async Task<IActionResult> FetchData()
        {
            var fetch = new FetchApi();
            var data = await fetch.fetchAsync();
            return Json(data: data);
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