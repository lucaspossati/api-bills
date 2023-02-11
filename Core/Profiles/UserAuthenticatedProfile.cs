using API.Domain.Models;
using API.Domain.VM;
using Application.Models;
using Application.VM;
using AutoMapper;
using Data.Migrations;
using Manager.Models;
using Manager.VM;

namespace api.Profiles
{
    public class UserAuthenticatedProfile : Profile
    {
        public UserAuthenticatedProfile()
        {
            CreateMap<UserAuthenticatedVM, UserAuthenticated>();

            CreateMap<UserAuthenticated, UserAuthenticatedVM>()
                .ForMember(u => u.User, opt => opt.MapFrom(sp => sp.User));

            
        }
    }
}
