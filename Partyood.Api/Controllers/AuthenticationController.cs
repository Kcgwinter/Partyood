using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Partyood.Contracts.Authentication;

namespace Partyood.Api.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            return Ok(request);
        }

        [HttpPost("login")]
        public IActionResult login(LoginRequest request)
        {
            return Ok(request);
        }
    }
}
