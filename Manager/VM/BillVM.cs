using api.Domain.VM.Shared;
using API.Domain.Models;
using API.Domain.VM;
using Application.Models;
using Application.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.VM
{
    public class BillVM : BaseViewModel
    {
        public Guid Id { get; set; }
        public Guid MonthId { get; set; }
        public MonthVM? Month { get; set; }
        public Guid UserId { get; set; }
        public UserVM? User { get; set; }
        public string? Name { get; set; }
        public decimal Value { get; set; }
    }
}
