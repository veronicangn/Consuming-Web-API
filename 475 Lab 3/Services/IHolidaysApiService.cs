using _475_Lab_3.Models;

namespace _475_Lab_3.Services
{
    public interface IHolidaysApiService
    {
        Task<List<HolidayModel>> GetHolidays(string countryCode, int year);
    }
}
