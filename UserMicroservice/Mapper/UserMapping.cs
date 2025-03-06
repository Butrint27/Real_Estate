using AutoMapper;
using UserMicroservice.DTO;
using UserMicroservice.Model;

namespace UserMicroservice.Mapper
{
    public class UserMapping : Profile
    {
        public UserMapping() 
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, RegisterUserDTO>().ReverseMap();
            CreateMap<User, LoginDTO>().ReverseMap();
        }
    }
}
