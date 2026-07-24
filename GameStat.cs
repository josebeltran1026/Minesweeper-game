namespace MinesweeperLibrary.Models
{
   
    public class GameStat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Score { get; set; }

        public DateTime GameTime { get; set; }

        public GameStat()
        {
            Name = string.Empty;
            GameTime = DateTime.Now;
        }

        public GameStat(
            int id,
            string name,
            int score,
            DateTime gameTime)
        {
            Id = id;
            Name = name;
            Score = score;
            GameTime = gameTime;
        }
    }
}
