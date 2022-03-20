public interface IUserService{
User AddUser(User user);
User UpdateUser(User user);
void DeleteUser(User user);
List<User> GetAll();
User GetByUserName(string userName);
User FindAccountByEmailAndPassword(LoginDTO loginDTO); 
User findAccountById(int id);





}
