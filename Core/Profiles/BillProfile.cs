using API.Domain.Models;
using API.Domain.VM;
using Application.Models;
using AutoMapper;
using Manager.VM;

namespace api.Profiles
{
    public class BillProfile : Profile
    {
        public BillProfile()
        {
            CreateMap<BillVM, Bill>();

            CreateMap<Bill, BillVM>();
        }
    }
}
