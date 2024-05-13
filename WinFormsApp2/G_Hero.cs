using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    class Hero : GameObject
    {
      
        //建構子 傳入座標
        public Hero(int x, int y, WeaponFater wp) : base(x, y, img.Width, img.Height)
        {
            HeroType(wp);
        }
        //圖片
        private static Image img = Asset.em1;

        //獲得武器類型
        public WeaponFater Wp
        {
            get; set;
        }

        public void HeroType(WeaponFater wp)
        {
            this.Speed = 3;
            this.HP = 1;
            this.Damage = 1;
            this.Level = 1;
        }

        //繪製
        public override void Draw(Graphics g)
        {
            g.DrawImage(img, this.x, this.y);
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
    //玩家
    /* class Hero : GameObject
     {
         //建構子 座標 速度 生命值 攻擊傷害
         public Hero(int x, int y, int speed, int hp, int damage, int level) : base(x, y, img.Width, img.Height)
         {
             this.Score = 1;
             this.CnaFire = true;
             this.shootSpeed = 1000;
         }
         //玩家圖片
         private static Image img = Resource1.em1;
         //
         public int Score
         { get; set; }
         public bool CnaFire
         { get; set; }
         public int shootSpeed
         { get; set; }

         //
         public override void Draw(Graphics g)
         {
             g.DrawImage(img, this.x, this.y);
             //
             Pen p = new Pen(Color.Red);
             g.DrawRectangle(p, this.x, y, this.Width, this.Height);

         }

         public void Fire()
         {
             SingleObject.GetSingle().AddGameObject(new HeroBullet
                 (SingleObject.GetSingle().Aim.x, SingleObject.GetSingle().Aim.y, this.x + 10, this.y + 30, 10));
         }

         //隨機獲得buff
         public string[] GetBuff()
         {
             string[] buff = new string[3];

             Random r = new Random();
             switch (r.Next(0, 3))
             {
                 case 0:
                     buff[0] = "0";
                     buff[1] = "移動速度增加 1";
                     return buff;
                 case 1:
                     buff[0] = "1";
                     buff[1] = "生命值增加 5";
                     return buff;
                 case 2:
                     buff[0] = "2";
                     buff[1] = "變更射擊速度 快";
                     return buff;
                 case 3:
                     buff[0] = "3";
                     buff[1] = "傷害增加 2";
                     return buff;
                 default:
                     return buff;
             }
         }

         //確定選擇buff並賦值
         public void SelcetBuff(string selcet)
         {
             switch (selcet)
             {
                 case "0":
                     this.Speed += 1;
                     break;
                 case "1":
                     this.hp += 5;
                     break;
                 case "2":
                     this.shootSpeed = 100;
                     break;
                 case "3":
                     this.Damage += 2;
                     break;
             }
             this.Level += 1;
         }

         /* //玩家死亡
          public void IsDead()
          {
              if (this.hp <= 0)
              {
                  //刪除自身
              }
          }*/
}


