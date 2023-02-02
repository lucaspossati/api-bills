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

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public decimal Salary { get; set; }

        public decimal SalarySave { get; set; }

        public ETypeRole Role { get; set; }
    }
}