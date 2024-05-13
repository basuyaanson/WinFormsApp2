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
        public int Damage
        { get; set; }
        public int Level
        { get; set; }


        //繪製事件
        public virtual void Draw(Graphics g)
        {
        }
    }
}
