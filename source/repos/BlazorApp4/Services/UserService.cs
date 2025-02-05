using BlazorApp4.Services; 

public class UserService : IUserService 
{
    private List<User> users = new();

    public UserService()
    {
        // Generera 10 användare vid start
        users = new List<User>
        {
            new User { Name = "Alice", Email = "alice@example.com", Address = new Address { Street = "Main St 1", City = "Stockholm" }, Company = new Company { Name = "Tech AB" } },
            new User { Name = "Bob", Email = "bob@example.com", Address = new Address { Street = "Broadway 23", City = "Göteborg" }, Company = new Company { Name = "Finance Inc." } },
            new User { Name = "Charlie", Email = "charlie@example.com", Address = new Address { Street = "Centralgatan 5", City = "Malmö" }, Company = new Company { Name = "Design Studio" } },
            new User { Name = "David", Email = "david@example.com", Address = new Address { Street = "Storgatan 12", City = "Uppsala" }, Company = new Company { Name = "Retail AB" } },
            new User { Name = "Emma", Email = "emma@example.com", Address = new Address { Street = "Lundavägen 45", City = "Lund" }, Company = new Company { Name = "HealthCare AB" } },
            new User { Name = "Fredrik", Email = "fredrik@example.com", Address = new Address { Street = "Ringvägen 33", City = "Västerås" }, Company = new Company { Name = "Logistics Ltd." } },
            new User { Name = "Greta", Email = "greta@example.com", Address = new Address { Street = "Högbergsgatan 88", City = "Örebro" }, Company = new Company { Name = "Education Services" } },
            new User { Name = "Henrik", Email = "henrik@example.com", Address = new Address { Street = "Torsgatan 21", City = "Helsingborg" }, Company = new Company { Name = "Marketing Co." } },
            new User { Name = "Isabelle", Email = "isabelle@example.com", Address = new Address { Street = "Skolgatan 9", City = "Jönköping" }, Company = new Company { Name = "Consulting Group" } },
            new User { Name = "Jakob", Email = "jakob@example.com", Address = new Address { Street = "Parkvägen 3", City = "Karlstad" }, Company = new Company { Name = "IT Solutions" } }
        };
    }

    public List<User> GetUsers() // Implementera GetUsers()
    {
        return users;
    }

    public void AddUser(User user) // Implementera AddUser()
    {
        users.Add(user);
    }
}
