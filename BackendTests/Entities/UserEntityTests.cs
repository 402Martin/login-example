using Backend.Entities;

namespace BackendTests;

[TestClass]
public class UserEntityTests
{

  [TestMethod]
  public void UserConstructorTest()
  {
    var username = "user";
    var password = "password";

    User user = new User(username, password);
  }
}
