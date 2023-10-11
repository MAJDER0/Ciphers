using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ciphers.Models;

namespace Ciphers.Controllers
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

        public IActionResult Caesar()
        {
            return View();
        }
        // Other actions
    }
}
