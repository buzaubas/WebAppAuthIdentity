using WebAppAuthIdentity.Models;

namespace WebAppAuthIdentity.Service
{
    public interface IAuthService
    {
        Task<User> ValidateUser(string username, string password);
    }
}
