namespace SweetFab.Security.Identity
{
    public class Accountant
        : User
    {
        public Accountant(int userId, string name, int sweetfabId)
            : base(userId, name, sweetfabId, nameof(Accountant))
        {
        }
    }
}