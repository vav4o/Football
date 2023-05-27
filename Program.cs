namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coach coach = new Coach("a", 5);
            FootballPlayer a1 = new FootballPlayer("g", 40, 2, 4);
            FootballPlayer a2 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a3 = new FootballPlayer("g", 24, 2, 4);
            FootballPlayer a4 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a5 = new FootballPlayer("g", 34, 2, 4);
            FootballPlayer a6 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a7 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a8 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a9 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a10 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a11 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a12 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a13 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a14 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a15 = new FootballPlayer("g", 44, 2, 4);
            FootballPlayer a16 = new FootballPlayer("g", 44, 2, 4);
            Referee r = new Referee("d", 54);
            Team team = new Team(coach, a1, a2, a3, a4, a5, a6, a7, a8, a1, a2, a3);
            Game game = new Game(team, team, r, r, r);
            game.AddGoal(5, a5);
            game.GameResult();
            game.Winner();
            int dgdsgd = 5;
        }
    }
}