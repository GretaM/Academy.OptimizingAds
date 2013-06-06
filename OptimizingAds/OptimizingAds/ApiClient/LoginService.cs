using ApiClient.SecurityService;

namespace ApiClient
{
    public class LoginService
    {
        public static string Login(string login, string password)
        {
            var client = new SecurityServiceClient();

            return client.Login(new LoginData
                             {
                                 Password = password,
                                 UserName = login
                             });
        }
    }
}

