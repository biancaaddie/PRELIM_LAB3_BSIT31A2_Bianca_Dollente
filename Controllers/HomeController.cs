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
            var customerList = new List<Customer>();

            var regular = new Customer
            {
                FirstName = "Bianca Adrienne",
                MiddleName = "Claveria",
                LastName = "Dollente",
                BirthDay = new DateTime(2005, 1, 24),
                CustomerId = 1001
            };

            var vip = new PremiumCustomer
            {
                FirstName = "Kirby",
                MiddleName = "Lecaroz",
                LastName = "Claveria",
                BirthDay = new DateTime(2010, 3, 15),
                CustomerId = 2001
            };

            customerList.Add(regular);
            customerList.Add(vip);

            ViewBag.CustomerList = customerList;

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
