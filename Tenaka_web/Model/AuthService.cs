using Tenaka_Core.Interfaces;

namespace Tenaka_Core.Data
{

    

    public class AuthService: IAuthService
    {

        public string _username { get; set; }
        public string _password { get; set; }


        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            // Dummy authentication logic for demo purposes
            if (username == "admin" && password == "password")
            {
                _username = username;
                _password = password;
                return true;
            }
            return false;
        }
    }
}
