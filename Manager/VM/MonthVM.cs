using Application.Models;
using Manager.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.VM
{
    public class MonthVM
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public int? Order { get; set; }
        public ICollection<SpentInMonthVM>? SpentInMonths { get; set; }
        public ICollection<BillVM>? Bills { get; set; }
    }
}
