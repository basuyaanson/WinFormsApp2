using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    enum HeroName
    {
        普通人,槍俠
    }
   
    //玩家類
    class HeroFather : GameObject
    {
        public int HeroSpeed;
        public double HeroDamage;//傷害加成係數
       
        //建構子 傳入座標 武器編號
        public HeroFather(int x, int y, int weaponNumber,Image img) : base(x, y, img.Width, img.Height)
        {
            this.WeaponNumber = weaponNumber;
        }

        //獲得武器類型
        public WeaponFater Wp
        {
            get; set;
        }
        
        //
        public int WeaponNumber
        { get; set; }

        //--------------事件
     
        //獲得玩家數值
        public virtual void GetHeroInfo()
        {

        }

        //獲得玩家基礎數值
        public virtual void SetWeaponInfo(int wea)
        {
            switch (wea)
            {
                case 0:
                    Wp = new WP_Pistol(0, 0, 0, 0);
                    break;

                case 1:
                    Wp = new WP_Rifle(0, 0, 0, 0);
                    break;
            }
            //加成後的數值
            this.Speed = Wp.MoveSpeed + HeroSpeed;
            this.Damage = Wp.Damage * HeroDamage;
            this.ShotSpeed = Wp.ShotSpeed;
            Console.WriteLine("武器加成成功");
        }

        public void UseSkill()
        {
        }

        //隨機獲得buff
        public virtual string[] GetBuff()
        {
            string[] buff = new string[3];
            
            Random r = new Random();
            //移動速度 生命值 射速加乘 傷害加成 武器類型
            int rr = r.Next(0,4);
           
            switch (r.Next(0, 3))
            {
                case 0:
                    buff[0] = "0";
                    buff[1] = "移動速度增加 1";
                    return buff;
                case 1:
                    buff[0] = "1";
                    buff[1] = "生命值增加 50";
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
        public virtual void SelcetBuff(string selcet)
        {
            switch (selcet)
            {
                case "0":
                    this.Speed += 1;
                    break;
                case "1":
                    this.HP += 5;
                    break;
                case "2":
                    this.ShotSpeed = 100;
                    break;
                case "3":
                    this.Damage += 2;
                    break;
            }
            this.Level += 1;
        }

        //開火
        public virtual void Fire()
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

    //普通人
    class HeroNormal : HeroFather
    {
   
        //建構子 傳入座標 武器編號
        public HeroNormal(int x, int y, int weaponNumber) : base(x, y, weaponNumber, img)
        {
            //玩家基礎數值
            this.Level = 1;//等級
            this.HP = 100;//生命值
         
            GetHeroInfo();
            SetWeaponInfo(weaponNumber);
        }

        //圖片
        private static Image img = Asset.em2;

        //獲得武器類型
    
        //
      
        //--------------事件

        //獲得玩家數值
       public void GetHeroInfo()
        {
            this.HeroSpeed = 2;
            this.HeroDamage = 1;
        }

        public void UseSkill()
        {

        }

        //------------------複寫
        //繪製
       public override void Draw(Graphics g)
        {
            g.DrawImage(img, this.x, this.y);
        }
    }

    //槍俠
    class HeroGunSlinger : HeroFather
    {

        //建構子 傳入座標 武器編號
        public HeroGunSlinger(int x, int y, int weaponNumber) : base(x, y, weaponNumber, img)
        {
            //玩家基礎數值
            this.Level = 1;//等級
            this.HP = 80;//生命值

            GetHeroInfo();
            SetWeaponInfo(weaponNumber);
        }

        //圖片
        private static Image img = Asset.em2;

        //--------------事件

        //獲得玩家數值
        public void GetHeroInfo()
        {
            this.HeroSpeed = 2;
            this.HeroDamage = 1.5;
        }

        public void UseSkill()
        {

        }

        //------------------複寫
        //繪製
        public override void Draw(Graphics g)
        {
            g.DrawImage(img, this.x, this.y);
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


