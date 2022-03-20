
public class UserRepository :IUserRepository
{    
    private readonly DbContextBase _context;

    public UserRepository(DbContextBase context)
    {
        _context = context;
    }

    public User AddUser(User user)
    {
        _context.Add(user);
        _context.SaveChanges();
        return user;
    }

    public void DeleteUser(User user)
    {
        
        _context.Remove(user);
        _context.SaveChanges();
    }
    
    public  User FindAccountByEmailAndPassword(LoginDTO loginDTO)
    {
         User accountFinded = (from x in _context.Users
                           where x.Email == loginDTO.Email && x.Password == loginDTO.Password
                           select x).FirstOrDefault();
        return accountFinded;
    }



 public  User findAccountById(int id)
    {
         User accountByID = (from x in _context.Users
                           where x.Id == id
                           select x).FirstOrDefault();
        return accountByID;
    }

    public List<User> GetAll()
    {
        return _context.Users.ToList();
        
    }

    public User GetByUserName(string userName)
    {
        var FindedUser = _context.Users.FirstOrDefault(u=>u.Username==userName);
        return FindedUser;
    }

    public User UpdateUser(User user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();
        return user;
    }
}