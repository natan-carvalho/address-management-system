namespace AeCAddress.Repository
{
    public interface IUserRepository
    {
        UserModel Create(UserModel user);
        UserModel FindByLogin(string login);
    }
}