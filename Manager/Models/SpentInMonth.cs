using API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class SpentInMonth
    {
        public Guid Id { get; set; }
        public Guid MonthId { get; set; }
        public Month? Month { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public decimal Spent { get; set; }
        public decimal SpendPercentageAbove { get; set; }
    }
}
