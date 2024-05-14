using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    class Background : GameObject
    {
        //建構子 座標,攻擊目標，等級，圖片
        public Background(int x, int y) : base(x, y, Img.Width, Img.Height)
        {
        }
        public static Image Img = Asset.Background;

        public override void Draw(Graphics g)
        {
            g.DrawImage(Img, this.x, this.y);
        }
    }
    class MenuBackground : Background
    {
        //建構子 座標,攻擊目標，等級，圖片
        public MenuBackground(int x, int y) : base(x, y)
        {
        }
        public static Image Img = Asset.Menu;

        public override void Draw(Graphics g)
        {
            g.DrawImage(Img, this.x, this.y);
        }


    }

}
