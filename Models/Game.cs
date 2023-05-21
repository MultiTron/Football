using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public ValueTuple<Referee, Referee> Assistants { get; set; }
        public List<Goal> Goals { get; set; }
        public Team Winner { get; private set; }
    }
}
