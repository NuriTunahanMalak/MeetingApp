using System.Diagnostics;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
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
            int saat = DateTime.Now.Hour;
            @ViewBag.selamlama = saat > 12 ? "iyi günler" : "Günaydýn";
            ViewBag.name = "Tuna";
            int UserCount = Repository._userInfos.Where(i => i.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Istanbul",
                Date = DateTime.Now,
                NumberOfPeople = UserCount
            };
            return View(meetingInfo);
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
