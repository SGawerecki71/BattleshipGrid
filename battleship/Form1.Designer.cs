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
            PlayerGridPanel = new Panel();
            Enemylbl = new Label();
            PlayerLbl = new Label();
            checkBox1 = new CheckBox();
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
            lblStatus.Location = new Point(360, 35);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(80, 27);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Hit/Miss";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Click += lblStatus_Click;
            // 
            // EnemyGrid
            // 
            EnemyGrid.BackColor = Color.LightSkyBlue;
            EnemyGrid.BorderStyle = BorderStyle.FixedSingle;
            EnemyGrid.Location = new Point(100, 107);
            EnemyGrid.Name = "EnemyGrid";
            EnemyGrid.Size = new Size(600, 300);
            EnemyGrid.TabIndex = 3;
            EnemyGrid.Paint += EnemyGrid_Paint;
            EnemyGrid.MouseClick += EnemyGrid_MouseClick;
            // 
            // PlayerGridPanel
            // 
            PlayerGridPanel.BackColor = Color.LightSkyBlue;
            PlayerGridPanel.BorderStyle = BorderStyle.FixedSingle;
            PlayerGridPanel.Location = new Point(100, 459);
            PlayerGridPanel.Name = "PlayerGridPanel";
            PlayerGridPanel.Size = new Size(600, 300);
            PlayerGridPanel.TabIndex = 4;
            PlayerGridPanel.Paint += PlayerGid_Paint;
            PlayerGridPanel.MouseClick += PlayerGid_MouseClick;
            // 
            // Enemylbl
            // 
            Enemylbl.AutoSize = true;
            Enemylbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enemylbl.Location = new Point(375, 76);
            Enemylbl.Name = "Enemylbl";
            Enemylbl.Size = new Size(70, 28);
            Enemylbl.TabIndex = 5;
            Enemylbl.Text = "Enemy";
            // 
            // PlayerLbl
            // 
            PlayerLbl.AutoSize = true;
            PlayerLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerLbl.Location = new Point(375, 428);
            PlayerLbl.Name = "PlayerLbl";
            PlayerLbl.Size = new Size(65, 28);
            PlayerLbl.TabIndex = 6;
            PlayerLbl.Text = "Player";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(480, 427);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(183, 29);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Verticle/Horizontal";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(808, 844);
            Controls.Add(checkBox1);
            Controls.Add(PlayerLbl);
            Controls.Add(Enemylbl);
            Controls.Add(PlayerGridPanel);
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
        private Panel PlayerGridPanel;
        private Label Enemylbl;
        private Label PlayerLbl;
        private CheckBox checkBox1;
    }
}
