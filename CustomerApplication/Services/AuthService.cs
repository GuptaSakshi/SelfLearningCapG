namespace CustomerApplication.Services
{
    public class AuthService : IAuthService
    {
        // Hardcoded username and password for simplicity
        private const string AdminUsername = "admin";
        private const string AdminPassword = "password";

        public bool ValidateUser(string username, string password)
        {
            return username == AdminUsername && password == AdminPassword;
        }
    }
}
