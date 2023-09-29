using Backend.BuisnessLogic;

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
}
