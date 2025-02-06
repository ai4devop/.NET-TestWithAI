public interface IUserRepository {
  User findById(long id);

  User findByPhoneNumber(string phoneNumber);

  void save(User user);

  void deleteUser(long id);
}
