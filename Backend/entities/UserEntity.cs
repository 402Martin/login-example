namespace Backend.Entities;

public class User
{
  public string Id { get; private set; }
  public string Username { get; set; }
  public string Password { get; set; }

  public User(string username, string password)
  {
    Id = "";
    Username = username;
    Password = password;
  }


}
