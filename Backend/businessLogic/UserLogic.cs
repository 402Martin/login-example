namespace Backend.BuisnessLogic;

using Backend.Entities;

public class UserLogic
{
  public List<User> Users { get; private set; }

  public UserLogic()
  {
    Users = new List<User>();
  }



}
