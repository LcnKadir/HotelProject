using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Reflection;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //Hotel ids consumed //Otel id'leri consume edildi

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://airbnb19.p.rapidapi.com/api/v1/searchPropertyByPlace?id=ChIJ7cv00DwsDogRAMDACa2m4K8&display_name=Chicago%2C%20IL&totalRecords=10&currency=USD&adults=1"),
                Headers =
    {
        { "x-rapidapi-key", "a41b4114e6mshe5cd256aaeeb19ep1110dejsn3944fd86b519" },
        { "x-rapidapi-host", "airbnb19.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<BookingApiResponseViewModel>(body);

                return View(model.data.Take(1).ToList());
            }
        }
    }
}
