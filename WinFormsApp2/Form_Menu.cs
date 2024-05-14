using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form_Menu : Form

    {   /*//顯示主控台(測試用)*/
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        //[return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [System.Runtime.InteropServices.DllImport("Kernel32")]
        public static extern void FreeConsole();

        public bool IsUse;

        public Form_Menu()
        {
            //  AllocConsole();
            SingleObject.GetSingle().AddGameObject(new MenuBackground(0, 0));
            InitializeComponent();

            P_Main.BackColor = Color.FromArgb(100, 100, 100, 100);
            P_Main.Size = new(1098, 730);
            P_Main.Location = new(446, 67);

            P_Game.Size = new(1600, 900);
            P_Game.Location = new(0, 0);
        }


        public void getbg()
        {
            B_Start.Enabled = true;
            SingleObject.GetSingle().AddGameObject(new MenuBackground(0, 0));
        }

        public void loadform(object Form)
        {
            /*  if (this.P_Main.Controls.Count > 0)
                  this.P_Main.Controls.RemoveAt(0);*/
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.P_Game.Controls.Add(f);
            this.P_Game.Tag = f;
            P_Game.Show();
            f.Show();

        }

        public void P_MainUse()
        {
            if (IsUse == false)
            {
             
                if (P_About.Visible == true && P_Score.Visible == false)
                {

                    P_Score.Show();
                    P_About.Hide();
                }
                else
                {
                    P_About.Show();
                    P_Score.Hide();
                }
                P_Main.Show();
                IsUse = true;
            }
            else
            {
                if (P_About.Visible == true && P_Score.Visible == false)
                {

                    P_Score.Show();
                    P_About.Hide();
                }
                else
                {
                    P_About.Show();
                    P_Score.Hide();
                }
                P_Main.Hide();
                IsUse = false;
            }
        }

        //------------------------------
        //開始遊戲
        private void B_Start_Click(object sender, EventArgs e)
        {
            P_Game.Show();
            P_Game.BringToFront();
            Form_Game Game = new Form_Game();
            loadform(Game);
            B_Start.Enabled = false;
            Game.GetForm(this);
        }
       
        private void L_Score_Click(object sender, EventArgs e)
        {
            if (IsUse == false)
            {
                P_Main.Show();
                P_Score.Show();
                P_About.Hide();
                IsUse = true;
            }
            else
            {
                if (P_Score.Visible == false && P_About.Visible == true)
                {
                    P_Score.Show();
                    P_About.Hide();
                }
                else if (P_Score.Visible == true)
                {
                    P_Main.Hide();
                    IsUse = false;
                }

            }

        }

        //關於
        private void B_About_Click(object sender, EventArgs e)
        {
            if (IsUse == false)
            {
                P_Main.Show();
                P_About.Show();
                P_Score.Hide();
                IsUse = true;
            }
            else
            {
                if (P_About.Visible == false && P_Score.Visible == true)
                {
                    P_About.Show();
                    P_Score.Hide();
                }
                else if (P_About.Visible == true)
                {
                    P_Main.Hide();
                    IsUse = false;
                }
            }

        }

        //離開
        private void B_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------------------

        private void Form_Menu_Load(object sender, EventArgs e)
        {

            //將圖像繪製到緩存區，解決閃屏的問題
            this.SetStyle
                (ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.ResizeRedraw,
                true);
        }

        private void Form_Menu_Paint(object sender, PaintEventArgs e)
        {
            SingleObject.GetSingle().DrawBK(e.Graphics);
        }

      
    }
}
