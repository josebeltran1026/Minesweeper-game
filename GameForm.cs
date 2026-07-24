using MinesweeperLibrary.BusinessLogicLayer;
using MinesweeperLibrary.Models;

namespace MinesweeperGUI
{
  
    public partial class GameForm : Form
    {
        private readonly int boardSize;
        private readonly double difficulty;
        private readonly IBoardService boardService;

        private BoardModel board;
        private Button[,] cellButtons;
        private int elapsedSeconds;
        private bool gameHasEnded;

        public GameForm(int boardSize, double difficulty)
        {
            InitializeComponent();

            this.boardSize = boardSize;
            this.difficulty = difficulty;

            boardService = new BoardService();
            board = new BoardModel(boardSize);
            cellButtons = new Button[boardSize, boardSize];

            StartNewGame();
        }

        private void StartNewGame()
        {
            pnlBoard.Controls.Clear();

            board = new BoardModel(boardSize)
            {
                Difficulty = difficulty,
                StartTime = DateTime.Now,
                GameState = GameState.StillPlaying
            };

            cellButtons = new Button[boardSize, boardSize];
            elapsedSeconds = 0;
            gameHasEnded = false;

            lblTime.Text = "00:00";
            lblScore.Text = "0";
            lblStatus.Text = "Game in progress";

            boardService.SetupBombs(board);
            boardService.CountBombsNearby(board);

            CreateBoardButtons();

            gameTimer.Start();
        }

        private void CreateBoardButtons()
        {
            const int buttonSize = 42;

            for (int row = 0; row < boardSize; row++)
            {
                for (int column = 0; column < boardSize; column++)
                {
                    Button button = new()
                    {
                        Width = buttonSize,
                        Height = buttonSize,
                        Left = column * buttonSize,
                        Top = row * buttonSize,
                        Tag = new Point(row, column),
                        Text = string.Empty,
                        BackColor = SystemColors.ControlDark,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font(
                            "Segoe UI",
                            10,
                            FontStyle.Bold)
                    };

                    button.MouseUp += CellButton_MouseUp;

                    cellButtons[row, column] = button;
                    pnlBoard.Controls.Add(button);
                }
            }
        }

        private void CellButton_MouseUp(
            object? sender,
            MouseEventArgs e)
        {
            if (gameHasEnded || sender is not Button button)
            {
                return;
            }

            if (button.Tag is not Point position)
            {
                return;
            }
            int row = position.X;
            int column = position.Y;

            if (e.Button == MouseButtons.Right)
            {
                boardService.ToggleFlag(board, row, column);
            }
            else if (e.Button == MouseButtons.Left)
            {
                boardService.VisitCell(board, row, column);
            }

            RefreshBoard();
            CheckGameState();
        }

        private void RefreshBoard()
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int column = 0; column < boardSize; column++)
                {
                    CellModel cell = board.Cells[row, column];
                    Button button = cellButtons[row, column];

                    if (cell.IsFlagged && !cell.IsVisited)
                    {
                        button.Text = "F";
                        button.BackColor = Color.LightSkyBlue;
                        continue;
                    }

                    if (!cell.IsVisited)
                    {
                        button.Text = string.Empty;
                        button.BackColor = SystemColors.ControlDark;
                        continue;
                    }

                    button.Enabled = false;
                    button.BackColor = Color.White;

                    if (cell.IsBomb)
                    {
                        button.Text = "B";
                        button.BackColor = Color.IndianRed;
                    }
                    else if (cell.NumberOfBombNeighbors == 0)
                    {
                        button.Text = string.Empty;
                    }
                    else
                    {
                        button.Text =
                            cell.NumberOfBombNeighbors.ToString();
                    }
                }
            }
        }

        private void CheckGameState()
        {
            GameState currentState =
                boardService.DetermineGameState(board);

            board.GameState = currentState;

            if (currentState == GameState.StillPlaying)
            {
                return;
            }

            gameHasEnded = true;
            gameTimer.Stop();
            board.EndTime = DateTime.Now;

            RevealBombs();

            if (currentState == GameState.Won)
            {
                board.Score =
                    boardService.DetermineFinalScore(board);

                lblScore.Text = board.Score.ToString();
                lblStatus.Text = "You won!";

                MessageBox.Show(
                    $"Congratulations! You won.\nScore: {board.Score}",
                    "Victory",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                lblStatus.Text = "You hit a bomb.";

                MessageBox.Show(
                    "You hit a bomb. Game over.",
                    "Game Over",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void RevealBombs()
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int column = 0; column < boardSize; column++)
                {
                    if (board.Cells[row, column].IsBomb)
                    {
                        Button button = cellButtons[row, column];
                        button.Text = "B";
                        button.BackColor = Color.IndianRed;
                    }
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;

            TimeSpan elapsed = TimeSpan.FromSeconds(elapsedSeconds);

            lblTime.Text = elapsed.ToString(@"mm\:ss");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            StartNewGame();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            Close();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "The high-score screen will be added next.",
                "High Scores",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}