using System;

namespace MinesweeperLibrary.Models
{
    
    public class BoardModel
    {
        public int Size { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public CellModel[,] Cells { get; set; }

        public double Difficulty { get; set; }

        public int RewardsRemaining { get; set; }

        public GameState GameState { get; set; }

        public int Score { get; set; }

        public BoardModel(int size)
        {
            Size = size;

            StartTime = DateTime.Now;

            EndTime = DateTime.MinValue;

            Difficulty = 0.15;

            RewardsRemaining = 0;

            Score = 0;

            GameState = GameState.StillPlaying;

            Cells = new CellModel[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Cells[row, col] = new CellModel(row, col);
                }
            }
        }
    }
}
