namespace WinFormsApp2
{
    partial class Form_Game
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
            components = new System.ComponentModel.Container();
            Game_Tick = new System.Windows.Forms.Timer(components);
            L_timeCount = new Label();
            L_HP = new Label();
            L_Score = new Label();
            L_PlayerInfo = new Label();
            L_WaveCount = new Label();
            panel1 = new Panel();
            Time_Tick = new System.Windows.Forms.Timer(components);
            Fire_Tick = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Game_Tick
            // 
            Game_Tick.Interval = 33;
            Game_Tick.Tick += Game_Tick_Tick;
            // 
            // L_timeCount
            // 
            L_timeCount.AutoSize = true;
            L_timeCount.Font = new Font("Microsoft JhengHei UI", 25F);
            L_timeCount.Location = new Point(18, 17);
            L_timeCount.Name = "L_timeCount";
            L_timeCount.Size = new Size(99, 43);
            L_timeCount.TabIndex = 0;
            L_timeCount.Text = "9999";
            // 
            // L_HP
            // 
            L_HP.AutoSize = true;
            L_HP.Font = new Font("Microsoft JhengHei UI", 15F);
            L_HP.Location = new Point(12, 238);
            L_HP.Name = "L_HP";
            L_HP.Size = new Size(115, 25);
            L_HP.TabIndex = 1;
            L_HP.Text = "血量 : 5000";
            // 
            // L_Score
            // 
            L_Score.AutoSize = true;
            L_Score.Font = new Font("Microsoft JhengHei UI", 14F);
            L_Score.Location = new Point(12, 70);
            L_Score.Name = "L_Score";
            L_Score.Size = new Size(117, 24);
            L_Score.TabIndex = 2;
            L_Score.Text = "分數 : 99999";
            // 
            // L_PlayerInfo
            // 
            L_PlayerInfo.AutoSize = true;
            L_PlayerInfo.Font = new Font("Microsoft JhengHei UI", 12F);
            L_PlayerInfo.Location = new Point(12, 138);
            L_PlayerInfo.Name = "L_PlayerInfo";
            L_PlayerInfo.Size = new Size(41, 20);
            L_PlayerInfo.TabIndex = 3;
            L_PlayerInfo.Text = "射速";
            // 
            // L_WaveCount
            // 
            L_WaveCount.AutoSize = true;
            L_WaveCount.Font = new Font("Microsoft JhengHei UI", 15F);
            L_WaveCount.Location = new Point(18, 103);
            L_WaveCount.Name = "L_WaveCount";
            L_WaveCount.Size = new Size(91, 25);
            L_WaveCount.TabIndex = 4;
            L_WaveCount.Text = "波次 : 99";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(L_WaveCount);
            panel1.Controls.Add(L_HP);
            panel1.Controls.Add(L_timeCount);
            panel1.Controls.Add(L_PlayerInfo);
            panel1.Controls.Add(L_Score);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 273);
            panel1.TabIndex = 5;
            // 
            // Time_Tick
            // 
            Time_Tick.Interval = 1000;
            Time_Tick.Tick += Time_Tick_Tick;
            // 
            // Fire_Tick
            // 
            Fire_Tick.Tick += Fire_Tick_Tick;
            // 
            // Form_Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(panel1);
            Name = "Form_Game";
            Text = "Form1";
            Load += Form_Game_Load;
            Paint += Form_Game_Paint;
            KeyDown += Form_Game_KeyDown;
            KeyUp += Form_Game_KeyUp;
            MouseClick += Form_Game_MouseClick;
            MouseDown += Form_Game_MouseDown;
            MouseMove += Form1_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Game_Tick;
        private Label L_timeCount;
        private Label L_HP;
        private Label L_Score;
        private Label L_PlayerInfo;
        private Label L_WaveCount;
        private Panel panel1;
        private System.Windows.Forms.Timer Time_Tick;
        private System.Windows.Forms.Timer Fire_Tick;
    }
}
