﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyMe.Core.Entities
{
    public class Customer
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
