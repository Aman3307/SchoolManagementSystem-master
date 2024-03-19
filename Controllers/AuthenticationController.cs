using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models.Common;
using SchoolManagementSystem.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly JwtService _jwtService;

        public AuthenticationController(IUserService userService, JwtService jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            var user = await _userService.Authenticate(loginRequest.Username, loginRequest.Password);

            if (user == null)
                return Unauthorized();

            var token = _jwtService.GenerateJwtToken(user);
            return Ok(new { token });
        }
    }
}
