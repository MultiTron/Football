using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Game
    {
        public Game(Team team1, Team team2, Referee referee, (Referee, Referee) assistants)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            Assistants = assistants;
            Goals = new List<Goal>();
            MatchPlayed = false;
        }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public ValueTuple<Referee, Referee> Assistants { get; set; }
        public List<Goal> Goals { get; private set; }
        public Team Winner { get; private set; }
        private bool MatchPlayed { get; set; }
        public void Play()
        {
            Winner = null;
            int turn;
            int player;
            int minute = 1;
            do
            {
                turn = Random.Shared.Next(101);
                player = Random.Shared.Next(1, 11);
                minute = Random.Shared.Next(minute, 92);
                
                if (turn <= 50)
                {
                    Goals.Add(Team1[player].Score(minute));
                }
                else
                {
                    Goals.Add(Team2[player].Score(minute));
                }
            } while (minute < 91);

            MatchPlayed = true;
            DecideWinner();
        }
        private void DecideWinner()
        {
            int score1 = 0;
            int score2 = 0;
            foreach (Goal goal in Goals)
            {
                if (Team1.Contains(goal.Player))
                {
                    score1++;
                }
                else if(Team2.Contains(goal.Player))
                {
                    score2++;
                }
            }
            if (score1 != score2)
            {
                Winner = score1 > score2 ? Team1 : Team2;
            }
        }
        public override string ToString()
        {
            if (!MatchPlayed)
            {
                return "Match hasn't been played yet.";
            }
            if (Winner == null)
            {
                return "Match is tied.";
            }
            return $"Team {Winner.Name} won the match";
        }
    }
}
