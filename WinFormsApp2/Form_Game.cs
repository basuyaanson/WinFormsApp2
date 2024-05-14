using System;

namespace WinFormsApp2
{
    public partial class Form_Game : Form
    {
        /*//��ܥD���x(���ե�)*/
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        //[return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [System.Runtime.InteropServices.DllImport("Kernel32")]
        public static extern void FreeConsole();

        List<Button> ListButton = new List<Button>();
        List<Panel> ListPanel = new List<Panel>();
        public int HeroNumber
        {  get; set; }
        public bool StartGame
        { get; set; }


        public Form_Game()
        {
            InitializeComponent();
            AllocConsole();
            // AddControl(P_Select, false);
            StartGame = false;
            SelectHero();
           InitialGame();
        }

        public bool Hold
        { get; set; }
        public bool CnaFire { get; set; }
        public int TimeCount
        { get; set; }

        //�C����l��
        public void InitialGame()
        {
            //�s�W����icon
            Bitmap bitmap = (Bitmap)Bitmap.FromFile(@"..\..\..\Asset\aim.ico");
            this.Cursor = new Cursor(bitmap.GetHicon());

            //�p�ɾ�
          
            TimeCount = 0;

            //
            CnaFire = true;

            //�Ǥ�
            SingleObject.GetSingle().AddGameObject(new Aim(0, 0));

            //��H

            //�ĤH
          //  SingleObject.GetSingle().AddGameObject(new EnemyNormal(100, 100, SingleObject.GetSingle().Hero, 0));//�s�W�ĤH
         //   SingleObject.GetSingle().AddGameObject(new EnemyNormal(500, 500, SingleObject.GetSingle().Hero, 0));//�s�W�ĤH
          //  SingleObject.GetSingle().AddGameObject(new EnemySpecial(800, 500, SingleObject.GetSingle().Hero, 1));//�s�W�ĤH
          //  SingleObject.GetSingle().AddGameObject(new EnemySpecial(500, 900, SingleObject.GetSingle().Hero, 0));//�s�W�ĤH

            /*
            //AllocConsole();
           
            GameStart.Start();
            PlayeTime.Start();
            Hold = false;
            this.TimeCount = 1;
            LevelUpSelcet();

            //�s�W����icon
            Bitmap bitmap = (Bitmap)Bitmap.FromFile(@"..\..\..\Asset\aim.ico");
            this.Cursor = new Cursor(bitmap.GetHicon());

            //�g�t
            Timer_Fire.Interval = SingleObject.GetSingle().H.shootSpeed;
            //
            Console.WriteLine("�ͦ����\");*/

        }

        //-------------�ާ@

        //�ƹ�����
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            SingleObject.GetSingle().Aim.MouseMove(e);
        }

        //���U�ƹ�
        private void Form_Game_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Hold = true;
                if (CnaFire == true && Hold == true)
                {
                    SingleObject.GetSingle().Hero.Fire();
                    CnaFire = false;
                }
                Fire_Tick.Start();
            }
            else if (e.Button == MouseButtons.Right)
            {
            }
        }

        //��}�ƹ�
        private void Form_Game_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Hold = false;
            }
            else if (e.Button == MouseButtons.Right)
            {
            }
        }

        //���U��L
        private void Form_Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == PlayerInput.keyup)
            {
                PlayerInput.IsUp = true;
            }
            if (e.KeyCode == PlayerInput.keydown)
            {
                PlayerInput.IsDown = true;
            }
            if (e.KeyCode == PlayerInput.keyright)
            {
                PlayerInput.IsRight = true;
            }
            if (e.KeyCode == PlayerInput.keyleft)
            {
                PlayerInput.IsLeft = true;
            }
            if (e.KeyCode == PlayerInput.keyP)
             {
                 Console.WriteLine("���U");
                 if (PlayerInput.IsP == true)
                 {

                    Game_Tick.Start();
                    Time_Tick.Start();
                    PlayerInput.IsP = false;
                     Console.WriteLine("�}�l");
                 }
                 else if (PlayerInput.IsP == false)
                 {
                  
                     PlayerInput.IsP = true;
                     Console.WriteLine("�Ȱ�");
                 }
             }
        }

        //��}��L
        private void Form_Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == PlayerInput.keyup)
                PlayerInput.IsUp = false;
            if (e.KeyCode == PlayerInput.keydown)
                PlayerInput.IsDown = false;
            if (e.KeyCode == PlayerInput.keyright)
                PlayerInput.IsRight = false;
            if (e.KeyCode == PlayerInput.keyleft)
                PlayerInput.IsLeft = false;

        }

        //---------------�p�ɾ�

        //�e����s ���a���ʨ�s
        private void Game_Tick_Tick(object sender, EventArgs e)
        {
            if (PlayerInput.IsUp && SingleObject.GetSingle().Hero.y >= 10)
            {
                SingleObject.GetSingle().Hero.y -= (int)SingleObject.GetSingle().Hero.Speed;
            }
            if (PlayerInput.IsDown && SingleObject.GetSingle().Hero.y <= 790)
            {
                SingleObject.GetSingle().Hero.y += (int)SingleObject.GetSingle().Hero.Speed;
            }
            if (PlayerInput.IsLeft && SingleObject.GetSingle().Hero.x >= 10)
            {
                SingleObject.GetSingle().Hero.x -= (int)SingleObject.GetSingle().Hero.Speed;
            }
            if (PlayerInput.IsRight && SingleObject.GetSingle().Hero.x <= 1530)
            {
                SingleObject.GetSingle().Hero.x += (int)SingleObject.GetSingle().Hero.Speed;
            }
            this.Invalidate();
           
        }

        //�ɶ��p�ɾ�
        private void Time_Tick_Tick(object sender, EventArgs e)
        {
            TimeCount++;
            L_timeCount.Text = TimeCount.ToString();
            UpdataInfo();
            
        }

        //�۰ʶ}��
        private void Fire_Tick_Tick(object sender, EventArgs e)
        {

            CnaFire = true;
            if (CnaFire == true && Hold == true)
            {
                SingleObject.GetSingle().Hero.Fire();
                CnaFire = false;
            }
            if (Hold == false)
            {
                Fire_Tick.Stop();
                CnaFire = true;
            }
        }

        //---------------�ۭq�q�ƥ�

        public void UpdataInfo()
        {
            L_PlayerInfo.Text =
                "���ʳt��:" + SingleObject.GetSingle().Hero.Speed + " ( " + SingleObject.GetSingle().Hero.HeroSpeed + " + " + SingleObject.GetSingle().Hero.HeroSpeed + ")" +
                "\n�g�t:" + SingleObject.GetSingle().Hero.ShotSpeed+
                "\n�ˮ`:" + SingleObject.GetSingle().Hero.Damage + " (" + SingleObject.GetSingle().Hero.Wp.Damage + " * " + SingleObject.GetSingle().Hero.HeroDamage + ")" +
                "\n�Z������:" + SingleObject.GetSingle().Hero.Wp.WPName.ToString();
                ;
            L_HP.Text = "��q : " + SingleObject.GetSingle().Hero.HP.ToString();
            L_Score.Text ="���� : "+ SingleObject.GetSingle().Hero.Score.ToString();

        }

        public void AddControl(Control c, bool remove)
        {

            Button btn = new Button();
            btn.Text = "�}�l�C��";
            btn.Name = "btn";
            btn.Size = new Size(100, 30);
            btn.Location = new Point(0, 30);
            //btn.TabIndex = 0;
            c.Controls.Add(btn);
            ListButton.Add(btn);
            btn.Click += button1_Click_1;

            /*if (remove == true)
            {
                for (int i = 0; i < 30; i++)
                {
                    Button btn = new Button();
                    btn.Text = i.ToString();
                    btn.Name = i.ToString();
                    btn.Size = new Size(100, 30);
                    btn.Location = new Point(0, i * 30);
                    c.Controls.Remove(btn);
                }
            }
            else
            {
                for (int i = 0; i < 30; i++)
                {
                }
            }*/


        }

        public void LevelUpSelcet()
        {
            //�ɯū��s
            Button Selcet1 = new Button();
            Selcet1.Font = new Font("Microsoft Tai Le", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Selcet1.Location = new Point(508, 254);
            Selcet1.Name = "button";
            Selcet1.Size = new Size(241, 368);
            Selcet1.Text = "���buff\n";
            Selcet1.Click += Hero_Selcet_Click;
            ListButton.Add(Selcet1);
            //Controls.Add(Selcet1);
           // P_Select.Controls.Add(Selcet1);
        }

        //��ܭ^��
        public void SelectHero()
        {
            for(int i = 0; i < Enum.GetNames(typeof(HeroName)).Count(); i++)
            {
                Button btn = new Button();
                btn.Font = new Font("Microsoft Tai Le", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
                btn.Location = new Point(408+i*200, 208);
                btn.Name = "btn"+i;
                btn.Size = new Size(198, 472);
                btn.Text = "��ܭ^�� :\n" + Enum.GetName(typeof(HeroName), i);
                btn.Click += Hero_Selcet_Click;
                this.Controls.Add(btn);
                ListButton.Add(btn);
                
            }
        }

        public void TimeStop(bool Stop)
        {
            if (Stop==true)
            {
                Game_Tick.Stop();
                Time_Tick.Stop();
            }
            else
            {
                Game_Tick.Start();
                Time_Tick.Start();
            }
          
        }

        //---------------�j�w

        private void button1_Click_1(object sender, EventArgs e)
        {
            // AddControl(P_Selcet,true);
         
            this.Controls.Remove(ListButton[0]);
            ListButton.Remove((ListButton[0]));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Controls.Remove(button1);

            //P_Select.Hide();
          
         
          
        }

        private void Hero_Selcet_Click(object sender, EventArgs e)
        {
            //
            Button button = sender as Button;
           
            Console.WriteLine(button.Name);
            StartGame = true;
            if(button.Name == "btn0")
            {
                SingleObject.GetSingle().AddGameObject(new HeroNormal(1600 / 2, 900 / 2, 0));//�s�W���a
            }
            else if (button.Name == "btn1")
            {
                SingleObject.GetSingle().AddGameObject(new HeroGunSlinger(1600 / 2, 900 / 2, 1));//�s�W���a
            }
            /*  else
              {
                  SingleObject.GetSingle().AddGameObject(new HeroNormal(1600 / 2, 900 / 2, 0));//�s�W���a
              }*/
          
            Fire_Tick.Interval = (int)SingleObject.GetSingle().Hero.ShotSpeed;
            TimeStop(false);
            int k = Enum.GetNames(typeof(HeroName)).Count();
            while (k != 0)
            {
                this.Controls.Remove(ListButton[k-1]);
                ListButton.Remove((ListButton[k-1]));
                k--;
            }
            UpdataInfo();
            SingleObject.GetSingle().AddGameObject(new EnemyNormal(100, 100, SingleObject.GetSingle().Hero, 0));//�s�W�ĤH
            SingleObject.GetSingle().AddGameObject(new EnemyNormal(500, 500, SingleObject.GetSingle().Hero, 0));//�s�W�ĤH
            SingleObject.GetSingle().AddGameObject(new EnemySpecial(800, 500, SingleObject.GetSingle().Hero, 1));//�s�W�ĤH
            SingleObject.GetSingle().AddGameObject(new EnemySpecial(500, 900, SingleObject.GetSingle().Hero, 0));//�s�W�ĤH

        }




        //---------------���f�ƥ�

        //���J�e���ɽե�
        private void Form_Game_Load(object sender, EventArgs e)
        {
            //�N�Ϲ�ø�s��w�s�ϡA�ѨM�{�̪����D
            this.SetStyle
                (ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.ResizeRedraw,
                true);
        }

        //�e����s�ե�
        private void Form_Game_Paint(object sender, PaintEventArgs e)
        {
           if(StartGame==true)
            {
                SingleObject.GetSingle().DrwaGameObject(e.Graphics);
            }
          
        }

     


    }
}
