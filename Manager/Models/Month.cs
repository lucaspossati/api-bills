using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class Month
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int? Ordination { get; set; }
        public ICollection<SpentInMonth>? SpentInMonth { get; set; }
        public ICollection<Bill>? Bills { get; set; }
    }
}
