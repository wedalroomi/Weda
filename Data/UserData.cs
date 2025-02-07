public class User
{
    public int Id { get; set; } // Användarens ID
    public string Name { get; set; } = string.Empty; // Standardvärde
    public string Email { get; set; } = string.Empty; // Standardvärde
    public Address Address { get; set; } = new Address(); // Initiera ett nytt objekt
    public Company Company { get; set; } = new Company(); // Initiera ett nytt objekt
    public string Website { get; set; } = string.Empty; // 🛠 Lägg till denna rad!
}

public class Address
{
    public string Street { get; set; } = string.Empty; // Standardvärde
    public string Suite { get; set; } = string.Empty; // Standardvärde
    public string City { get; set; } = string.Empty; // Standardvärde
    public string Zipcode { get; set; } = string.Empty; // 🛠 Ändra `ZipCode` till `Zipcode`
}

public class Company
{
    public string Name { get; set; } = string.Empty; // Standardvärde
    public string CatchPhrase { get; set; } = string.Empty; // Standardvärde
    public string Bs { get; set; } = string.Empty; // 🛠 Lägg till denna rad!
}
