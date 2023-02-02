using api.Domain.VM.Shared;
using API.ValueObjects;
using Application.Models;
using Application.VM;
using Manager.VM;
using System;

namespace API.Domain.VM{
    public class UserVM : BaseViewModel
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public decimal Salary { get; set; }

        public decimal SalarySave { get; set; }

        public ETypeRole Role { get; set; }

        public string? RoleName { get; set; }

        public ICollection<SpentInMonthVM>? SpentInMonth { get; set; }
        public ICollection<BillVM>? Bills { get; set; }
    }
}