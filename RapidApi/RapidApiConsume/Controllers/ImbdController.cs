using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class ImbdController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //It was created to control the list extraction process from RapidApi.
            //RapidApi den liste çekme işlemini kontrol etmek amacıyla oluşturuldu.

            List<ApiMovieViewModel> model = new();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/series/"),
                Headers =
        {
            { "x-rapidapi-key", "52f4504e88msh2849eac950a5932p1ad857jsn6713ca118f2e" },
            { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
        },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync(); Console.WriteLine(body);
                model = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);

                return View(model);
            }
        }
    }
}
