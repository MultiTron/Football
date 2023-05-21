﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Coach : Person
    {
        public Coach(string name, int age) : base(name, age)
        {
        }

        public override string Name { get ; set; }
        public override int Age { get ; set ; }
    }
}
