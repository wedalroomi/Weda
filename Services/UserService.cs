using BlazorApp4.Services; 

public class UserService : IUserService 
{
    private List<User> users = new();

    public UserService()
    {
        // Generera 10 användare vid start
        users = new List<User>
        {
            new User { Name = "Leanne Graham", Email = "Sincere@april.biz", Address = new Address { Street = "Kulas Light", City = "Gwenborough" }, Company = new Company { Name = "Romaguera-Crona" } },
            new User { Name = "Ervin Howell", Email = "Shanna@melissa.tv", Address = new Address { Street = "Victor Plains", City = "Wisokyburgh" }, Company = new Company { Name = "Deckow-Crist" } },
            new User { Name = "Clementine Bauch", Email = "Nathan@yesenia.net", Address = new Address { Street = "Douglas Extension", City = "McKenziehaven" }, Company = new Company { Name = "Romaguera-Jacobson" } },
            new User { Name = "Patricia Lebsack", Email = "Julianne.OConner@kory.org", Address = new Address { Street = "Hoeger Mall", City = "South Elvis" }, Company = new Company { Name = "Robel-Corkery" } },
            new User { Name = "Chelsey Dietrich", Email = "Lucio_Hettinger@annie.ca", Address = new Address { Street = "Skiles Walks", City = "Roscoeview" }, Company = new Company { Name = "Keebler LLC" } },
            new User { Name = "Dennis Schulist", Email = "Karley_Dach@jasper.info", Address = new Address { Street = "Norberto Crossing", City = "South Christy" }, Company = new Company { Name = "Considine-Lockman" } },
            new User { Name = "Kurtis Weissnat", Email = "Telly.Hoeger@billy.biz", Address = new Address { Street = "Rex Trail", City = "Howemouth" }, Company = new Company { Name = "Johns Group" } },
            new User { Name = "Nicholas Runolfsdottir", Email = "Sherwood@rosamond.me", Address = new Address { Street = "Ellsworth Summit", City = "Aliyaview" }, Company = new Company { Name = "Abernathy Group" } },
            new User { Name = "Clementina DuBuque", Email = "Chaim_McDermott@dana.io", Address = new Address { Street = "Dayna Park", City = "Bartholomebury" }, Company = new Company { Name = "Yost and Sons" } },
            new User { Name = "Glenna Reichert", Email = "Rey.Padberg@karina.biz", Address = new Address { Street = "Kattie Turnpike", City = "Lebsackbury" }, Company = new Company { Name = "Hoeger LLC" } }
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
