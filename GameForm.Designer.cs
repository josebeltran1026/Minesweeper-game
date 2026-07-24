namespace MinesweeperGUI
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlBoard = new Panel();
            lblTimeTitle = new Label();
            lblTime = new Label();
            lblScoreTitle = new Label();
            lblScore = new Label();
            lblStatus = new Label();
            btnRestart = new Button();
            btnReturn = new Button();
            btnHighScores = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // pnlBoard
            // 
            pnlBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBoard.AutoScroll = true;
            pnlBoard.Location = new Point(20, 20);
            pnlBoard.Name = "pnlBoard";
            pnlBoard.Size = new Size(700, 650);
            pnlBoard.TabIndex = 0;
            // 
            // lblTimeTitle
            // 
            lblTimeTitle.AutoSize = true;
            lblTimeTitle.Location = new Point(771, 30);
            lblTimeTitle.Name = "lblTimeTitle";
            lblTimeTitle.Size = new Size(42, 20);
            lblTimeTitle.TabIndex = 1;
            lblTimeTitle.Text = "Time";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(838, 30);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(44, 20);
            lblTime.TabIndex = 2;
            lblTime.Text = "00:00";
            // 
            // lblScoreTitle
            // 
            lblScoreTitle.AutoSize = true;
            lblScoreTitle.Location = new Point(771, 82);
            lblScoreTitle.Name = "lblScoreTitle";
            lblScoreTitle.Size = new Size(46, 20);
            lblScoreTitle.TabIndex = 3;
            lblScoreTitle.Text = "Score";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(851, 82);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(17, 20);
            lblScore.TabIndex = 4;
            lblScore.Text = "0";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(784, 147);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(120, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Game inProgress";
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(786, 257);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(94, 29);
            btnRestart.TabIndex = 6;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(784, 322);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(130, 29);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return to Menu";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnHighScores
            // 
            btnHighScores.Location = new Point(784, 390);
            btnHighScores.Name = "btnHighScores";
            btnHighScores.Size = new Size(120, 29);
            btnHighScores.TabIndex = 8;
            btnHighScores.Text = "High Scores";
            btnHighScores.UseVisualStyleBackColor = true;
            btnHighScores.Click += btnHighScores_Click;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 703);
            Controls.Add(btnHighScores);
            Controls.Add(btnReturn);
            Controls.Add(btnRestart);
            Controls.Add(lblStatus);
            Controls.Add(lblScore);
            Controls.Add(lblScoreTitle);
            Controls.Add(lblTime);
            Controls.Add(lblTimeTitle);
            Controls.Add(pnlBoard);
            MinimumSize = new Size(800, 600);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minesweeper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBoard;
        private Label lblTimeTitle;
        private Label lblTime;
        private Label lblScoreTitle;
        private Label lblScore;
        private Label lblStatus;
        private Button btnRestart;
        private Button btnReturn;
        private Button btnHighScores;
        private System.Windows.Forms.Timer gameTimer;
    }
}