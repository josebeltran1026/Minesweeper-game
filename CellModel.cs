namespace MinesweeperLibrary.Models
{
    
    public class CellModel
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public bool IsVisited { get; set; }

        public bool IsBomb { get; set; }

        public bool IsFlagged { get; set; }

        public int NumberOfBombNeighbors { get; set; }

        public bool HasSpecialReward { get; set; }

        public CellModel()
        {
            Row = -1;
            Column = -1;
            IsVisited = false;
            IsBomb = false;
            IsFlagged = false;
            NumberOfBombNeighbors = 0;
            HasSpecialReward = false;
        }

        public CellModel(int row, int column)
        {
            Row = row;
            Column = column;
            IsVisited = false;
            IsBomb = false;
            IsFlagged = false;
            NumberOfBombNeighbors = 0;
            HasSpecialReward = false;
        }
    }
}