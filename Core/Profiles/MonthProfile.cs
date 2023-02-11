using API.Domain.Models;
using API.Domain.VM;
using Application.Models;
using Application.VM;
using AutoMapper;
using Manager.VM;

namespace api.Profiles
{
    public class MonthProfile : Profile
    {
        public MonthProfile()
        {
            CreateMap<MonthVM, Month>();

            CreateMap<Month, MonthVM>()
                .ForMember(nvm => nvm.SpentInMonths, options => options.Ignore())
                .ForMember(nvm => nvm.Bills, options => options.Ignore());
        }
    }
}
