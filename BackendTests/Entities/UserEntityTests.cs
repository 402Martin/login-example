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

    Assert.AreEqual(username, user.Username);
    Assert.AreEqual(password, user.Password);
  }

  [TestMethod]
  public void autoAssignIdTest()
  {
    var username = "user";
    var password = "password";

    User user = new User(username, password);

    Assert.AreNotEqual(Guid.Empty, user.Id);
  }
}
