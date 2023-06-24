using Microondas.Models;

namespace Microondas.Repository
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new() { Id = 1, Username = "carreta", Password = "furacao", Role = "chefe"},
                new() { Id = 2, Username = "batman", Password = "batman", Role= "chefe2"}
            };
            return users
                .FirstOrDefault(x =>
                x.Username == username
                && x.Password == password);
        }
    }
}
