namespace MinesweeperGUI
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblBoardSize = new Label();
            trkBoardSize = new TrackBar();
            lblDifficulty = new Label();
            cmbDifficulty = new ComboBox();
            btnPlay = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)trkBoardSize).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(100, -3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Minesweeper";
            // 
            // lblBoardSize
            // 
            lblBoardSize.AutoSize = true;
            lblBoardSize.Location = new Point(34, 43);
            lblBoardSize.Name = "lblBoardSize";
            lblBoardSize.Size = new Size(95, 20);
            lblBoardSize.TabIndex = 1;
            lblBoardSize.Text = "Board Size: 8";
            // 
            // trkBoardSize
            // 
            trkBoardSize.LargeChange = 1;
            trkBoardSize.Location = new Point(134, 67);
            trkBoardSize.Maximum = 15;
            trkBoardSize.Minimum = 5;
            trkBoardSize.Name = "trkBoardSize";
            trkBoardSize.Size = new Size(130, 56);
            trkBoardSize.TabIndex = 2;
            trkBoardSize.Value = 8;
            trkBoardSize.Scroll += this.trkBoardSize_Scroll;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Location = new Point(34, 114);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(147, 20);
            lblDifficulty.TabIndex = 3;
            lblDifficulty.Text = "Difficulty: Easy (10%)";
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            cmbDifficulty.Location = new Point(113, 167);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(151, 28);
            cmbDifficulty.TabIndex = 4;
            cmbDifficulty.SelectedIndexChanged += this.cmbDifficulty_SelectedIndexChanged;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(55, 256);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(120, 40);
            btnPlay.TabIndex = 5;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += this.btnPlay_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(282, 263);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 313);
            Controls.Add(btnExit);
            Controls.Add(btnPlay);
            Controls.Add(cmbDifficulty);
            Controls.Add(lblDifficulty);
            Controls.Add(trkBoardSize);
            Controls.Add(lblBoardSize);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minesweeper New Game";
            Load += StartForm_Load;
            ((System.ComponentModel.ISupportInitialize)trkBoardSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblBoardSize;
        private TrackBar trkBoardSize;
        private Label lblDifficulty;
        private ComboBox cmbDifficulty;
        private Button btnPlay;
        private Button btnExit;
    }
}
