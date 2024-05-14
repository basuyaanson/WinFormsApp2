using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    class SingleObject
    {
        //建構子
        private static SingleObject _single = null;
        private SingleObject()
        {
        }

        //獲取對象
        public static SingleObject GetSingle()
        {
            if (_single == null)
            {
                _single = new SingleObject();
            }
            return _single;
        }
        //-------獲取遊戲對象
        //獲取鼠標
        public List<Background> BackG = new List<Background>();
        //獲取鼠標
        public Aim Aim
        {
            get; set;
        }
       
        //獲取玩家對象
        public HeroFather Hero
        {
            get; set;
        }
        
        //獲取武器對象
        public WeaponFater Wp
        {
            get; set;
        }


        //獲取玩家子彈
        public List<WeaponFater> HeroBulletList = new List<WeaponFater>();

        //獲取敵人對象
        public List<EnemyFather> EnemyList = new List<EnemyFather>();


        //-----------------------事件

        //添加對象
        public void AddGameObject(GameObject go)
        {
            //找到相同的類別
            if (go is HeroFather)
            {
                this.Hero = go as HeroFather;
            }
            else if (go is EnemyFather)
            {
                this.EnemyList.Add (go as EnemyFather);
            }
            else if (go is Aim)
            {
                this.Aim = go as Aim;
            }
            else if (go is WeaponFater)
            {
                this.HeroBulletList.Add(go as WeaponFater);
            }
            else if (go is Background)
            {
                this.BackG.Add(go as Background);
               
            }
        }

        //繪製對象
        public void DrawGameObject(Graphics g)
        {
            collision();//碰撞
            this.Hero.Draw(g);//玩家
            //玩家子彈
            for (int i = 0; i < HeroBulletList.Count; i++)
            {
                HeroBulletList[i].Draw(g);
            }
            //敵人
            for (int i = 0; i < EnemyList.Count; i++)
            {
                EnemyList[i].Draw(g);
            }
        }

        public void DrawBK(Graphics g)
        {
            for (int i = 0; i < BackG.Count; i++)
            {
                BackG[i].Draw(g);
            }
        }

        //刪除對象
        public void RemoveGameObject(GameObject go)
        {
            if (go is EnemyFather)
            {
                EnemyList.Remove(go as EnemyFather);
            }
            else if (go is WeaponFater)
            {
                HeroBulletList.Remove(go as WeaponFater);
            }
            else if (go is Background)
            {
                BackG.Remove(go as Background);
            }

            /* else if (go is EnemyFather)
             {
                  EnemyBulletList.Remove(go as EnemyBullet);
             }*/

        }

        //碰撞體
        public void collision()
        {
          //檢查 敵人 
            for (int i = 0; i < EnemyList.Count; i++)
            {
                 //與 玩家碰撞
               if (EnemyList[i].GetRectangle().IntersectsWith(Hero.GetRectangle()))
                 {
                        Hero.HP -= EnemyList[i].Damage;//命中扣血
                        Hero.IsDead();//檢測生命值
                        SingleObject.GetSingle().RemoveGameObject(EnemyList[i]);//刪除敵人
                        break;
                 }
                //與 玩家子彈碰撞
                for (int j = 0; j < HeroBulletList.Count; j++)
                {
                    if (EnemyList[i].GetRectangle().IntersectsWith(HeroBulletList[j].GetRectangle()))//如果子彈的矩形與目標相交
                    {
                        EnemyList[i].HP -= Hero.Damage;//命中扣血
                        EnemyList[i].IsDead();//檢測生命值
                        SingleObject.GetSingle().RemoveGameObject(HeroBulletList[j]);//刪除子彈
                        break;
                    }
                }
            }
        }
    }
}
