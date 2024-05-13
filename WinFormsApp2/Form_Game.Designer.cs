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
            SuspendLayout();
            // 
            // Game_Tick
            // 
            Game_Tick.Interval = 33;
            Game_Tick.Tick += Game_Tick_Event;
            // 
            // Form_Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Name = "Form_Game";
            Text = "Form1";
            Load += Form_Game_Load;
            Paint += Form_Game_Paint;
            KeyDown += Form_Game_KeyDown;
            KeyUp += Form_Game_KeyUp;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Game_Tick;
    }
}
