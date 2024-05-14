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
            P_Info = new Panel();
            L_LV = new Label();
            Time_Tick = new System.Windows.Forms.Timer(components);
            Fire_Tick = new System.Windows.Forms.Timer(components);
            P_Meun = new Panel();
            B_Back = new Button();
            P_Info.SuspendLayout();
            P_Meun.SuspendLayout();
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
            L_timeCount.BackColor = Color.Transparent;
            L_timeCount.BorderStyle = BorderStyle.FixedSingle;
            L_timeCount.Font = new Font("Microsoft JhengHei UI", 25F);
            L_timeCount.ForeColor = SystemColors.Control;
            L_timeCount.Location = new Point(5, 8);
            L_timeCount.Name = "L_timeCount";
            L_timeCount.Size = new Size(101, 45);
            L_timeCount.TabIndex = 0;
            L_timeCount.Text = "9999";
            // 
            // L_HP
            // 
            L_HP.AutoSize = true;
            L_HP.BackColor = Color.Transparent;
            L_HP.BorderStyle = BorderStyle.FixedSingle;
            L_HP.Font = new Font("Microsoft JhengHei UI", 15F);
            L_HP.ForeColor = SystemColors.Control;
            L_HP.Location = new Point(5, 220);
            L_HP.Name = "L_HP";
            L_HP.Size = new Size(105, 27);
            L_HP.TabIndex = 1;
            L_HP.Text = "血量 : 999";
            // 
            // L_Score
            // 
            L_Score.AutoSize = true;
            L_Score.BackColor = Color.Transparent;
            L_Score.Font = new Font("Microsoft JhengHei UI", 14F);
            L_Score.ForeColor = SystemColors.Control;
            L_Score.Location = new Point(5, 63);
            L_Score.Name = "L_Score";
            L_Score.Size = new Size(106, 24);
            L_Score.TabIndex = 2;
            L_Score.Text = "成績 : 9999";
            // 
            // L_PlayerInfo
            // 
            L_PlayerInfo.AutoSize = true;
            L_PlayerInfo.Font = new Font("Microsoft JhengHei UI", 12F);
            L_PlayerInfo.ForeColor = SystemColors.Control;
            L_PlayerInfo.Location = new Point(5, 130);
            L_PlayerInfo.Name = "L_PlayerInfo";
            L_PlayerInfo.Size = new Size(13, 20);
            L_PlayerInfo.TabIndex = 3;
            L_PlayerInfo.Text = ".";
            // 
            // L_WaveCount
            // 
            L_WaveCount.AutoSize = true;
            L_WaveCount.BackColor = Color.Transparent;
            L_WaveCount.Font = new Font("Microsoft JhengHei UI", 15F);
            L_WaveCount.ForeColor = SystemColors.Control;
            L_WaveCount.Location = new Point(3, 96);
            L_WaveCount.Name = "L_WaveCount";
            L_WaveCount.Size = new Size(103, 25);
            L_WaveCount.TabIndex = 4;
            L_WaveCount.Text = "波次 : 999";
            // 
            // P_Info
            // 
            P_Info.BackColor = Color.CornflowerBlue;
            P_Info.BackgroundImageLayout = ImageLayout.Zoom;
            P_Info.Controls.Add(L_PlayerInfo);
            P_Info.Controls.Add(L_WaveCount);
            P_Info.Controls.Add(L_LV);
            P_Info.Controls.Add(L_Score);
            P_Info.Controls.Add(L_timeCount);
            P_Info.Controls.Add(L_HP);
            P_Info.Location = new Point(12, 12);
            P_Info.Name = "P_Info";
            P_Info.Size = new Size(163, 301);
            P_Info.TabIndex = 5;
            // 
            // L_LV
            // 
            L_LV.AutoSize = true;
            L_LV.BackColor = Color.Transparent;
            L_LV.BorderStyle = BorderStyle.FixedSingle;
            L_LV.Font = new Font("Microsoft JhengHei UI", 15F);
            L_LV.ForeColor = SystemColors.Control;
            L_LV.Location = new Point(5, 258);
            L_LV.Name = "L_LV";
            L_LV.Size = new Size(105, 27);
            L_LV.TabIndex = 5;
            L_LV.Text = "血量 : 999";
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
            // P_Meun
            // 
            P_Meun.BackColor = SystemColors.ControlDarkDark;
            P_Meun.Controls.Add(B_Back);
            P_Meun.Location = new Point(554, 242);
            P_Meun.Name = "P_Meun";
            P_Meun.Size = new Size(476, 376);
            P_Meun.TabIndex = 6;
            // 
            // B_Back
            // 
            B_Back.Location = new Point(121, 39);
            B_Back.Name = "B_Back";
            B_Back.Size = new Size(238, 96);
            B_Back.TabIndex = 0;
            B_Back.Text = "回主頁";
            B_Back.UseVisualStyleBackColor = true;
            B_Back.Click += B_Back_Click;
            // 
            // Form_Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(P_Meun);
            Controls.Add(P_Info);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1600, 900);
            MinimumSize = new Size(1600, 900);
            Name = "Form_Game";
            Text = "Form1";
            Load += Form_Game_Load;
            Paint += Form_Game_Paint;
            KeyDown += Form_Game_KeyDown;
            KeyUp += Form_Game_KeyUp;
            MouseClick += Form_Game_MouseClick;
            MouseDown += Form_Game_MouseDown;
            MouseMove += Form1_MouseMove;
            P_Info.ResumeLayout(false);
            P_Info.PerformLayout();
            P_Meun.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Game_Tick;
        private Label L_timeCount;
        private Label L_HP;
        private Label L_Score;
        private Label L_PlayerInfo;
        private Label L_WaveCount;
        private Panel P_Info;
        private System.Windows.Forms.Timer Time_Tick;
        private System.Windows.Forms.Timer Fire_Tick;
        private Label L_LV;
        private Panel P_Meun;
        private Button B_Back;
    }
}
