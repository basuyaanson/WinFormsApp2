using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    //玩家類
    class Hero : GameObject
    {
        //建構子 傳入座標 武器編號
        public Hero(int x, int y, int weaponNumber,int Skill) : base(x, y, img.Width, img.Height)
        {
            this.Skill = Skill;
            this.WeaponNumber = weaponNumber;

            this.Level = 1;//等級

            SetHeroInfo(Skill);
            SetWeaponInfo(WeaponNumber);
        }

        //圖片
        private static Image img = Asset.em1;

        //獲得武器類型
        public WeaponFater Wp
        {
            get; set;
        }

        //
        public int ShotSpeed
        { get; set; }
        public int WeaponNumber
        { get; set; }
        public int Skill
        { get; set; }

        //--------------事件
        public void SetHeroInfo(int Skill)
        {
            switch (Skill)
            {
                //普通人
                case 0:
                    this.HP = 100;//生命值
                    this.Speed = 3;
                    this.Damage = 5;
                    break;

                //震撼(教練)
                case 1:
                    this.HP = 150;//生命值
                    this.Speed = 2;
                    this.Damage = 3;
                    break;
            }
        }

        //獲得玩家基礎數值
        public void SetWeaponInfo(int wea)
        {
            switch(wea)
            {
                case 0:
                    Wp = new WP_Pistol(0, 0, 0, 0);
                    this.Speed = Wp.MoveSpeed + this.Speed;
                    break;

                case 1:
                    Wp = new WP_Rifle(0, 0, 0, 0);
                    this.Speed = Wp.MoveSpeed + this.Speed;
                    break;

            }
        }

        //繪製
        public override void Draw(Graphics g)
        {
            g.DrawImage(img, this.x, this.y);
        }

        //開火
        public void Fire()
        {
            switch (WeaponNumber)
            {
                case 0:
                    SingleObject.GetSingle().AddGameObject(new WP_Rifle
                            (SingleObject.GetSingle().Aim.x, SingleObject.GetSingle().Aim.y, this.x + this.Width / 2, this.y + this.Height / 2));
                    break;
                case 1:
                    SingleObject.GetSingle().AddGameObject(new WP_Pistol
                            (SingleObject.GetSingle().Aim.x, SingleObject.GetSingle().Aim.y, this.x + this.Width / 2, this.y + this.Height / 2));
                    break;
            }

        }

    }

    //準心
    class Aim : GameObject
    {
        //座標
        public Aim(int x, int y) : base(x, y)
        {
        }
        //移動滑鼠
        public void MouseMove(MouseEventArgs e)
        {

            this.x = e.X;//飛機的座標等於鼠標
            this.y = e.Y;
        }
    }

    //按鍵輸入
    class PlayerInput
    {
        public readonly static Keys keyup = Keys.W;
        public readonly static Keys keydown = Keys.S;
        public readonly static Keys keyleft = Keys.A;
        public readonly static Keys keyright = Keys.D;
        public readonly static Keys keyP = Keys.P;

        public static bool IsUp = false;
        public static bool IsDown = false;
        public static bool IsLeft = false;
        public static bool IsRight = false;
        public static bool IsP = true;
    }
}


