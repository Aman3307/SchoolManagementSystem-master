using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Services
{
    public class JwtAuthenticationService : IAuthenticationService
    {
        private readonly IConfiguration _configuration;
        private readonly SchoolDbContext _context;

        public JwtAuthenticationService(IConfiguration configuration, SchoolDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        public async Task<string> Authenticate(string username, string password)
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                return null; // Authentication failed
            }

            var token = GenerateJwtToken(user.UserId, user.RoleId);
            return token;
        }

        private string GenerateJwtToken(int userId, int roleId)
        {
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Secret"]);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                    new Claim(ClaimTypes.Role, roleId.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
