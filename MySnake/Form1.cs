using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySnake
{
    public partial class Form1 : Form
    {
        Graphics G;
        Snake snk;
        public Form1()
        {
            InitializeComponent();
        }
        
        //绘制画布布局
        public void setGamePaint(Graphics gp,int width,int height,int unitlen)
        {
            for (int i = 0; i < width/unitlen; i++)     //画竖线
            {
                gp.DrawLine(new Pen(Color.LightGreen, 1), new Point(i * unitlen, 0), new Point(i * unitlen, height));
            }

            for (int i = 0; i < height / unitlen; i++)     //画横线
            {
                gp.DrawLine(new Pen(Color.LightGreen, 1),new Point(0,i * unitlen),new Point(width,i * unitlen));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightSlateGray;
            G = panel1.CreateGraphics();//创建panel1控件的Graphics类
            //G.Clear(Color.Orange);

            snk = new Snake(G, 10);
            snk.setFood(G, 10);
            setGamePaint(G, panel1.Width, panel1.Height, 10);

            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Pen pen1 = new Pen(Color.Red);//创建红色笔对象
            //SolidBrush brush1 = new SolidBrush(Color.Blue);//创建蓝色刷子对象
            //G.DrawEllipse(pen1, 10, 10, 100, 100);//用红色笔画圆的边界
            //G.FillEllipse(brush1, 10, 10, 100, 100);//用蓝色刷子填充圆的内部
        }

        private void button2_Click(object sender, EventArgs e)
        {
            snk.snakeMove(G, 10, MoveDir.Down);        //重绘蛇身
            setGamePaint(G, panel1.Width, panel1.Height, 10);       //重绘网格
        }

        private void button3_Click(object sender, EventArgs e)
        {
            snk.snakeMove(G, 10, MoveDir.Up);        //重绘蛇身
            setGamePaint(G, panel1.Width, panel1.Height, 10);       //重绘网格
        }

        private void button4_Click(object sender, EventArgs e)
        {
            snk.snakeMove(G, 10, MoveDir.Left);        //重绘蛇身
            setGamePaint(G, panel1.Width, panel1.Height, 10);       //重绘网格
        }

        private void button5_Click(object sender, EventArgs e)
        {
            snk.snakeMove(G, 10, MoveDir.Right);        //重绘蛇身
            setGamePaint(G, panel1.Width, panel1.Height, 10);       //重绘网格
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            snk.snakeMove(G, 10, snk.movedir);        //重绘蛇身
            setGamePaint(G, panel1.Width, panel1.Height, 10);       //重绘网格
        }

        

        
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    snk.movedir=MoveDir.Left;
                    break;
                case Keys.Right:
                    snk.movedir = MoveDir.Right;
                    break;
                case Keys.Up:
                    snk.movedir = MoveDir.Up;
                    break;
                case Keys.Down:
                    snk.movedir = MoveDir.Down;
                    break;
            }
            return true;
        }

        

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    switch (keyData)
        //    {
        //        case Keys.Left:
        //            snk.movedir = MoveDir.Left;
        //            break;
        //        case Keys.Right:
        //            snk.movedir = MoveDir.Right;
        //            break;
        //        case Keys.Up:
        //            snk.movedir = MoveDir.Up;
        //            break;
        //        case Keys.Down:
        //            snk.movedir = MoveDir.Down;
        //            break;
        //    }
        //    return true;
        //    //if (keyData == Keys.Up)
        //    //{
        //    //    MessageBox.Show("up key pressed");
        //    //    return true;
        //    //}
        //    //else if (keyData == Keys.Left)
        //    //{
        //    //    MessageBox.Show("Left key pressed");
        //    //    return true;
        //    //}
        //    //else if (keyData == Keys.Right)
        //    //{
        //    //    MessageBox.Show("Right key pressed");
        //    //    return true;
        //    //}
        //    //else if (keyData == Keys.Down)
        //    //{
        //    //    MessageBox.Show("Down key pressed");
        //    //    return true;
        //    //}
        //    //return base.ProcessCmdKey(ref msg, keyData);
        //} 
    }
}
