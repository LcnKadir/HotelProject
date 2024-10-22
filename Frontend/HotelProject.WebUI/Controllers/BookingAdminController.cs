using HotelProject.WebApi.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.BookingDto;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        public readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responsemesagge = await client.GetAsync("http://localhost:5219/api/Booking");

            if (responsemesagge.IsSuccessStatusCode)
            {
                var jsonData = await responsemesagge.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> ApprovedReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(id);
            StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responsemessage = await client.PutAsync($"http://localhost:5219/api/Booking/StatusChangeApproved/{id}", stringContent);

            return RedirectToAction(nameof(Index));
        }
    }
}
