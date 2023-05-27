using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Team
    {
        public Coach Coach {  get; private set; }
        public FootballPlayer[] Players { get; private set; }
        public Team(Coach coach, params FootballPlayer[] players)
        {
            if (players.Length < 11 || players.Length > 22)
            {
                throw new ArgumentException("Team size must be between 11 and 22 players!");
            }
            Coach = coach;
            Players = players;
        }
        public double AverageAge()
        {
            double total = 0;
            foreach (var player in Players) 
            {
                total += player.Age;
            }
            return total / Players.Length;
        }
        //Check if a player is in the team
        public bool Contains(FootballPlayer p)
        {
           bool contains = false;
            foreach (var player in Players) 
            {
                if (player == p) contains = true;
            }
            return contains;
        }
    }
}
