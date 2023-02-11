using api.Domain.VM.Shared;
using API.Domain.Models;
using API.ValueObjects;
using System;

namespace API.Domain.VM{
    public class UserAuthenticatedVM
    {
        public string Token { get; set; }

        public UserVM User { get; set; }
    }
}