using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotationQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float r, t;

        double[,] x = new double[2, 4];
        double[,] y = new double[2, 4];
        int[] points = new int[2];

        private void DisplayLine(float x1, float y1, float x2, float y2)
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(Pens.Black, x1, panel1.Height - y1, x2, panel1.Height - y2);
        }

        private void DeleteLine(float x1, float y1, float x2, float y2)
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(Pens.White, x1, panel1.Height - y1, x2, panel1.Height - y2);
        }

        private void DrawCircle(float xc, float yc, float r)
        {
            float x1, y1, w;
            Graphics g = panel1.CreateGraphics();
            x1 = xc - r;
            y1 = yc + r;
            w = 2 * r;
            g.DrawEllipse(Pens.Red, x1, panel1.Height - y1, w, w);
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
                DisplayLine((float)x[o, i], (float)y[o, i], (float)x[o, j], (float)y[o, j]);
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

        private void Initialize()
        {
            r = 150;
            t = 50;

            points[0] = 4;
            x[0, 0] = panel1.Width / 2 + r - t;
            y[0, 0] = panel1.Height / 2 - t;
            x[0, 1] = panel1.Width / 2 + r + t;
            y[0, 1] = panel1.Height / 2 - t;
            x[0, 2] = panel1.Width / 2 + r + t;
            y[0, 2] = panel1.Height / 2 + t;
            x[0, 3] = panel1.Width / 2 + r - t;
            y[0, 3] = panel1.Height / 2 + t;

            points[1] = 4;
            x[1, 0] = panel1.Width / 2 + r - t / 2;
            y[1, 0] = panel1.Height / 2 - t / 2;
            x[1, 1] = panel1.Width / 2 + r + t / 2;
            y[1, 1] = panel1.Height / 2 - t / 2;
            x[1, 2] = panel1.Width / 2 + r + t / 2;
            y[1, 2] = panel1.Height / 2 + t / 2;
            x[1, 3] = panel1.Width / 2 + r - t / 2;
            y[1, 3] = panel1.Height / 2 + t / 2;
        }

        void traslate(int o, int i, double tx, double ty)
        {
            x[o, i] += tx;
            y[o, i] += ty;
        }

        void rotate(int o, int i, double t)
        {
            double x1, y1;

            x1 = x[o, i];
            y1 = y[o, i];
            x[o, i] = x1 * Math.Cos(t) - y1 * Math.Sin(t);
            y[o, i] = x1 * Math.Sin(t) + y1 * Math.Cos(t);
        }

        void f_rotate(int o, int i, double t, double x, double y)
        {
            traslate(o, i, -x, -y);
            rotate(o, i, t);
            traslate(o, i, x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            double x0, y0;

            Initialize();

            while (true)
            {
                for (i = 0; i < points[0]; i++)
                {
                    f_rotate(0, i, 0.01, panel1.Width / 2, panel1.Height / 2);
                    f_rotate(1, i, 0.01, panel1.Width / 2, panel1.Height / 2);
                }

                x0 = (x[0, 0] + x[0, 1] + x[0, 2] + x[0, 3]) / 4;
                y0 = (y[0, 0] + y[0, 1] + y[0, 2] + y[0, 3]) / 4;

                for (i = 0; i < points[0]; i++)
                {
                    f_rotate(0, i, 0.1, x0, y0);
                    f_rotate(1, i, -0.1, x0, y0);
                }

                DrawPolygon(0);
                DrawPolygon(1);
                DrawCircle(panel1.Width / 2, panel1.Height / 2, r);
                System.Threading.Thread.Sleep(100);
                DeletePolygon(0);
                DeletePolygon(1);
                DrawCircle(panel1.Width / 2, panel1.Height / 2, r);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}