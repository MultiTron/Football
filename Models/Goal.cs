using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Goal
    {
        public Goal(int minute, FootballPlayer player)
        {
            Minute = minute;
            Player = player;
        }

        public int Minute { get; set; }
        public FootballPlayer Player { get; set; }
        
    }
}
