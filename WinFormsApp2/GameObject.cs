using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    class GameObject
    {
        //建構子  座標,長寬,速度,血量
        public GameObject(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.Width = width;
            this.Height = height;
        }
        public GameObject(int x, int yt)
        {
            this.x = x;
            this.y = y;
        }

        //遊戲中的座標
        public int x
        {
            get; set;
        }
        public int y
        {
            get;
            set;
        }

        //物件的大小
        public int Width
        {
            get;
            set;
        }
        public int Height
        {
            get;
            set;
        }

        //基礎數值
        public double Speed
        {
            get; set;
        }
        public double HP
        {
            get;
            set;
        }
        public double Damage
        { get; set; }
        public int Level
        { get; set; }
        public double ShotSpeed
        { get; set; }
        public int Number
        { get; set; }
        public int Score
        { get; set; }


        //繪製事件
        public virtual void Draw(Graphics g)
        {
        }

        //碰撞檢測
        public Rectangle GetRectangle()
        {
            return new Rectangle(this.x, this.y, this.Width, this.Height);
        }
    }
}
