﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
     public  class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
