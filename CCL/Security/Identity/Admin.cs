namespace SweetFab.Security.Identity
{
    public class Admin
        : User
    {
        public Admin(int userId, string name, int sweetfabId)
            : base(userId, name, sweetfabId, nameof(Admin))
        {
        }
    }
}