﻿using SchoolManagementSystem.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Common
{
    public class UserLoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}