namespace Backend.Dto;

public struct Credentials
{
  public readonly string Username { get; }
  public readonly string Id { get; }

  public Credentials(string username, string id)
  {
    this.Username = username;
    this.Id = id;
  }
}


public class UserIn
{
  public string? Username { get; set; }
  public string? Password { get; set; }

  public UserIn()
  { }
}
