namespace BlazorApp4.Services
{
    public interface IUserService
    {
        List<User> GetUsers(); // Hämtar alla användare
        void AddUser(User user); // Lägger till en användare
    }
}
