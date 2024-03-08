using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Models.Common;
using SchoolManagementSystem.Services;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginModel model)
        {
            var token = await _authenticationService.Authenticate(model.Username, model.Password);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(new { Token = token });
        }
    }
}
