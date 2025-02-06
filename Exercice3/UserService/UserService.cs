public class UserService (IUserRepository _userRepository) {

  public string GetUserName(long id) {
    User user = _userRepository.findById(id);
    return user != null ? user.name : "User not found";
  }

  public void CreateNewUser(User user) {
    if (string.IsNullOrWhiteSpace(user.name) || string.IsNullOrWhiteSpace(user.phoneNumber) || user.role == null) {
      throw new UserInvalidInfoException("User information is missing");
    }

    User userWithPhoneNumber = _userRepository.findByPhoneNumber(user.phoneNumber);
    if (userWithPhoneNumber != null) {
      throw new PhoneNumberExistsException("This phone number is already in use");
    }
    
    _userRepository.save(user);
  }

  public void DeleteUser(long id) {
        User user = _userRepository.findById(id);
        if (user == null)
        {
            return;
        }
        if (user.role == Role.ADMIN)
        {
            throw new NotAllowedException("You cannot delete an admin user");
        }
        _userRepository.deleteUser(id);
    }

}
