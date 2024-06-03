namespace AeCAddress.Helpers
{
    public interface IMySession
    {
        void CreateSession(UserModel user);
        void RemoveSession();
        UserModel GetSession();
    }
}