using Moq;
using System.Runtime.InteropServices;

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
        long userId = 1;
        User user = null;
        _userRepositoryMock.Setup(x => x.findById(userId)).Returns(user);

        _userService = new UserService(_userRepositoryMock.Object);

        // Act
        string result = _userService.GetUserName(userId);

        // Assert
        Assert.Equal("User not found", result);

    }

    [Fact]
    public void TestCreateNewUserValidUser()
    {
        // Arrange
        User newUser = new User(null, "John Doe", "1234567890", Role.USER);
        User userNull = null;
        _userRepositoryMock.Setup(x => x.findByPhoneNumber(newUser.phoneNumber)).Returns(userNull);

        _userService = new UserService(_userRepositoryMock.Object);

        // Act
        _userService.CreateNewUser(newUser);

        // Assert
        _userRepositoryMock.Verify(x => x.save(newUser), Times.Once());
    }

    [Fact]
    public void TestCreateNewUserMissingInfo()
    {
        // Arrange
        User invalidUser = new User(null, null, null, null);

        _userService = new UserService(_userRepositoryMock.Object);

        // Act & Assert
        UserInvalidInfoException thrown = Assert.Throws<UserInvalidInfoException>(() => _userService.CreateNewUser(invalidUser));

        Assert.Equal("User information is missing", thrown.Message);
    }

[Fact]
    public void TestCreateNewUserPhoneNumberExists()
    {
        // Arrange
        User existingUser = new User(null, "Jane Doe", "1234567890", Role.USER);
        User newUserWithExistingPhone = new User(null, "John Smith", "1234567890", Role.USER); // Same phone number
        _userRepositoryMock.Setup(x => x.findByPhoneNumber("1234567890")).Returns(existingUser);

        _userService = new UserService(_userRepositoryMock.Object);

        // Act & Assert
        PhoneNumberExistsException thrown = Assert.Throws<PhoneNumberExistsException>(() => _userService.CreateNewUser(newUserWithExistingPhone));

        Assert.Equal("This phone number is already in use", thrown.Message);
    }

    [Fact]
    public void TestDeleteUserUserDoesNotExist()
    {
        // Arrange
        long userId = 1;
        User userNull = null;
        _userRepositoryMock.Setup(x => x.findById(userId)).Returns(userNull);

        _userService = new UserService(_userRepositoryMock.Object);

        // Act
        _userService.DeleteUser(userId);

        // Assert
        _userRepositoryMock.Verify(x => x.deleteUser(userId), Times.Never()); // Ensure deleteUser is never called

    }

    [Fact]
    public void TestDeleteUserAdminUser()
    {
        // Arrange
        long adminUserId = 2;
        User adminUser = new User(adminUserId, "Admin User", "admin@example.com", Role.ADMIN);
        _userRepositoryMock.Setup(x => x.findById(adminUserId)).Returns(adminUser);

        _userService = new UserService(_userRepositoryMock.Object);

        // Act & Assert
        NotAllowedException thrown = Assert.Throws<NotAllowedException>(() => _userService.DeleteUser(adminUserId));

        Assert.Equal("You cannot delete an admin user", thrown.Message);
        _userRepositoryMock.Verify(x => x.deleteUser(adminUserId), Times.Never()); // Ensure deleteUser is never called

    }

    [Fact]
    public void TestDeleteUserRegularUser()
    {
        // Arrange
        long userId = 3;
        User regularUser = new User(userId, "Regular User", "user@example.com", Role.USER);
        _userRepositoryMock.Setup(x => x.findById(userId)).Returns(regularUser);

        _userService = new UserService(_userRepositoryMock.Object);

        // Act
        _userService.DeleteUser(userId);

        // Assert
        _userRepositoryMock.Verify(x => x.deleteUser(userId), Times.Once()); // Ensure deleteUser is called
    }

}
