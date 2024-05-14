using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    enum WeaponType
    {
        手槍, 步槍
    }

    //武器父類
    class WeaponFater : GameObject
    {
        //建構子 子彈座標，發射速度，
        public WeaponFater(int x, int y, Image Img) : base(x, y, Img.Width, Img.Height)
        {
            this.Time = 0;
        }
        public WeaponType WPName;
        //圖片
        private Image Img;
        //射擊目標
        public int TargetX
        {
            get; set;
        }
        public int TargetY
        {
            get;
            set;
        }
        public double unitX
        {
            get;
            set;
        }
        public double unitY
        {
            get;
            set;
        }

        //數值
        public int MoveSpeed
        { get; set; }//持有武器速度
        public int ShotSpeed//射速
        { get; set; }

        public int Time
        {
            get; set;
        }
        //移動事件
        public virtual void Move()
        {

        }

        public virtual void GetInfo()
        {

        }
    }

    class WP_Pistol : WeaponFater
    {
        //圖片
        private static Image img = Asset.bullet1;

        //目標座標 發射座標 子彈移動速度
        public WP_Pistol(int TargetX, int TargetY, int x, int y) : base(x, y, img)
        {
            this.TargetX = TargetX;
            this.TargetY = TargetY;
            GetInfo();
        }

        //基礎數值
        public override void GetInfo()
        {
            //名稱
            WPName = WeaponType.手槍;
            //武器數值
            this.Damage = 17;//傷害
            this.ShotSpeed = 500;//射速
            this.Speed = 50;//子彈移動速度
            this.MoveSpeed = 4;//玩家持移速加成
        }

        //------------------------
        public override void Draw(Graphics g)
        {
            Move();
            g.DrawImage(img, this.x, this.y);
        }

        //子彈移動
        public override void Move()
        {
            //計算向量
            if (Time == 0)
            {
                int dx = this.TargetX - this.x;
                int dy = this.TargetY - this.y;
                double length = Math.Sqrt(dx * dx + dy * dy);

                this.unitX = dx / length;
                this.unitY = dy / length;
                this.Time = 1;
            }

            // 更新敌人的位置
            this.x += (int)(this.Speed * this.unitX);
            this.y += (int)(this.Speed * this.unitY);
        }
    }

    class WP_Rifle : WeaponFater
    {
        //圖片
        private static Image img = Asset.bullet1;

        //目標座標 發射座標 子彈移動速度
        public WP_Rifle(int TargetX, int TargetY, int x, int y) : base(x, y, img)
        {
            this.TargetX = TargetX;
            this.TargetY = TargetY;
            GetInfo();
        }

        public override void GetInfo()
        {
            //名稱
            WPName = WeaponType.步槍;
            //武器數值
            this.Damage = 31;//傷害
            this.ShotSpeed = 400;//射速
            this.Speed = 50;//子彈移動速度
            this.MoveSpeed = 3;//玩家持有移速加成
        }


        //------------------------
        public override void Draw(Graphics g)
        {
            Move();
            g.DrawImage(img, this.x, this.y);
        }

        //子彈移動
        public override void Move()
        {
            //計算向量
            if (Time == 0)
            {
                int dx = this.TargetX - this.x;
                int dy = this.TargetY - this.y;
                double length = Math.Sqrt(dx * dx + dy * dy);

                this.unitX = dx / length;
                this.unitY = dy / length;
                this.Time = 1;
            }

            // 更新敌人的位置
            this.x += (int)(this.Speed * this.unitX);
            this.y += (int)(this.Speed * this.unitY);
        }

    }

}
