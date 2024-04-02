using _475_Lab_3.Models;
using _475_Lab_3.Services;
using Microsoft.AspNetCore.Mvc;

namespace _475_Lab_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHolidaysApiService _holidaysApiService;

        public HomeController(IHolidaysApiService holidaysApiService)
        {
            _holidaysApiService = holidaysApiService;
        }

        public async Task<IActionResult> Index(string countryCode="US", int year=2024)
        {
            List<HolidayModel> holidays = new List<HolidayModel>();
            holidays = await _holidaysApiService.GetHolidays(countryCode, year);

            return View(holidays);
        }
    }
}
