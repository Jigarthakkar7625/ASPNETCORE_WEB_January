using ASPNETCORE_WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNETCORE_WEB.Controllers
{
    public class HomeController : Controller
    {

        private readonly AtcgsaWithoutAspnetauthContext _atcgsaWithoutAspnetauthContext;
        private readonly ILogger<HomeController> _logger;

        // Constuctor dependancy
        public HomeController(ILogger<HomeController> logger, AtcgsaWithoutAspnetauthContext atcgsaWithoutAspnetauthContext)
        {
            _logger = logger;
            _atcgsaWithoutAspnetauthContext = atcgsaWithoutAspnetauthContext;
        }

        public IActionResult Index()
        {
            var a = _atcgsaWithoutAspnetauthContext.TblUsers.ToList();
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