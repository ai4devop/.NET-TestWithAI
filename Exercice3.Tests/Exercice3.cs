using Moq;

public class UserServiceTest
{
    private Mock<IUserRepository> _userRepositoryMock;
    private UserService _userService;

    public UserServiceTest()
    {
        _userRepositoryMock = new Mock<IUserRepository>();
    }

    [Fact]
    public void TestGetUserNameUserExists()
    {
        long userId = 1;
        User user = new User(userId, "John Doe", "0606060606", Role.USER);
        _userRepositoryMock.Setup(x => x.findById(userId)).Returns(user);

        _userService = new UserService(_userRepositoryMock.Object);

        // Act
        string result = _userService.GetUserName(userId);

        // Assert
        Assert.Equal("John Doe", result);
    }

    [Fact]
    public void TestGetUserNameButUserDoesNotExist()
    {
        // TODO
        // The user doesn't exists something should be tested with the method userService.getUserName
    }

    [Fact]
    public void TestCreateNewUserValidUser()
    {
        // TODO
        // The user is valid and something should be tested with the method userService.createNewUser

    }

    [Fact]
    public void TestCreateNewUserMissingInfo()
    {
        // TODO
        // User is incomplete and something should be tested with the method userService.createNewUser

    }

    [Fact]
    public void TestCreateNewUserPhoneNumberExists()
    {
        // TODO
        // A user with the same phone number exists and something should be tested with the method userService.createNewUser
    }

    [Fact]
    public void TestDeleteUserUserDoesNotExist()
    {
        // TODO
        // The user doesn't exists and something should be tested with the method userService.deleteUser
    }

    [Fact]
    public void TestDeleteUserAdminUser()
    {
        // TODO
        // The calling user is an administrator and something should be tested with the method userService.deleteUser
    }

    [Fact]
    public void TestDeleteUserRegularUser()
    {
        // TODO
        // The calling user is a regular user and something should be tested with the method userService.deleteUser
    }

}
