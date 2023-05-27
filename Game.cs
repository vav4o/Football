using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Game
    {
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public Referee Referee { get; private set; }
        public Referee Assistant1 { get; private set; }
        public Referee Assistant2 { get; private set; }
        public List<Tuple<int, FootballPlayer>> Goals = new List<Tuple<int, FootballPlayer>>();
        public int Team1Score = 0;
        public int Team2Score = 0;
        public Game(Team t1, Team t2, Referee r, Referee a1, Referee a2)
        {
            if (t1.Players.Length != 11 || t2.Players.Length != 11)
            {
                throw new ArgumentException("Team size must be of exactly 11 players!");
            }
            Team1 = t1;
            Team2 = t2;
            Referee = r;
            Assistant1 = a1;
            Assistant2 = a2;
        }
        public void AddGoal(int time, FootballPlayer player)
        {
            if (Team1.Contains(player))
            {
                Team1Score++;
            }
            else if (Team2.Contains(player))
            {
                Team2Score++;
            }
            else
            {
                Console.WriteLine("This player is not in the game!");
                return;
            }
            Goals.Add(Tuple.Create(time, player));
        }
        public void GameResult()
        {
            Console.WriteLine($"Team1 {Team1Score}:{Team2Score} Team2");
        }
        public void Winner()
        {
            if (Team1Score > Team2Score) Console.WriteLine("Team1 wins!");
            else if(Team2Score > Team1Score) Console.WriteLine("Team2 wins!");
            else Console.WriteLine("Draw!");
        }
    }
}
