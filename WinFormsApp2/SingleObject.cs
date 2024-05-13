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

        public WeaponFater Wp
        {
            get; set;
        }

        //獲取玩家對象
        public Hero Hero
        {
            get; set;
        }

        //獲取敵人對象
        public B Bb
        {
            get; set;
        }

        //-----------------------事件

        //添加對象
        public void AddGameObject(GameObject go)
        {
            //找到相同的類別
            if (go is Hero)
            {
                this.Hero = go as Hero;
            }
            else if (go is B)
            {
                this.Bb = go as B;
            }
            else if (go is WeaponFater)
            {
                this.Wp = go as WeaponFater;
            }
        }

        //繪製對象
        public void DrwaGameObject(Graphics g)
        {
            this.Hero.Draw(g);
            this.Bb.Draw(g);
        }

        //刪除對象
        public void RemoveGameObject(GameObject go)
        {
          /*if (go is EnemyFather)
            {
                EnemyList.Remove(go as EnemyFather);
            }
            else if (go is HeroBullet)
            {
                HeroBulletList.Remove(go as HeroBullet);
            }
            /* else if (go is EnemyBullet)
             {
                 EnemyBulletList.Remove(go as EnemyBullet);
             }*/

        }

        //碰撞體
        public void collision()
        {
          /*  //檢查 敵人 
            for (int i = 0; i < EnemyList.Count; i++)
            {
                /*  //與 玩家碰撞
                   if (EnemyList[i].GetRectangle().IntersectsWith(H.GetRectangle()))
                   {
                       H.hp -= EnemyList[i].Damage;//命中扣血
                       EnemyList[i].IsDead();//檢測生命值
                       SingleObject.GetSingle().EnemyList.Remove(EnemyList[i]);
                       break;
                   }
                //與 玩家子彈碰撞
                for (int j = 0; j < HeroBulletList.Count; j++)
                {
                    if (EnemyList[i].GetRectangle().IntersectsWith(HeroBulletList[j].GetRectangle()))//如果子彈的矩形與目標相交
                    {
                        EnemyList[i].hp -= H.Damage;//命中扣血
                        EnemyList[i].IsDead();//檢測生命值
                        SingleObject.GetSingle().HeroBulletList.Remove(HeroBulletList[j]);//刪除子彈
                        break;
                    }
                }
            }*/
        }
    }
}
