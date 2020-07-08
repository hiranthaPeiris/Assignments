using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotate
{
    public partial class Form1 : Form
    {
        float r,t,r1,t1;

        double[,] x = new double[14,6];
        double[,] y = new double[14,6];
        int[] points=new int[14];

        public Form1()
        {
            InitializeComponent();
        }

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
                DisplayLine((float)x[o,i], (float)y[o,i], (float)x[o,j], (float)y[o,j]);
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
            r = 200;
            t = 40;

            r1 = 100;
            t1 = 30;

            points[0] = 6;
            x[0, 0] = panel1.Width/2 + r;
            y[0, 0] = panel1.Height / 2;
            x[0, 1] = panel1.Width / 2 + r/2 ;
            y[0, 1] = panel1.Height / 2 + r*0.8660254037844;
            x[0, 2] = panel1.Width / 2 - r/2;
            y[0, 2] = panel1.Height / 2 + r* 0.8660254037844;
            x[0, 3] = panel1.Width / 2 - r ;
            y[0, 3] = panel1.Height / 2 ;
            x[0, 4] = panel1.Width / 2 - r/2;
            y[0, 4] = panel1.Height / 2 - r* 0.8660254037844;
            x[0, 5] = panel1.Width / 2 + r / 2;
            y[0, 5] = panel1.Height / 2 - r * 0.8660254037844;

            points[1] = 6;
            x[1, 0] = panel1.Width / 2 + r + t;
            y[1, 0] = panel1.Height / 2;
            x[1, 1] = panel1.Width / 2 + r + t / 2;
            y[1, 1] = panel1.Height / 2 + t * 0.8660254037844;
            x[1, 2] = panel1.Width / 2  +r - t / 2;
            y[1, 2] = panel1.Height / 2 + t * 0.8660254037844;
            x[1, 3] = panel1.Width / 2 + r - t;
            y[1, 3] = panel1.Height / 2;
            x[1, 4] = panel1.Width / 2 + r + -t / 2;
            y[1, 4] = panel1.Height / 2 - t * 0.8660254037844;
            x[1, 5] = panel1.Width / 2 + r + t / 2;
            y[1, 5] = panel1.Height / 2 - t * 0.8660254037844;

            points[2] = 6;
            x[2, 0] = panel1.Width / 2 + r/2 + t;
            y[2, 0] = panel1.Height / 2 + r*0.8660254037844;
            x[2, 1] = panel1.Width / 2 + r/2 + t / 2;
            y[2, 1] = panel1.Height / 2 + t * 0.8660254037844 + r * 0.8660254037844;
            x[2, 2] = panel1.Width / 2 + r/2 + -t / 2;
            y[2, 2] = panel1.Height / 2 + t * 0.8660254037844+ r * 0.8660254037844;
            x[2, 3] = panel1.Width / 2 + r/2 - t;
            y[2, 3] = panel1.Height / 2 + r * 0.8660254037844;
            x[2, 4] = panel1.Width / 2 + r/2 -t / 2;
            y[2, 4] = panel1.Height / 2 - t * 0.8660254037844+ r * 0.8660254037844;
            x[2, 5] = panel1.Width / 2 + r/2 + t / 2;
            y[2, 5] = panel1.Height / 2 - t * 0.8660254037844 + r * 0.8660254037844;


            points[3] = 6;
            x[3, 0] = panel1.Width / 2 - r / 2 + t;
            y[3, 0] = panel1.Height / 2 + r * 0.8660254037844;
            x[3, 1] = panel1.Width / 2 - r / 2 + t / 2;
            y[3, 1] = panel1.Height / 2 + t * 0.8660254037844 + r * 0.8660254037844;
            x[3, 2] = panel1.Width / 2 - r / 2 -t / 2;
            y[3, 2] = panel1.Height / 2 + t * 0.8660254037844 + r * 0.8660254037844;
            x[3, 3] = panel1.Width / 2 - r / 2 - t;
            y[3, 3] = panel1.Height / 2 + r * 0.8660254037844;
            x[3, 4] = panel1.Width / 2 - r / 2 -t / 2;
            y[3, 4] = panel1.Height / 2 - t * 0.8660254037844 + r * 0.8660254037844;
            x[3, 5] = panel1.Width / 2 - r / 2 + t / 2;
            y[3, 5] = panel1.Height / 2 - t * 0.8660254037844 + r * 0.8660254037844;

            points[4] = 6;
            x[4, 0] = panel1.Width / 2 - r + t;
            y[4, 0] = panel1.Height / 2;
            x[4, 1] = panel1.Width / 2 - r + t / 2;
            y[4, 1] = panel1.Height / 2 + t * 0.8660254037844;
            x[4, 2] = panel1.Width / 2 - r + -t / 2;
            y[4, 2] = panel1.Height / 2 + t * 0.8660254037844;
            x[4, 3] = panel1.Width / 2 - r - t;
            y[4, 3] = panel1.Height / 2;
            x[4, 4] = panel1.Width / 2 - r + -t / 2;
            y[4, 4] = panel1.Height / 2 - t * 0.8660254037844;
            x[4, 5] = panel1.Width / 2 - r + t / 2;
            y[4, 5] = panel1.Height / 2 - t * 0.8660254037844;

            points[5] = 6;
            x[5, 0] = panel1.Width / 2 - r / 2 + t;
            y[5, 0] = panel1.Height / 2 - r * 0.8660254037844;
            x[5, 1] = panel1.Width / 2 - r / 2 + t / 2;
            y[5, 1] = panel1.Height / 2 + t * 0.8660254037844 - r * 0.8660254037844;
            x[5, 2] = panel1.Width / 2 - r / 2 - t / 2;
            y[5, 2] = panel1.Height / 2 + t * 0.8660254037844 - r * 0.8660254037844;
            x[5, 3] = panel1.Width / 2 - r / 2 - t;
            y[5, 3] = panel1.Height / 2 - r * 0.8660254037844;
            x[5, 4] = panel1.Width / 2 - r / 2 - t / 2;
            y[5, 4] = panel1.Height / 2 - t * 0.8660254037844 - r * 0.8660254037844;
            x[5, 5] = panel1.Width / 2 - r / 2 + t / 2;
            y[5, 5] = panel1.Height / 2 - t * 0.8660254037844 - r * 0.8660254037844;

            points[6] = 6;
            x[6, 0] = panel1.Width / 2 + r / 2 + t;
            y[6, 0] = panel1.Height / 2 - r * 0.8660254037844;
            x[6, 1] = panel1.Width / 2 + r / 2 + t / 2;
            y[6, 1] = panel1.Height / 2 + t * 0.8660254037844 - r * 0.8660254037844;
            x[6, 2] = panel1.Width / 2 + r / 2 + -t / 2;
            y[6, 2] = panel1.Height / 2 + t * 0.8660254037844 - r * 0.8660254037844;
            x[6, 3] = panel1.Width / 2 + r / 2 - t;
            y[6, 3] = panel1.Height / 2 - r * 0.8660254037844;
            x[6, 4] = panel1.Width / 2 + r / 2 - t / 2;
            y[6, 4] = panel1.Height / 2 - t * 0.8660254037844 - r * 0.8660254037844;
            x[6, 5] = panel1.Width / 2 + r / 2 + t / 2;
            y[6, 5] = panel1.Height / 2 - t * 0.8660254037844 - r * 0.8660254037844;


            ///////////////////////////////////////////////////////////////////////

            points[7] = 6;
            x[7, 0] = panel1.Width / 2 + r1;
            y[7, 0] = panel1.Height / 2;
            x[7, 1] = panel1.Width / 2 + r1 / 2;
            y[7, 1] = panel1.Height / 2 + r1 * 0.8660254037844;
            x[7, 2] = panel1.Width / 2 - r1 / 2;
            y[7, 2] = panel1.Height / 2 + r1 * 0.8660254037844;
            x[7, 3] = panel1.Width / 2 - r1;
            y[7, 3] = panel1.Height / 2;
            x[7, 4] = panel1.Width / 2 - r1 / 2;
            y[7, 4] = panel1.Height / 2 - r1 * 0.8660254037844;
            x[7, 5] = panel1.Width / 2 + r1 / 2;
            y[7, 5] = panel1.Height / 2 - r1 * 0.8660254037844;
        
            points[8] = 6;
            x[8, 0] = panel1.Width / 2 + r1 + t1;
            y[8, 0] = panel1.Height / 2;
            x[8, 1] = panel1.Width / 2 + r1 + t1 / 2;
            y[8, 1] = panel1.Height / 2 + t1 * 0.8660254037844;
            x[8, 2] = panel1.Width / 2 + r1 + -t1 / 2;
            y[8, 2] = panel1.Height / 2 + t1 * 0.8660254037844;
            x[8, 3] = panel1.Width / 2 + r1 - t1;
            y[8, 3] = panel1.Height / 2;
            x[8, 4] = panel1.Width / 2 + r1 + -t1 / 2;
            y[8, 4] = panel1.Height / 2 - t1 * 0.8660254037844;
            x[8, 5] = panel1.Width / 2 + r1 + t1 / 2;
            y[8, 5] = panel1.Height / 2 - t1 * 0.8660254037844;

            points[9] = 6;
            x[9, 0] = panel1.Width / 2 + r1 / 2 + t1;
            y[9, 0] = panel1.Height / 2 + r1 * 0.8660254037844;
            x[9, 1] = panel1.Width / 2 + r1 / 2 + t1 / 2;
            y[9, 1] = panel1.Height / 2 + t1 * 0.8660254037844 + r1 * 0.8660254037844;
            x[9, 2] = panel1.Width / 2 + r1 / 2 + -t1 / 2;
            y[9, 2] = panel1.Height / 2 + t1 * 0.8660254037844 + r1 * 0.8660254037844;
            x[9, 3] = panel1.Width / 2 + r1 / 2 - t1;
            y[9, 3] = panel1.Height / 2 + r1 * 0.8660254037844;
            x[9, 4] = panel1.Width / 2 + r1 / 2 - t1 / 2;
            y[9, 4] = panel1.Height / 2 - t1 * 0.8660254037844 + r1 * 0.8660254037844;
            x[9, 5] = panel1.Width / 2 + r1 / 2 + t1 / 2;
            y[9, 5] = panel1.Height / 2 - t1 * 0.8660254037844 + r1 * 0.8660254037844;


            points[10] = 6;
            x[10, 0] = panel1.Width / 2 - r1 / 2 + t1;
            y[10, 0] = panel1.Height / 2 + r1 * 0.8660254037844;
            x[10, 1] = panel1.Width / 2 - r1 / 2 + t1 / 2;
            y[10, 1] = panel1.Height / 2 + t1 * 0.8660254037844 + r1 * 0.8660254037844;
            x[10, 2] = panel1.Width / 2 - r1 / 2 - t1 / 2;
            y[10, 2] = panel1.Height / 2 + t1 * 0.8660254037844 + r1 * 0.8660254037844;
            x[10, 3] = panel1.Width / 2 - r1 / 2 - t1;
            y[10, 3] = panel1.Height / 2 + r1 * 0.8660254037844;
            x[10, 4] = panel1.Width / 2 - r1 / 2 - t1 / 2;
            y[10, 4] = panel1.Height / 2 - t1 * 0.8660254037844 + r1 * 0.8660254037844;
            x[10, 5] = panel1.Width / 2 - r1 / 2 + t1 / 2;
            y[10, 5] = panel1.Height / 2 - t1 * 0.8660254037844 + r1 * 0.8660254037844;

            points[11] = 6;
            x[11, 0] = panel1.Width / 2 - r1 + t1;
            y[11, 0] = panel1.Height / 2;
            x[11, 1] = panel1.Width / 2 - r1 + t1 / 2;
            y[11, 1] = panel1.Height / 2 + t1 * 0.8660254037844;
            x[11, 2] = panel1.Width / 2 - r1 + -t1 / 2;
            y[11, 2] = panel1.Height / 2 + t1 * 0.8660254037844;
            x[11, 3] = panel1.Width / 2 - r1 - t1;
            y[11, 3] = panel1.Height / 2;
            x[11, 4] = panel1.Width / 2 - r1 + -t1 / 2;
            y[11, 4] = panel1.Height / 2 - t1 * 0.8660254037844;
            x[11, 5] = panel1.Width / 2 - r1 + t1 / 2;
            y[11, 5] = panel1.Height / 2 - t1 * 0.8660254037844;

            points[12] = 6;
            x[12, 0] = panel1.Width / 2 - r1 / 2 + t1;
            y[12, 0] = panel1.Height / 2 - r1 * 0.8660254037844;
            x[12, 1] = panel1.Width / 2 - r1 / 2 + t1 / 2;
            y[12, 1] = panel1.Height / 2 + t1 * 0.8660254037844 - r1 * 0.8660254037844;
            x[12, 2] = panel1.Width / 2 - r1 / 2 - t1 / 2;
            y[12, 2] = panel1.Height / 2 + t1 * 0.8660254037844 - r1 * 0.8660254037844;
            x[12, 3] = panel1.Width / 2 - r1 / 2 - t1;
            y[12, 3] = panel1.Height / 2 - r1 * 0.8660254037844;
            x[12, 4] = panel1.Width / 2 - r1 / 2 - t1 / 2;
            y[12, 4] = panel1.Height / 2 - t1 * 0.8660254037844 - r1 * 0.8660254037844;
            x[12, 5] = panel1.Width / 2 - r1 / 2 + t1 / 2;
            y[12, 5] = panel1.Height / 2 - t1 * 0.8660254037844 - r1 * 0.8660254037844;

            points[13] = 6;
            x[13, 0] = panel1.Width / 2 + r1 / 2 + t1;
            y[13, 0] = panel1.Height / 2 - r1 * 0.8660254037844;
            x[13, 1] = panel1.Width / 2 + r1 / 2 + t1 / 2;
            y[13, 1] = panel1.Height / 2 + t1 * 0.8660254037844 - r1 * 0.8660254037844;
            x[13, 2] = panel1.Width / 2 + r1 / 2 + -t1 / 2;
            y[13, 2] = panel1.Height / 2 + t1 * 0.8660254037844 - r1 * 0.8660254037844;
            x[13, 3] = panel1.Width / 2 + r1 / 2 - t1;
            y[13, 3] = panel1.Height / 2 - r1 * 0.8660254037844;
            x[13, 4] = panel1.Width / 2 + r1 / 2 - t1 / 2;
            y[13, 4] = panel1.Height / 2 - t1 * 0.8660254037844 - r1 * 0.8660254037844;
            x[13, 5] = panel1.Width / 2 + r1 / 2 + t1 / 2;
            y[13, 5] = panel1.Height / 2 - t1 * 0.8660254037844 - r1 * 0.8660254037844;




            /*points[4] = 4;
            x[4, 0] = panel1.Width / 2 + t;
            y[4, 0] = panel1.Height / 2 - r;
            x[4, 1] = panel1.Width / 2 ;
            y[4, 1] = panel1.Height / 2 + t -r;
            x[4, 2] = panel1.Width / 2 - t;
            y[4, 2] = panel1.Height / 2 - r;
            x[4, 3] = panel1.Width / 2;
            y[4, 3] = panel1.Height / 2 - t - r;*/
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
            double x1,y1,x2,y2,x3,y3,x4,y4,x5,y5,x6,y6, x8, y8, x9, y9, x10, y10, x11, y11, x12, y12, x13, y13;

            Initialize();

            while (true)
            {
                for (i = 0; i < points[0]; i++)
                {
                   f_rotate(0, i, 0.1, panel1.Width / 2, panel1.Height / 2);
                   f_rotate(1, i, 0.1, panel1.Width / 2, panel1.Height / 2);
                   f_rotate(2, i, 0.1, panel1.Width / 2, panel1.Height / 2);
                   f_rotate(3, i, 0.1, panel1.Width / 2, panel1.Height / 2);
                   f_rotate(4, i, 0.1, panel1.Width / 2, panel1.Height / 2);
                   f_rotate(5, i, 0.1, panel1.Width / 2, panel1.Height / 2);
                   f_rotate(6, i, 0.1, panel1.Width / 2, panel1.Height / 2);
        /////////////////////////////////////////////////////////////////////////////////
                    f_rotate(7, i, -0.1, panel1.Width / 2, panel1.Height / 2);
                    f_rotate(8, i,- 0.1, panel1.Width / 2, panel1.Height / 2);
                    f_rotate(9, i, -0.1, panel1.Width / 2, panel1.Height / 2);
                    f_rotate(10, i,- 0.1, panel1.Width / 2, panel1.Height / 2);
                    f_rotate(11, i, -0.1, panel1.Width / 2, panel1.Height / 2);
                    f_rotate(12, i, -0.1, panel1.Width / 2, panel1.Height / 2);
                    f_rotate(13, i, -0.1, panel1.Width / 2, panel1.Height / 2);

                }

                x1 = (x[1, 0] + x[1, 1] + x[1, 2] + x[1, 3] +x[1, 4] + x[1, 5]) / 6;
                y1 = (y[1, 0] + y[1, 1] + y[1, 2] + y[1, 3] + y[1, 4] + y[1, 5]) / 6;

                x2= (x[2, 0] + x[2, 1] + x[2, 2] + x[2, 3] + x[2, 4] + x[2, 5]) / 6;
                y2 = (y[2, 0] + y[2, 1] + y[2, 2] + y[2, 3] + y[2, 4] + y[2, 5]) / 6;

                x3 = (x[3, 0] + x[3, 1] + x[3, 2] + x[3, 3] + x[3, 4] + x[3, 5]) / 6;
                y3 = (y[3, 0] + y[3, 1] + y[3, 2] + y[3, 3] + y[3, 4] + y[3, 5]) / 6;

                x4 = (x[4, 0] + x[4, 1] + x[4, 2] + x[4, 3] + x[4, 4] + x[4, 5]) / 6;
                y4 = (y[4, 0] + y[4, 1] + y[4, 2] + y[4, 3] + y[4, 4] + y[4, 5]) / 6;

                x5 = (x[5, 0] + x[5, 1] + x[5, 2] + x[5, 3] + x[5, 4] + x[5, 5]) / 6;
                y5 = (y[5, 0] + y[5, 1] + y[5, 2] + y[5, 3] + y[5, 4] + y[5, 5]) / 6;

                x6 = (x[6, 0] + x[6, 1] + x[6, 2] + x[6, 3] + x[6, 4] + x[6, 5]) / 6;
                y6 = (y[6, 0] + y[6, 1] + y[6, 2] + y[6, 3] + y[6, 4] + y[6, 5]) / 6;

                ///////////////////////////////////////////////////////////////////////////////
                x8 = (x[8, 0] + x[8, 1] + x[8, 2] + x[8, 3] + x[8, 4] + x[8, 5]) / 6;
                y8 = (y[8, 0] + y[8, 1] + y[8, 2] + y[8, 3] + y[8, 4] + y[8, 5]) / 6;

                x9 = (x[9, 0] + x[9, 1] + x[9, 2] + x[9, 3] + x[9, 4] + x[9, 5]) / 6;
                y9 = (y[9, 0] + y[9, 1] + y[9, 2] + y[9, 3] + y[9, 4] + y[9, 5]) / 6;

                x10 = (x[10, 0] + x[10, 1] + x[10, 2] + x[10, 3] + x[10, 4] + x[10, 5]) / 6;
                y10 = (y[10, 0] + y[10, 1] + y[10, 2] + y[10, 3] + y[10, 4] + y[10, 5]) / 6;

                x11 = (x[11, 0] + x[11, 1] + x[11, 2] + x[11, 3] + x[11, 4] + x[11, 5]) / 6;
                y11 = (y[11, 0] + y[11, 1] + y[11, 2] + y[11, 3] + y[11, 4] + y[11, 5]) / 6;

                x12 = (x[12, 0] + x[12, 1] + x[12, 2] + x[12, 3] + x[12, 4] + x[12, 5]) / 6;
                y12 = (y[12, 0] + y[12, 1] + y[12, 2] + y[12, 3] + y[12, 4] + y[12, 5]) / 6;

                x13 = (x[13, 0] + x[13, 1] + x[13, 2] + x[13, 3] + x[13, 4] + x[13, 5]) / 6;
                y13 = (y[13, 0] + y[13, 1] + y[13, 2] + y[13, 3] + y[13, 4] + y[13, 5]) / 6;


                for (i = 0; i < points[0]; i++)
                {
                    f_rotate(1, i, -1, x1, y1);
                    f_rotate(2, i, -1, x2, y2);
                    f_rotate(3, i,- 1, x3, y3);
                    f_rotate(4, i, -1, x4, y4);
                    f_rotate(5, i, -1, x5, y5);
                    f_rotate(6, i, -1, x6, y6);

                    /////////////////////////////

                    f_rotate(8, i, 1, x8, y8);
                    f_rotate(9, i, 1, x9, y9);
                    f_rotate(10, i, 1, x10, y10);
                    f_rotate(11, i, 1, x11, y11);
                    f_rotate(12, i, 1, x12, y12);
                    f_rotate(13, i, 1, x13, y13);


                }

                DrawPolygon(0);
                DrawPolygon(1);
                DrawPolygon(2);
                DrawPolygon(3);
                DrawPolygon(4);
                DrawPolygon(5);
                DrawPolygon(6);
                //////////////
                DrawPolygon(7);
                DrawPolygon(8);
                DrawPolygon(9);
                DrawPolygon(10);
                DrawPolygon(11);
                DrawPolygon(12);
                DrawPolygon(13);
                //DrawCircle(panel1.Width/2, panel1.Height/2,r);
                System.Threading.Thread.Sleep(100);
                DeletePolygon(0);
                DeletePolygon(1);
                DeletePolygon(2);
                DeletePolygon(3);
                DeletePolygon(4);
                DeletePolygon(5);
                DeletePolygon(6);

                ///////////////

                DeletePolygon(7);
                DeletePolygon(8);
                DeletePolygon(9);
                DeletePolygon(10);
                DeletePolygon(11);
                DeletePolygon(12);
                DeletePolygon(13);
                // DrawCircle(panel1.Width / 2, panel1.Height / 2, r);
            }
        }
       
    }
}
