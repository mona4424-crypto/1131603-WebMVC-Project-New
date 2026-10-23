using Microsoft.AspNetCore.Mvc;
using project.Data;
using project.Models;
using System.Diagnostics;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CmsContext _context;

        public HomeController(
            ILogger<HomeController> logger,
            CmsContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.TotalBirds =
                _context.TableBirds1131603.Count();

            ViewBag.ResidentBirds =
                _context.TableBirds1131603
                .Count(b => b.Category == "¯d³¾");

            ViewBag.WaterBirds =
                _context.TableBirds1131603
                .Count(b => b.Category == "¤ô³¾");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0,
            Location = ResponseCacheLocation.None,
            NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId =
                    Activity.Current?.Id ??
                    HttpContext.TraceIdentifier
            });
        }
    }
}