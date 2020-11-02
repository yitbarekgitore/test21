﻿using Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullTimeEmployee
{
    class FullTimeEmployees : BaseEmployee
    {
        public double AnualSalary { get; set; }
        public override double GetSalary()
        {
            return AnualSalary / 12;
        }
    }
}