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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            Time_Tick = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Game_Tick
            // 
            Game_Tick.Interval = 33;
            Game_Tick.Tick += Game_Tick_Event;
            // 
            // L_timeCount
            // 
            L_timeCount.AutoSize = true;
            L_timeCount.Location = new Point(18, 18);
            L_timeCount.Name = "L_timeCount";
            L_timeCount.Size = new Size(42, 15);
            L_timeCount.TabIndex = 0;
            L_timeCount.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 155);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 64);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 110);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 155);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(L_timeCount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 205);
            panel1.TabIndex = 5;
            // 
            // Time_Tick
            // 
            Time_Tick.Interval = 1000;
            Time_Tick.Tick += Time_Tick_Tick;
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
            MouseDown += Form_Game_MouseDown;
            MouseMove += Form1_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Game_Tick;
        private Label L_timeCount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private System.Windows.Forms.Timer Time_Tick;
    }
}
