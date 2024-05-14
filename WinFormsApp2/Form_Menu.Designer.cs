namespace WinFormsApp2
{
    partial class Form_Menu
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
            L_Title = new Label();
            B_Start = new Button();
            P_Game = new Panel();
            label1 = new Label();
            B_About = new Button();
            B_Quit = new Button();
            P_Main = new Panel();
            P_About = new Panel();
            label3 = new Label();
            P_Score = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            L_Score = new Button();
            P_Main.SuspendLayout();
            P_About.SuspendLayout();
            P_Score.SuspendLayout();
            SuspendLayout();
            // 
            // L_Title
            // 
            L_Title.AutoSize = true;
            L_Title.BackColor = Color.Transparent;
            L_Title.Font = new Font("Microsoft JhengHei UI", 50F);
            L_Title.Location = new Point(132, 107);
            L_Title.Name = "L_Title";
            L_Title.Size = new Size(171, 85);
            L_Title.TabIndex = 0;
            L_Title.Text = "標題";
            // 
            // B_Start
            // 
            B_Start.BackColor = Color.Transparent;
            B_Start.Font = new Font("Impact", 30F);
            B_Start.Location = new Point(43, 302);
            B_Start.Name = "B_Start";
            B_Start.Size = new Size(378, 109);
            B_Start.TabIndex = 1;
            B_Start.TabStop = false;
            B_Start.Text = "Start";
            B_Start.UseVisualStyleBackColor = false;
            B_Start.Click += B_Start_Click;
            // 
            // P_Game
            // 
            P_Game.Location = new Point(244, 23);
            P_Game.Name = "P_Game";
            P_Game.Size = new Size(158, 65);
            P_Game.TabIndex = 2;
            P_Game.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "這是計分板";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // B_About
            // 
            B_About.BackColor = Color.Transparent;
            B_About.Font = new Font("Impact", 30F);
            B_About.Location = new Point(43, 555);
            B_About.Name = "B_About";
            B_About.Size = new Size(378, 109);
            B_About.TabIndex = 3;
            B_About.Text = "About";
            B_About.UseVisualStyleBackColor = false;
            B_About.Click += B_About_Click;
            // 
            // B_Quit
            // 
            B_Quit.BackColor = Color.Transparent;
            B_Quit.Font = new Font("Impact", 30F);
            B_Quit.Location = new Point(43, 679);
            B_Quit.Name = "B_Quit";
            B_Quit.Size = new Size(378, 109);
            B_Quit.TabIndex = 4;
            B_Quit.Text = "Quit";
            B_Quit.UseVisualStyleBackColor = false;
            B_Quit.Click += B_Quit_Click;
            // 
            // P_Main
            // 
            P_Main.Controls.Add(P_About);
            P_Main.Controls.Add(P_Score);
            P_Main.Controls.Add(panel1);
            P_Main.Location = new Point(427, 58);
            P_Main.Name = "P_Main";
            P_Main.Size = new Size(1098, 730);
            P_Main.TabIndex = 0;
            P_Main.Visible = false;
            // 
            // P_About
            // 
            P_About.Controls.Add(label3);
            P_About.Location = new Point(490, 88);
            P_About.Name = "P_About";
            P_About.Size = new Size(297, 251);
            P_About.TabIndex = 4;
            P_About.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 31);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 0;
            label3.Text = "這是關於";
            // 
            // P_Score
            // 
            P_Score.Controls.Add(label1);
            P_Score.Location = new Point(36, 88);
            P_Score.Name = "P_Score";
            P_Score.Size = new Size(415, 281);
            P_Score.TabIndex = 3;
            P_Score.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 48);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 89);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "這是計分板";
            // 
            // L_Score
            // 
            L_Score.BackColor = Color.Transparent;
            L_Score.Font = new Font("Impact", 30F);
            L_Score.Location = new Point(43, 429);
            L_Score.Name = "L_Score";
            L_Score.Size = new Size(378, 109);
            L_Score.TabIndex = 5;
            L_Score.TabStop = false;
            L_Score.Text = "Score";
            L_Score.UseVisualStyleBackColor = false;
            L_Score.Click += L_Score_Click;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1584, 861);
            Controls.Add(L_Score);
            Controls.Add(P_Main);
            Controls.Add(B_Quit);
            Controls.Add(B_About);
            Controls.Add(P_Game);
            Controls.Add(L_Title);
            Controls.Add(B_Start);
            MaximumSize = new Size(1600, 900);
            MinimumSize = new Size(1600, 900);
            Name = "Form_Menu";
            Text = "Form_Menu1";
            Load += Form_Menu_Load;
            Paint += Form_Menu_Paint;
            P_Main.ResumeLayout(false);
            P_About.ResumeLayout(false);
            P_About.PerformLayout();
            P_Score.ResumeLayout(false);
            P_Score.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label L_Title;
        private Button B_Start;
        public Panel P_Game;
        private Button B_About;
        private Button B_Quit;
        private Label label1;
        private Panel P_Main;
        private Panel panel1;
        private Button L_Score;
        private Panel P_Score;
       
        private Label label2;
        private Panel P_About;
        private Label label3;
    }
}