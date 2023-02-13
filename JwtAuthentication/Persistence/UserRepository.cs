using JwtAuthentication.Constants;
using JwtAuthentication.Models;

namespace JwtAuthentication.Persistence
{
    public class UserRepository 
    {

        public static List<UserModel> Users = new List<UserModel>() {
            new(){Username ="randy_azozo",EmailAddress="randy.azozo@gmail.com",Password="Pass_Word123",GivenName="Randy Joseph",PhoneNumber="233540334565",Surname="Scout",Role="Administrator"},
            new(){Username ="danny_mars",EmailAddress="danny.mars@gmail.com",Password="Pass_Word233",GivenName="Danny Mars",PhoneNumber="233540545565",Surname="Mars",Role="Standard"},
            new(){Username ="coded",EmailAddress="passion.@gmail.com",Password="Pass_Word1212",GivenName="Tettey Faith",PhoneNumber="233540111565",Surname="Faith",Role="Standard"}


        };

       

    }
}
