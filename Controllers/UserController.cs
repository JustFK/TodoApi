using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    
    [HttpGet("getall")]

    public List<User> GetAll()
    { 
        return _userService.GetAll();
    }

    [HttpPost("add")]

    public async Task<User> AddUser(User user){
        return  _userService.AddUser(user);
    }

    [HttpDelete("delete")]

    public async Task Delete(User user){
         _userService.DeleteUser(user);
    }
    [HttpPut("Update")]
    public async Task<User> UpdateUser(User user){
        return _userService.UpdateUser(user);
    }
    [HttpGet("get")]
    
    public async Task<User> GetByUserName(string userName){
        return _userService.GetByUserName(userName);
    }
    [HttpGet("getbyemail")]
    public async Task<User> FindAccountByEmailAndPassword(LoginDTO loginDTO){
        return _userService.FindAccountByEmailAndPassword(loginDTO);
    }
    
}


