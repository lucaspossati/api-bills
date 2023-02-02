﻿using API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Interface
{
    public interface IJWTService
    {
        string GenerateToken(User user);
    }
}
