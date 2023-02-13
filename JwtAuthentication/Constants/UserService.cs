using JwtAuthentication.Models;
using JwtAuthentication.Persistence;

namespace JwtAuthentication.Constants
{
    public class UserService : IUserService
    {
        public UserModel GetUser(UserLogin userLogin)
        {
            UserModel? user = UserRepository.Users.FirstOrDefault(x => x.Username.Equals(userLogin.Username,StringComparison.OrdinalIgnoreCase) && x.Password == userLogin.Password);

            return user;
        }
    }
}
