using dragon1.ApiRequests.Models;

namespace dragon1.ApiRequests.Services
{
    public class UserService
    {
        public UserDataShort? CurrentUser { get; private set; }

        public void SetCurrentUser(AuthUserData authData)
        {
            if (authData != null && authData.status && authData.user != null)
            {
                CurrentUser = authData.user;
            }
            else
            {
                CurrentUser = null;
            }
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}