using API.Domain.Models;
using API.Domain.VM;
using Application.Models;
using Application.VM;
using AutoMapper;
using Data.Migrations;
using Manager.VM;

namespace api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserVM, User>();

            CreateMap<User, UserVM>()
                .ForMember(nvm => nvm.RoleName, options => options.MapFrom(n => n.Role.ToString()))
                .ForMember(u => u.SpentInMonth, opt => opt.MapFrom(sp => sp.SpentInMonth))
                .ForMember(u => u.Bills, opt => opt.MapFrom(sp => sp.Bills));

            
        }
    }
}
