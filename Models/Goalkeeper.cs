using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Goalkeeper : FootballPlayer
    {
        public Goalkeeper(string name, int age, int number, double height) : base(name, age, number, height)
        {
        }

        public override int Number { get; set; }
        public override double Height { get; set; }
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override Goal Score(int minute)
        {
            return base.Score(minute);
        }
    }
}
