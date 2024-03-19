using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Models.Common;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Repositary
{
    public class UserService : IUserService
    {
        private readonly SchoolDbContext _dbContext;

        public UserService(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> Authenticate(string username, string password)
        {
            // Query the database to find the user with the provided username
            var user = await _dbContext.User.FirstOrDefaultAsync(u => u.Username == username);

            // Check if the user exists and the password matches
            if (user != null && user.Password == password)
            {
                return user;
            }

            // Return null if authentication fails
            return null;
        }
    }
}
