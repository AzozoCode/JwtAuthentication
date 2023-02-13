using JwtAuthentication.Models;

namespace JwtAuthentication.Constants
{
    public interface IUserService
    {
        public UserModel GetUser(UserLogin user);

    }
}
