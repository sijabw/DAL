using SweetFab.Security.Identity;

namespace SweetFab.Security
{
    public static class SecurityContext
    {
        static User _user = null;
​
        public static User GetUser()
        {
            return _user;
        }
​
        public static void SetUser(User user)
        {
            _user = user;
        }
    }
}
