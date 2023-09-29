namespace FrontEnd.Data;
using Backend.BuisnessLogic;
using Backend.Dto;


public class UserController
{
    private UserLogic UserLogic { get; set; }

    public UserController()
    {
        this.UserLogic = new UserLogic();
    }

    public void CreateUser(string username, string password)
    {
        this.UserLogic.CreateUser(username, password);
    }

    public void Login(UserIn userIn)
    {
        if (string.IsNullOrEmpty(userIn.Username) || string.IsNullOrEmpty(userIn.Password))
        {
            throw new ArgumentException("Username or password is empty");
        }

        this.UserLogic.Login(userIn.Username, userIn.Password);
    }
}
