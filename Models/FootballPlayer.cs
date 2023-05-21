using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class FootballPlayer : Person
    {
        public abstract override string Name { get; set; }
        public abstract override int Age { get; set; }
        public abstract int Number { get; set; }
        public abstract double Height { get; set; }
        public FootballPlayer(string name, int age, int number, double height)
            :base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
