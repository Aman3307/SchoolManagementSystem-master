using SchoolManagementSystem.Models.Common;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Interface
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }
}
