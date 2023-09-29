using Backend.BuisnessLogic;
using Backend.Entities;

namespace BackendTests;


[TestClass]
public class UserLogicTests
{
  [TestMethod]
  public void UserLogicConstructorTest()
  {
    var userLogic = new UserLogic();

    Assert.IsNotNull(userLogic.Users);
  }

  [TestMethod]
  public void CreateUser()
  {
    string username = "test";
    string password = "test";

    UserLogic userLogic = new UserLogic();
    userLogic.CreateUser(username, password);

    Assert.AreEqual(1, userLogic.Users.Count);

  }
}
