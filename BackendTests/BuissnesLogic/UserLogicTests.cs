using Backend.BuisnessLogic;
using Backend.Entities;

namespace BackendTests;


[TestClass]
public class UserLogicTests
{

  [TestMethod]
  public void CreateUser()
  {
    string username = "test";
    string password = "test";

    UserLogic userLogic = new UserLogic();
    User returnedUser = userLogic.CreateUser(username, password);

    Assert.AreEqual(returnedUser.Username, username);
  }

  [TestMethod]
  [ExpectedException(typeof(ArgumentException))]
  public void CreateUserDontAllowReaptedUsername()
  {
    string username = "test";
    string password = "test";

    UserLogic userLogic = new UserLogic();
    userLogic.CreateUser(username, password);
    userLogic.CreateUser(username, password);
  }

  [TestMethod]
  public void GetUserByUsername()
  {
    string username = "test";
    string password = "test";

    UserLogic userLogic = new UserLogic();
    userLogic.CreateUser(username, password);
    User returnedUser = userLogic.GetUserByUsername(username);

    Assert.AreEqual(returnedUser.Username, username);
  }

}
