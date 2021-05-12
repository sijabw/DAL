namespace SweetFab.Security.Identity
{
    public class Director
        : User
    {
        public Director(int userId, string name, int sweetfabId)
            : base(userId, name, sweetfabId, nameof(Director))
        {
        }
    }
}