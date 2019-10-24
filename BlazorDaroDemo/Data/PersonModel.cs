﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDaroDemo.Data
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AccountBalance { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
