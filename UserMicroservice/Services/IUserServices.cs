using UserMicroservice.DTO;
using UserMicroservice.Model;

namespace UserMicroservice.Services
{
    public interface IUserServices
    {
        Task<UserDTO> RegisterUser(RegisterUserDTO registerUserDTO);
        Task<string> LoginUser(LoginDTO loginDTO);
        Task<string> GenerateAccessToken(User user);
        Task<string> GenerateRefreshToken();
    }

}
