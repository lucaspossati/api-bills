using API.Domain.Models;
using API.Domain.VM;
using AutoMapper;

namespace api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserVM, User>();

            CreateMap<User, UserVM>()
                .ForMember(nvm => nvm.RoleName, options => options.MapFrom(n => n.Role.ToString()));

            CreateMap<User, UserVM>();
        }
    }
}
