namespace Backend.BuisnessLogic;

using Backend.Entities;

public class UserLogic
{
  private List<User> Users { get; set; }

  public UserLogic()
  {
    this.Users = new List<User>();
  }

  public User CreateUser(string username, string password)
  {
    if (this.Users.Any(u => u.Username == username))
    {
      throw new ArgumentException("Username already exists");
    }
    User newUser = new User(username, password);
    this.Users.Add(new User(username, password));

    return newUser;
  }

  public User GetUserByUsername(string username)
  {
    return this.Users.First(u => u.Username == username);
  }



}
