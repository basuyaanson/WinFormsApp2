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

        public Form_Game()
        {
            InitializeComponent();
            InitialGame();
            AllocConsole();
        }

        //�C����l��
        public void InitialGame()
        {
            //�s�W����icon
            Bitmap bitmap = (Bitmap)Bitmap.FromFile(@"..\..\..\Asset\aim.ico");
            this.Cursor = new Cursor(bitmap.GetHicon());

            //�p�ɾ�
            Game_Tick.Start();

            //�Ǥ�
            SingleObject.GetSingle().AddGameObject(new Aim(0, 0));

            //��H
            SingleObject.GetSingle().AddGameObject(new Hero(0, 0, 1,0));//�s�W���a

            //�ĤH
            SingleObject.GetSingle().AddGameObject(new EnemyNormal(100, 100, SingleObject.GetSingle().Hero, 0));//�s�W�ĤH
            SingleObject.GetSingle().AddGameObject(new EnemyNormal(500, 500, SingleObject.GetSingle().Hero, 0));//�s�W�ĤH
            SingleObject.GetSingle().AddGameObject(new EnemySpecial(800, 500, SingleObject.GetSingle().Hero, 1));//�s�W�ĤH
            SingleObject.GetSingle().AddGameObject(new EnemySpecial(500, 900, SingleObject.GetSingle().Hero, 0));//�s�W�ĤH


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

            SingleObject.GetSingle().Hero.Fire();
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
            /* if (e.KeyCode == PlayerInput.keyP)
             {
                 Console.WriteLine("���U");
                 if (PlayerInput.IsP == true)
                 {
                     PlayeTime.Start();
                     GameStart.Start();
                     P_Meun.Hide();
                     PlayerInput.IsP = false;
                     Console.WriteLine("�}�l");
                 }
                 else if (PlayerInput.IsP == false)
                 {
                     PlayeTime.Stop();
                     GameStart.Stop();
                     P_Meun.Show();
                     PlayerInput.IsP = true;
                     Console.WriteLine("�Ȱ�");
                 }
             }*/
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

        //---------------�ۭq�q�ƥ�

        public void Sll()
        {

        }

        //---------------�p�ɾ�

        //�e����s ���a���ʨ�s
        private void Game_Tick_Event(object sender, EventArgs e)
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

        }

        //---------------���f�ƥ�

        //���J�e���ɽե�

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
            SingleObject.GetSingle().DrwaGameObject(e.Graphics);
        }

     
    }
}
