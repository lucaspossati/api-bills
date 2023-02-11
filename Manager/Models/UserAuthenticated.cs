using API.Domain.Models;
using API.Domain.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{
    public class UserAuthenticated
    {
        public string Token { get; set; }

        public User User { get; set; }
    }
}
