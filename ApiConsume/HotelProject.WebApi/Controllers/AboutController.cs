using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            return Ok(_aboutService.TGetList());
        }

        [HttpPost]
        public IActionResult AddRoom(About about)
        {
            _aboutService.TInsert(about);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = _aboutService.TGetByID(id);
            _aboutService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(About about)
        {
            _aboutService.TUpdate(about);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values = _aboutService.TGetByID(id);
            return Ok(values);
        }
    }
}

