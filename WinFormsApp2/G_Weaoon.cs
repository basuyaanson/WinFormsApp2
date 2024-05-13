using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    //子彈父類
  class WeaponFater : GameObject
    {

        //建構子
        public WeaponFater(int x, int y, int speed, Image Img) : base(x, y, Img.Width, Img.Height)
        {
            this.time = 0;
        }

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

        public int time
        {
            get; set;
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
        private Image Img;

        //移動事件
        public virtual void Move()
        {

        }
    }

    //玩家子彈
    class HeroBullet : WeaponFater
    {
        private static Image img = Asset.bullet1;

        public HeroBullet(int TargetX, int TargetY, int x, int y, int speed) : base(x, y, speed, img)
        {
            this.TargetX = TargetX;
            this.TargetY = TargetY;
            this.Speed = speed;
        }

        public override void Draw(Graphics g)
        {
            Move();
            g.DrawImage(img, this.x, this.y);
        }


        //子彈移動
        public override void Move()
        {
            if (time == 0)
            {
                //計算向量
                int dx = this.TargetX - this.x;
                int dy = this.TargetY - this.y;

                double length = Math.Sqrt(dx * dx + dy * dy);
                this.unitX = dx / length;
                this.unitY = dy / length;
                this.time = 1;
            }
            // 更新敌人的位置
            this.x += (int)(this.Speed * this.unitX);
            this.y += (int)(this.Speed * this.unitY);
        }

    }
}
