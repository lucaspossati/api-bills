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

            CreateMap<SpentInMonth, SpentInMonthVM>();
        }
    }
}
