using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB3_BSIT31A2_Bianca_Dollente.Models;
using System.Diagnostics;

namespace PRELIM_LAB3_BSIT31A2_Bianca_Dollente.Controllers
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
            List<IDescribable> customers = new List<IDescribable>
            {
                new Customer { Id = 1, Name = "Bianca Adrienne", Email = "biancaadrienne24@gmail.com" },
                new PremiumCustomer { Id = 2, Name = "Adrienne Claveria", Email = "adriennedollente@gmail.com", MembershipLevel = "Gold" }
            };

            return View(customers);
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
