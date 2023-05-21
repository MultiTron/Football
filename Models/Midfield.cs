﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Midfield : FootballPlayer
    {
        public Midfield(string name, int age, int number, double height) : base(name, age, number, height)
        {
        }

        public override string Name { get; set; }
        public override int Age { get; set ; }
        public override int Number { get ; set ; }
        public override double Height { get ; set ; }
    }
}