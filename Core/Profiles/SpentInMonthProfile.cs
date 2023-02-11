using API.Domain.Models;
using Application.Models;
using Application.VM;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Profiles
{
    public class SpentInMonthProfile : Profile
    {
        public SpentInMonthProfile()
        {
            CreateMap<SpentInMonthVM, SpentInMonth>();

            CreateMap<SpentInMonth, SpentInMonthVM>()
                .ForMember(nvm => nvm.User, options => options.Ignore())
                .ForMember(nvm => nvm.Month, options => options.MapFrom(sp => sp.Month));
        }
    }
}
