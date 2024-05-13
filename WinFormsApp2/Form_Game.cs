namespace WinFormsApp2
{
    public partial class Form_Game : Form
    {
        /*//顯示主控台(測試用)*/
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

        //遊戲初始化
        public void InitialGame()
        {
            //新增鼠標icon
            Bitmap bitmap = (Bitmap)Bitmap.FromFile(@"..\..\..\Asset\aim.ico");
            this.Cursor = new Cursor(bitmap.GetHicon());

            //計時器
            Game_Tick.Start();

            //準心
            SingleObject.GetSingle().AddGameObject(new Aim(0, 0));

            //對象
            SingleObject.GetSingle().AddGameObject(new Hero(0, 0, 1,0));//新增玩家

            //敵人
            SingleObject.GetSingle().AddGameObject(new EnemyNormal(100, 100, SingleObject.GetSingle().Hero, 0));//新增敵人
            SingleObject.GetSingle().AddGameObject(new EnemyNormal(500, 500, SingleObject.GetSingle().Hero, 0));//新增敵人
            SingleObject.GetSingle().AddGameObject(new EnemySpecial(800, 500, SingleObject.GetSingle().Hero, 1));//新增敵人
            SingleObject.GetSingle().AddGameObject(new EnemySpecial(500, 900, SingleObject.GetSingle().Hero, 0));//新增敵人


            /*
            //AllocConsole();
           
            GameStart.Start();
            PlayeTime.Start();
            Hold = false;
            this.TimeCount = 1;
            LevelUpSelcet();
            //新增鼠標icon
            Bitmap bitmap = (Bitmap)Bitmap.FromFile(@"..\..\..\Asset\aim.ico");
            this.Cursor = new Cursor(bitmap.GetHicon());

            //射速
            Timer_Fire.Interval = SingleObject.GetSingle().H.shootSpeed;
            //
            Console.WriteLine("生成成功");*/
        }


        //-------------操作

        //滑鼠移動
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            SingleObject.GetSingle().Aim.MouseMove(e);
        }

        //按下滑鼠
        private void Form_Game_MouseDown(object sender, MouseEventArgs e)
        {

            SingleObject.GetSingle().Hero.Fire();
        }

        //按下鍵盤
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
                 Console.WriteLine("按下");
                 if (PlayerInput.IsP == true)
                 {
                     PlayeTime.Start();
                     GameStart.Start();
                     P_Meun.Hide();
                     PlayerInput.IsP = false;
                     Console.WriteLine("開始");
                 }
                 else if (PlayerInput.IsP == false)
                 {
                     PlayeTime.Stop();
                     GameStart.Stop();
                     P_Meun.Show();
                     PlayerInput.IsP = true;
                     Console.WriteLine("暫停");
                 }
             }*/
        }

        //放開鍵盤
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

        //---------------自訂義事件

        public void Sll()
        {

        }

        //---------------計時器

        //畫面刷新 玩家移動刷新
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

        //時間計時器
        private void Time_Tick_Tick(object sender, EventArgs e)
        {

        }

        //---------------窗口事件

        //載入畫面時調用

        //---------------窗口事件

        //載入畫面時調用
        private void Form_Game_Load(object sender, EventArgs e)
        {
            //將圖像繪製到緩存區，解決閃屏的問題
            this.SetStyle
                (ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.ResizeRedraw,
                true);
        }

        //畫面刷新調用
        private void Form_Game_Paint(object sender, PaintEventArgs e)
        {
            SingleObject.GetSingle().DrwaGameObject(e.Graphics);
        }

     
    }
}
