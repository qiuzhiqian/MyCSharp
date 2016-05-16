using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySnake
{
    enum MoveDir { Up = 1, Down = 2, Left = 3, Right = 4 };
    class Snake
    {
        

        public List<Point> snakepos = new List<Point>();        //蛇身坐标
        public Point foodPoint=new Point();                     //食物坐标
        public MoveDir movedir = MoveDir.Down;                  //运动方向
        
        //, new Point(0, 1), new Point(1, 1), new Point(2, 1), new Point(2, 2)
        public Snake(Graphics gp, int unitlen)
        {
            snakepos.Add(new Point(0, 0));
            snakepos.Add(new Point(0, 1));
            snakepos.Add(new Point(1, 1));
            snakepos.Add(new Point(2, 1));
            snakepos.Add(new Point(2, 2));
            setSnakeBody(gp, snakepos, unitlen);
        }

        public void setSnakeBody(Graphics gp, List<Point> pos, int unitlen)
        {
            for (int i = 0; i < pos.Count; i++)
            {
                setRectColor(gp, pos[i], unitlen, Color.Blue);
            }
        }

        public void setFood(Graphics gp, int unitlen)
        {
            foodPoint.X = 5;
            foodPoint.Y = 6;
            setRectColor(gp, foodPoint, unitlen, Color.Red);
        }

        public void setRectColor(Graphics gp,Point rctpoint,int unitlen,Color clr)
        {
            Rectangle rtg = new Rectangle();

            //Pen pen1 = new Pen(Color.Red,3);//创建红色笔对象,Color.LightGreen
            SolidBrush brush1 = new SolidBrush(clr);//创建蓝色刷子对象
            rtg.X = rctpoint.X * unitlen;
            rtg.Y = rctpoint.Y * unitlen;
            rtg.Width = unitlen;
            rtg.Height = unitlen;
            //gp.DrawRectangle(pen1, rtg);
            gp.FillRectangle(brush1, rtg);
        }

        public void snakeMove(Graphics gp, int unitlen,MoveDir dir)
        {
            Point addpt;
            switch (dir)
            {
                case MoveDir.Up:
                    {
                        addpt = new Point(snakepos[snakepos.Count - 1].X, snakepos[snakepos.Count - 1].Y - 1);
                        break;
                    }
                case MoveDir.Down:
                    {
                        addpt = new Point(snakepos[snakepos.Count - 1].X, snakepos[snakepos.Count - 1].Y + 1);
                        break;
                    }
                case MoveDir.Left:
                    {
                        addpt = new Point(snakepos[snakepos.Count - 1].X - 1, snakepos[snakepos.Count - 1].Y);
                        break;
                    }
                case MoveDir.Right:
                    {
                        addpt = new Point(snakepos[snakepos.Count - 1].X + 1, snakepos[snakepos.Count - 1].Y);
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            setRectColor(gp, snakepos[0], unitlen, Color.LightSlateGray);
            snakepos.RemoveAt(0);
            snakepos.Add(addpt);
            setSnakeBody(gp, snakepos, unitlen);
        }
    }
}
