using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        double [,] x = new double [3,4];
        double [,] y = new double [3,4];
        int[] points = new int[3];
        float r, theta;
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawLine(float x1,float y1,float x2,float y2)
        {
            graphics.DrawLine(Pens.Black, x1, panel1.Height - y1, x2, panel1.Height - y2);

        }

        private void DeleteLine(float x1,float y1,float x2,float y2)
        {
            graphics.DrawLine(Pens.White, x1, panel1.Height - y1, x2, panel1.Height - y2);
        }

        private void DrawCircle(float xc, float yc, float r)
        {
            float x1, y1, w;
            x1 = xc - r;
            y1 = yc + r;
            w = 2 * r;
            graphics.DrawEllipse(Pens.Black, x1, panel1.Height - y1, w, w);
        }

        private void DrawPolygon(int o)
        {
            int i, j;
            for (i = 0; i < points[o]; i++)
            {
                j = i + 1;
                if (j == points[o])
                {
                    j = 0;  
                }
                DrawLine((float)x[o, i], (float)y[o, i], (float)x[o, j], (float)y[o, j]);
            }
        }
        private void DeletePolygon(int o)
        {
            int i, j;
            for (i = 0; i < points[o]; i++)
            {
                j = i + 1;
                if (j == points[o])
                {
                    j = 0;
                }
                DeleteLine((float)x[o, i], (float)y[o, i], (float)x[o, j], (float)y[o, j]);
            }
        }

        private void FillPolygon(int id,PointF[] poly)
        {
            if (id == 1)
            {
                graphics.FillPolygon(Brushes.Red, poly);
            }
            else
            {
                graphics.FillPolygon(Brushes.White, poly);
            }
            
        }

        private void Translate(int o, int i,double tx,double ty)
        {
            x[o, i] += tx;
            y[o, i] += ty;
        }

        private void Rotate(int o,int i,double theta)
        {
            double x1, y1;

            x1 = x[o, i];
            y1 = y[o, i];
            x[o, i] = x1 * Math.Cos(theta) - y1 * Math.Sin(theta);
            y[o, i] = x1 * Math.Sin(theta) + y1 * Math.Cos(theta);
        }

        private PointF[] getPolygon(int o)
        {
            PointF[] poly = new PointF[points[o]];

            for (int i = 0; i < points[o]; i++)
            {
                poly[i] = new PointF();
                poly[i].X =(float) x[o, i];
                poly[i].Y = (float)y[o, i];
            }
            return poly;
        }
        private void initialize()
        {
            r = 150;

            points[0] = 3;
            x[0, 0] = panel1.Width / 2 + r;
            y[0, 0] = panel1.Height / 2;
            x[0, 1] = panel1.Width / 2 - 5;
            y[0, 1] = panel1.Height / 2 - 5;
            x[0, 2] = panel1.Width / 2 - 5;
            y[0, 2] = panel1.Height / 2 + 5;

            points[1] = 3;
            x[1, 0] = panel1.Width / 2 + r - 50;
            y[1, 0] = panel1.Height / 2;
            x[1, 1] = panel1.Width / 2 - 5;
            y[1, 1] = panel1.Height / 2 - 5;
            x[1, 2] = panel1.Width / 2 - 5;
            y[1, 2] = panel1.Height / 2 + 5;

            points[2] = 3;
            x[2, 0] = panel1.Width / 2 + r - 80;
            y[2, 0] = panel1.Height / 2;
            x[2, 1] = panel1.Width / 2 - 5;
            y[2, 1] = panel1.Height / 2 - 5;
            x[2, 2] = panel1.Width / 2 - 5;
            y[2, 2] = panel1.Height / 2 + 5;

        }
        private void f_rotate(int o,int i,double t,int x,int y)
        {
            Translate(o, i, -x, -y);
            Rotate(o, i, t);
            Translate(o, i, x, y);
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            int i;
            double x0, y0;
            initialize();

            while (true)
            {
                for (i = 0; i < points[0]; i++)
                {
                    f_rotate(0, i, -0.1, panel1.Width / 2, panel1.Height / 2);
                    f_rotate(1, i, -0.01, panel1.Width / 2, panel1.Height / 2);
                    f_rotate(2, i, -0.001, panel1.Width / 2, panel1.Height / 2);
                }

                DrawPolygon(0);
                //FillPolygon(1,getPolygon(0));
                DrawPolygon(1);

                DrawPolygon(2);
                //FillPolygon(1,getPolygon(1));
                DrawCircle(panel1.Width / 2, panel1.Height / 2, r);
                System.Threading.Thread.Sleep(1000);
                DeletePolygon(0);
                //FillPolygon(0,getPolygon(0));
                DeletePolygon(1);
                //FillPolygon(0,getPolygon(1));
                DeletePolygon(2);
                
                //FillPolygon(1,getPolygon(0));
                

            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
        }
    }

    class Vertex
    {
        private double x, y;

        public Vertex(double x, double y)
        {
            this.x = x;
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

        public void Translate(double tx, double ty)
        {
            x += tx;
            y += ty;
        }

        public void Rotate(double theta)
        {
            double x1 = x;
            double y1 = y;

            x = x1 * Math.Cos(theta) - Math.Sin(theta);
            y = y1 * Math.Sin(theta) + Math.Cos(theta);
        }
    }
}
