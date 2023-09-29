namespace Backend.BuisnessLogic;

using Backend.Entities;

public class UserLogic
{
  public List<User> Users { get; private set; }

  public UserLogic()
  {
    Users = new List<User>();
  }

  public void CreateUser(string username, string password)
  {
    if (Users.Any(u => u.Username == username))
    {
      throw new ArgumentException("Username already exists");
    }
    User newUser = new User(username, password);
    Users.Add(new User(username, password));
  }




}
