using API.ValueObjects;
using Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Domain.Models{
    public class User
    {
        public Guid? Id { get; set; }

        public string? FullName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public decimal Salary { get; set; }

        public decimal SalarySave { get; set; }

        public string? Token { get; set; }

        public DateTime? TokenExpirationDate { get; set; }

        public bool Active { get; set; }

        public ETypeRole Role { get; set; }

        public ICollection<SpentInMonth>? SpentInMonth { get; set; }

        public ICollection<Bill>? Bills { get; set; }
    }
}