using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {

        [HttpGet("[action]")]
        public IActionResult TokenCreated()
        {
            return Ok(new CreateToken().TokenCreate());
        }

        [HttpGet("[action]")]
        public IActionResult TokenCreateAdmin()
        {
            return Ok(new CreateToken().TokenCreateAdmin());
        }


        //Testing operations
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test2()
        {
            return Ok("Welcome!");
        }

        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult Test3()
        {
            return Ok("token received, Welcome!");
        }
    }
}
