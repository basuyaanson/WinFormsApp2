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
        public int WaveCount
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
            TimeCount = 1;
            //
            CnaFire = true;
            //�Ǥ�
            SingleObject.GetSingle().AddGameObject(new Aim(0, 0));
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
            if (e.KeyCode == PlayerInput.keySpace)
             {
                 Console.WriteLine("���U");
                 if (PlayerInput.IsSpace == true)
                 {
                    TimeStop(true);
                    PlayerInput.IsSpace = false;
                    Console.WriteLine("�}�l");
                 }
                 else if (PlayerInput.IsSpace == false)
                 {
                    TimeStop(false);
                    PlayerInput.IsSpace = true;
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

        //�ɶ��p�ɾ� �P �ĤH�ͦ�
        private void Time_Tick_Tick(object sender, EventArgs e)
        {
            //�ͦ��ĤH
            if (TimeCount % 5 == 0)
            {
                EnemyWave(0);
            }
            if (TimeCount % 15 == 0 || TimeCount % 25 == 0)
            {
                EnemyWave(1);
            }
            if (TimeCount % 60 == 0)
            {
                WaveCount++;
                EnemyWave(2);
            }
            //�C���ɶ��p��
            TimeCount++;
            L_timeCount.Text = TimeCount.ToString();
            Cheaklevelup();
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

        //��s��T����
        public void UpdataInfo()
        {
            L_PlayerInfo.Text =
                "���ʳt��:" + SingleObject.GetSingle().Hero.Speed + " ( " + SingleObject.GetSingle().Hero.HeroSpeed + " + " + SingleObject.GetSingle().Hero.Wp.MoveSpeed + ")" +
                "\n�g�t:" + SingleObject.GetSingle().Hero.ShotSpeed+
                "\n�ˮ`:" + SingleObject.GetSingle().Hero.Damage + " (" + SingleObject.GetSingle().Hero.Wp.Damage + " * " + SingleObject.GetSingle().Hero.HeroDamage + ")" +
                "\n�Z������:" + SingleObject.GetSingle().Hero.Wp.WPName.ToString();
                ;
            L_HP.Text = "��q : " + SingleObject.GetSingle().Hero.HP.ToString();
            L_Score.Text ="���� : "+ SingleObject.GetSingle().Hero.Score.ToString();
            L_WaveCount.Text ="�i�� : " + WaveCount;
            L_LV.Text ="LV : " + SingleObject.GetSingle().Hero.Level.ToString();

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
            //btn.Click += button1_Click_1;

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

        //��ܭ^��
        public void SelectHero()
        {
            for (int i = 0; i < Enum.GetNames(typeof(HeroName)).Count(); i++)
            {
                Button btn = new Button();
                btn.Font = new Font("Microsoft Tai Le", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
                btn.Location = new Point(408 + i * 200, 208);
                btn.Name = "btn" + i;
                btn.Size = new Size(198, 472);
                btn.Text = "��ܭ^�� :\n" + Enum.GetName(typeof(HeroName), i);
                btn.Click += Hero_Selcet_Click;
                this.Controls.Add(btn);
                ListButton.Add(btn);
            }
        }

        //���Buff
        public void SelectBuff()
        {
            TimeStop(true);
            for (int i = 0; i < 3; i++)
            {
                string[] buff = SingleObject.GetSingle().Hero.GetBuff();

                Button btn = new Button();
                btn.Font = new Font("Microsoft Tai Le", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
                btn.Location = new Point(408 + i * 200, 208);
                btn.Name = buff[0];
                btn.Size = new Size(198, 472);
                btn.Text = "���Buff :\n" + buff[1];
                btn.Click += Buff_Selcet_Click;
                this.Controls.Add(btn);
                ListButton.Add(btn);
                Console.WriteLine(buff[0]);
            }
           
        }

        //�Ȱ��C��
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
        
        //��o�ĤH�H����m
        public int[] GetRandom()
        {
            Random r = new Random();
            int[] XY = { 0, 0 };
            //�P�_���k�٬O�W�U
            if (r.Next(0, 100) > 50)
            {
                // �P�_���٬O�k
                if (r.Next(0, 100) > 50)
                {
                    XY[0] = -10;
                }
                else
                {
                    XY[0] = 1610;
                }
                XY[1] = r.Next(0, 910);
            }
            else
            {
                // �P�_�W�٬O�U
                if (r.Next(0, 100) > 50)
                {
                    XY[1] = -10;
                }
                else
                {
                    XY[1] = 910;
                }
                XY[0] = r.Next(0, 1610);
            }
            return XY;
        }
        
        //�s�W�ĤH
        public void EnemyWave(int Wavelevel)
        {
            int[] RandomXY = new int[2];
            Random r = new Random();
            //�s�W�ĤH
            switch (Wavelevel)
            {
                //���q��
                case 0:
                    for (int i = 0; i < 4; i++)
                    {
                        RandomXY = GetRandom();
                        SingleObject.GetSingle().AddGameObject(new EnemyNormal(RandomXY[0], RandomXY[1],
                            SingleObject.GetSingle().Hero,r.Next(0,1)));
                    }

                    break;
                //�S���
                case 1:
                    for (int i = 0; i < 2; i++)
                    {
                        RandomXY = GetRandom();
                        SingleObject.GetSingle().AddGameObject(new EnemySpecial(RandomXY[0], RandomXY[1],
                            SingleObject.GetSingle().Hero, r.Next(0,2)));
                    }
                    break;
                //����
                case 2:
                    for (int i = 0; i < 1; i++)
                    {
                        RandomXY = GetRandom();
                        SingleObject.GetSingle().AddGameObject(new EnemyBoss(RandomXY[0], RandomXY[1],
                          SingleObject.GetSingle().Hero, r.Next(0, 1)));
                    }
                    break;
            }

        }
        //�˴��ɯ�
        public void Cheaklevelup()
        {
            if(SingleObject.GetSingle().Hero.Score > 30 * SingleObject.GetSingle().Hero.Level)
            {
                SelectBuff();
            }
        }

        //---------------�j�w

        //�T�w���buff
        private void Buff_Selcet_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            
            Console.WriteLine(button.Name);
            SingleObject.GetSingle().Hero.SelcetBuff(button.Name);
            SingleObject.GetSingle().Hero.GetHeroInfo();
            SingleObject.GetSingle().Hero.SetWeaponInfo(SingleObject.GetSingle().Hero.WeaponNumber);
            TimeStop(false);
           
            int k = 3;
            while (k != 0)
            {
                this.Controls.Remove(ListButton[k-1]);
                ListButton.Remove((ListButton[k-1]));
                k--;
            }
            UpdataInfo();
        }

        //�T�w��ܭ^��
        private void Hero_Selcet_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            StartGame = true;//�}�l�C��
            //�P�_��ܨ���
            if (button.Name == "btn0")
            {
                SingleObject.GetSingle().AddGameObject(new HeroNormal(1600 / 2, 900 / 2, 0));//�s�W���a
            }
            else if (button.Name == "btn1")
            {
                SingleObject.GetSingle().AddGameObject(new HeroGunSlinger(1600 / 2, 900 / 2, 1));//�s�W���a
            }
           
            Fire_Tick.Interval = (int)SingleObject.GetSingle().Hero.ShotSpeed;//�g�t
            TimeStop(false);
            //�R�����s
            int k = Enum.GetNames(typeof(HeroName)).Count();
            while (k != 0)
            {
                this.Controls.Remove(ListButton[k - 1]);
                ListButton.Remove((ListButton[k - 1]));
                k--;
            }
            UpdataInfo();
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
