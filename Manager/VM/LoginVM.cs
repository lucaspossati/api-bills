using api.Domain.VM.Shared;
using API.Domain.Models;
using API.ValueObjects;
using System;

namespace API.Domain.VM{
    public class LoginVM
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}