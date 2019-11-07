using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemOfSqures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics graphics;
        double[,] x = new double[5,4];
        double[,] y = new double[5,4];

        int[] points = new int[5];

        private void DrawLine(float x1,float y1, float x2,float y2, Pen pen)
        {
            graphics.DrawLine(pen, x1, panel1.Height - y1, x2, panel1.Height - y2);
        }

        private void DeleteLine(float x1,float y1,float x2,float y2)
        {
            graphics.DrawLine(Pens.Silver, x1, panel1.Height - y1, x2, panel1.Height - y2);
        }

        private void DrawPolygon(int o,int op,Pen pen)
        {
            int i, j;

            for (i = 0; i < points[o]; i++)
            {
                j = i + 1;
                if (j == points[o])
                {
                    j = 0;
                }
                if (op == 1)
                {
                    DrawLine((float)x[o, i], (float)y[o, i], (float)x[o, j], (float)y[o, j], pen);
                }else
                {
                    DeleteLine((float)x[o, i], (float)y[o, i], (float)x[o, j], (float)y[o, j]);
                }
                
            }
        }
        private void Translate(int o,int i,double tx,double ty)
        {
            x[o, i] += tx;
            y[o, i] +=ty;
        }  
        private void Rotate(int o,int i,double theta)
        {
            double x1, y1;

            x1 = x[o, i];
            y1 = y[o, i];

            x[o, i] = x1 * Math.Cos(theta) - y1 * Math.Sin(theta);
            y[o, i] = x1 * Math.Sin(theta) + y1 * Math.Cos(theta);
        }

        private void f_rotate(int o,int i,double theta, double x, double y)
        {
            Translate(o, i, -x, -y);
            Rotate(o, i, theta);
            Translate(o, i, x, y);
        }
        private async void run_Click(object sender, EventArgs e)
        {
            await Task.Run(() => runAnimation());
        }


        private void runAnimation()
        {
            int i;
            double x0, y0;
            initialize();
            Vertex centerP = getCenterPoint(0);

            //Console.WriteLine(panel1.Width/2);
            //Console.WriteLine(panel1.Height / 2);
            while (true)
            {
                //f_rotate(0, i, 0.1, centerP.x, centerP.y);
                for (i = 0; i < points[0]; i++)
                {
                    f_rotate(0, i, 0.1, centerP.x, centerP.y);
                    f_rotate(1, i, 0.1, centerP.x, centerP.y);
                    f_rotate(2, i, 0.1, centerP.x, centerP.y);
                    f_rotate(3, i, 0.1, centerP.x, centerP.y);
                    f_rotate(4, i, 0.1, centerP.x, centerP.y);
                }
                Vertex centerP1 = getCenterPoint(1);
                Vertex centerP2 = getCenterPoint(2);
                Vertex centerP3 = getCenterPoint(3);
                Vertex centerP4 = getCenterPoint(4);

                for (i = 0; i < points[0]; i++)
                {
                    f_rotate(1, i, 0.5, centerP1.x, centerP1.y);
                    f_rotate(2, i, 0.5, centerP2.x, centerP2.y);
                    f_rotate(3, i, 0.5, centerP3.x, centerP3.y);
                    f_rotate(4, i, 0.5, centerP4.x, centerP4.y);
                }



                DrawPolygon(0, 1, Pens.Red);
                DrawPolygon(1, 1, Pens.Blue);
                DrawPolygon(2, 1, Pens.Blue);
                DrawPolygon(3, 1, Pens.Blue);
                DrawPolygon(4, 1, Pens.Blue);
                System.Threading.Thread.Sleep(100);
                DrawPolygon(0, 0, Pens.Red);
                DrawPolygon(1, 0, Pens.Blue);
                DrawPolygon(2, 0, Pens.Blue);
                DrawPolygon(3, 0, Pens.Blue);
                DrawPolygon(4, 0, Pens.Blue);

            }
            //DrawPolygon(0, 1, Pens.Red);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
        }

        private void initialize()
        {
            int t = 100;
            points[0] = 4;
            x[0, 0] = t;
            y[0, 0] = t;
            x[0, 1] = panel1.Width - t;
            y[0, 1] = t;
            x[0, 2] = panel1.Width - t;
            y[0, 2] = panel1.Height -t;
            x[0, 3] = t;
            y[0, 3] = panel1.Height - t;

            int t1 = 20;
            points[1] = 4;
            x[1, 0] = x[0, 0] + t1;
            y[1, 0] = y[0, 0] - t1;
            x[1, 1] = x[0, 0] + t1;
            y[1, 1] = y[0, 0] + t1;
            x[1, 2] = x[0, 0] - t1;
            y[1, 2] = y[0, 0] + t1;
            x[1, 3] = x[0, 0] - t1;
            y[1, 3] = y[0, 0] - t1;

            points[2] = 4;
            x[2, 0] = x[0, 1] + t1;
            y[2, 0] = y[0, 1] - t1;
            x[2, 1] = x[0, 1] + t1;
            y[2, 1] = y[0, 1] + t1;
            x[2, 2] = x[0, 1] - t1;
            y[2, 2] = y[0, 1] + t1;
            x[2, 3] = x[0, 1] - t1;
            y[2, 3] = y[0, 1] - t1;

            points[3] = 4;
            x[3, 0] = x[0, 2] + t1;
            y[3, 0] = y[0, 2] - t1;
            x[3, 1] = x[0, 2] + t1;
            y[3, 1] = y[0, 2] + t1;
            x[3, 2] = x[0, 2] - t1;
            y[3, 2] = y[0, 2] + t1;
            x[3, 3] = x[0, 2] - t1;
            y[3, 3] = y[0, 2] - t1;

            points[4] = 4;
            x[4, 0] = x[0, 3] + t1;
            y[4, 0] = y[0, 3] - t1;
            x[4, 1] = x[0, 3] + t1;
            y[4, 1] = y[0, 3] + t1;
            x[4, 2] = x[0, 3] - t1;
            y[4, 2] = y[0, 3] + t1;
            x[4, 3] = x[0, 3] - t1;
            y[4, 3] = y[0, 3] - t1;



        }

        private Vertex getCenterPoint(int o)
        {
            Vertex c = new Vertex(0,0);
            for(int i = 0; i < points[0]; i++)
            {
                c.x += x[o, i];
                c.y += y[o, i];
            }
            c.x /= points[0];
            c.y /= points[0];

            return c;
        }
    }

    class Vertex
    {
        public double x;
        public double y;

        public Vertex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void setX(double x)
        {
            this.x = x;
        }
        public void setY(double y)
        {
            this.y = y;
        }
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
      
    }
}
