using eVjezba1.Models;
using eVjezbe1.Infrastructure.UoW;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eVjezba1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork=(UnitOfWork)unitOfWork;
        }

        public IActionResult Index()
        {
            var users = _unitOfWork._userRepository.GetByUsername("dena@fit.ba");
            return View(users);
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