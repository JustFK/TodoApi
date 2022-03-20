public interface ILoginService
{    LoginResponseDTO Authenticate(LoginDTO model);
    User findAccountById(int id);
}