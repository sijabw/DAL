namespace SweetFab.Security.Identity
{
    public abstract class User
    {
        public User(int userId, string name, int osbbId, string userType)
        {
            UserId = userId;
            Name = name;
            SweetFabID = osbbId;
            UserType = userType;
        }
        public int UserId { get; }
        public string Name { get; }
        public int SweetFabID { get; }
        protected string UserType { get; }
    }
}