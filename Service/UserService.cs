public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User AddUser(User user)
    {   
        var FindedUser=_userRepository.GetByUserName(user.Username);
        if(FindedUser==null){
            if(FindedUser.Username.Length<=50){
             return _userRepository.AddUser(user);
            }
        }
        throw new MethodAccessException("Bu Username daha önceden kayitlidir");

    }

    public void DeleteUser(User user)
    {
        var DeletedUser=_userRepository.GetByUserName(user.Username);
        if(DeletedUser!=null){
            _userRepository.DeleteUser(user);
        }
        throw new MethodAccessException("Boyle Bir Kullanici Yoktur");
    }

    public User FindAccountByEmailAndPassword(LoginDTO loginDTO)
    {
        return _userRepository.FindAccountByEmailAndPassword(loginDTO);
    }

    public User findAccountById(int id)
    {
        return _userRepository.findAccountById(id);
    }

    public List<User> GetAll()
    {
        return _userRepository.GetAll();
    }

    public User GetByUserName(string userName)
    {
        return _userRepository.GetByUserName(userName);
    }

    public User UpdateUser(User user)
    {
        return _userRepository.UpdateUser(user);
    }
}