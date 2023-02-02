using API.Domain.Models;
using api.Domain.VM.Shared;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Domain.VM;

namespace Application.VM
{
    public class SpentInMonthVM : BaseViewModel
    {
        public Guid Id { get; set; }
        public Guid IdMonth { get; set; }
        public MonthVM? Month { get; set; }
        public Guid IdUser { get; set; }
        public UserVM? User { get; set; }
        public decimal Spent { get; set; }
        public decimal SpendPercentageAbove { get; set; }
    }
}
