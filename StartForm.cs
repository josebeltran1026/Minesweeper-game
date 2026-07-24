namespace MinesweeperGUI
{
    /// <summary>
    /// Allows the player to configure and start a new game.
    /// </summary>
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            cmbDifficulty.SelectedIndex = 0;
            UpdateSelectionLabels();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            UpdateSelectionLabels();
        }

        private void trkBoardSize_Scroll(object sender, EventArgs e)
        {
            UpdateSelectionLabels();
        }

        private void cmbDifficulty_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdateSelectionLabels();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int boardSize = trkBoardSize.Value;
            double difficulty = GetSelectedDifficulty();

            GameForm gameForm = new(boardSize, difficulty);

            Hide();
            gameForm.ShowDialog();
            Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Minesweeper",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private double GetSelectedDifficulty()
        {
            return cmbDifficulty.SelectedIndex switch
            {
                0 => 0.10,
                1 => 0.15,
                2 => 0.20,
                _ => 0.10
            };
        }

        private void UpdateSelectionLabels()
        {
            lblBoardSize.Text =
                $"Board Size: {trkBoardSize.Value} x {trkBoardSize.Value}";

            string difficultyText =
                cmbDifficulty.SelectedIndex switch
                {
                    0 => "Easy (10%)",
                    1 => "Medium (15%)",
                    2 => "Hard (20%)",
                    _ => "Easy (10%)"
                };

            lblDifficulty.Text = $"Difficulty: {difficultyText}";
        }
    }
}