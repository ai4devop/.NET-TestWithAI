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
    // TODO
    // If the user doesn't exists, this method does nothing
    // If the user exists but doesn't have the admin role, it throws NotAllowedException
    // Else it delete the user
  }

}
