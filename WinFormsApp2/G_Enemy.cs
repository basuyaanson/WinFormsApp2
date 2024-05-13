using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    //敵人
    class B : GameObject
    {
        private static Image img = Asset.em2;
        //建構子 座標,攻擊目標，等級，圖片
        public B(int x, int y, GameObject Target) : base(x, y, img.Width, img.Height)
        {
            this.Target = Target;
        }
        public Image Img = Asset.em1;

        //攻擊目標
        public GameObject Target
        {
            get; set;
        }

        public override void Draw(Graphics g)
        {
            MoveEnemy(5);
            g.DrawImage(img, this.x, this.y);
        }

        //敵人向目標移動
        public void MoveEnemy(double speed)
        {
            //計算向量
            double Dx = Target.x - x;
            double Dy = Target.y - y;

            /*// 計算帶有方向的向量*/
            double length = Math.Sqrt(Dx * Dx + Dy * Dy);
            double UnitX = Dx / length;
            double UnitY = Dy / length;

            //靠近後就停止移動
            if (length > 10)
            {
                // 更新敌人的位置
                this.x += (int)(5 * UnitX);
                this.y += (int)(5 * UnitY);
            }
        }


    }

    //敵人
    /* class EnemyFather : GameObject
     {
         //建構子 座標,攻擊目標，等級，圖片
         public EnemyFather(int x, int y, GameObject Target, int Level, Image img) : base(x, y, img.Width, img.Height, 0, 0, 0, 0)
         {
             this.Target = Target;
             this.Img = img;
         }
         public Image Img = Resource1.em1;

         //敵人等級
         public int HitSroce
         { get; set; }
         public int Number
         { get; set; }
         public int ImgType
         { get; set; }
         public string EnemyNmae { get; set; }

         //攻擊目標
         public GameObject Target
         {
             get; set;
         }

         //死亡
         public virtual void IsDead()
         {
         }

         //敵人向目標移動
         public virtual void MoveEnemy()
         {

         }

         //開火
         public virtual void Fire()
         {

         }

     }*/
}
