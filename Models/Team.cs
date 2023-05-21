using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }
        public double AverageAge { get; private set; }
        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            if (players.Count < 11 && players.Count > 22)
            {
                throw new Exception("Player count must be between 11 and 22.");
            }
            Players = players;
            AverageAge = Players.Sum(x => x.Age) / Players.Count;
        }
        public void AddPlayer(FootballPlayer player)
        {
            if (Players.Count > 22)
            {
                throw new Exception("Can't have more then 22 players in a team.");
            }
            Players.Add(player);
        }
        public void RemovePlayer(FootballPlayer player)
        {
            if (Players.Count <= 11) 
            { 
                throw new Exception("Can't have less then 11 players in a team.");
            }
            Players.Remove(player);
        }
    }
}
