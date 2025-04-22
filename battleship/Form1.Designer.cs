namespace battleship
{
    partial class Form1
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
            btnStart = new Button();
            btnRestart = new Button();
            lblStatus = new Label();
            EnemyGrid = new Panel();
            PlayerGrid = new Panel();
            Enemytxt = new TextBox();
            PlayerTxt = new TextBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(100, 30);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(588, 30);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(112, 34);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Location = new Point(369, 35);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(80, 27);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Hit/Miss";
            lblStatus.Click += lblStatus_Click;
            // 
            // EnemyGrid
            // 
            EnemyGrid.BorderStyle = BorderStyle.FixedSingle;
            EnemyGrid.Location = new Point(100, 107);
            EnemyGrid.Name = "EnemyGrid";
            EnemyGrid.Size = new Size(600, 300);
            EnemyGrid.TabIndex = 3;
            EnemyGrid.Paint += EnemyGrid_Paint;
            EnemyGrid.MouseClick += EnemyGrid_MouseClick;
            // 
            // PlayerGrid
            // 
            PlayerGrid.BorderStyle = BorderStyle.FixedSingle;
            PlayerGrid.Location = new Point(100, 459);
            PlayerGrid.Name = "PlayerGrid";
            PlayerGrid.Size = new Size(600, 300);
            PlayerGrid.TabIndex = 4;
            PlayerGrid.Paint += PlayerGid_Paint;
            PlayerGrid.MouseClick += PlayerGid_MouseClick;
            // 
            // Enemytxt
            // 
            Enemytxt.BorderStyle = BorderStyle.FixedSingle;
            Enemytxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enemytxt.Location = new Point(336, 70);
            Enemytxt.Name = "Enemytxt";
            Enemytxt.Size = new Size(150, 34);
            Enemytxt.TabIndex = 5;
            Enemytxt.Text = "Enemy";
            Enemytxt.TextAlign = HorizontalAlignment.Center;
            Enemytxt.TextChanged += Enemytxt_TextChanged;
            // 
            // PlayerTxt
            // 
            PlayerTxt.BorderStyle = BorderStyle.FixedSingle;
            PlayerTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerTxt.Location = new Point(336, 419);
            PlayerTxt.Name = "PlayerTxt";
            PlayerTxt.Size = new Size(150, 34);
            PlayerTxt.TabIndex = 6;
            PlayerTxt.Text = "Player";
            PlayerTxt.TextAlign = HorizontalAlignment.Center;
            PlayerTxt.TextChanged += PlayerTxt_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 844);
            Controls.Add(PlayerTxt);
            Controls.Add(Enemytxt);
            Controls.Add(PlayerGrid);
            Controls.Add(EnemyGrid);
            Controls.Add(lblStatus);
            Controls.Add(btnRestart);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Battleship";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnRestart;
        private Label lblStatus;
        private Panel EnemyGrid;
        private Panel PlayerGrid;
        private TextBox Enemytxt;
        private TextBox PlayerTxt;
    }
}
