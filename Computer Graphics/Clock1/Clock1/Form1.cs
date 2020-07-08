using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[,] x = new double[3, 4];
        double[,] y = new double[3, 4];

        int xc, yc;
        int r,points;

        public void init()
        {
            xc = panel1.Width / 2;
            yc = panel1.Height / 2;
            r = 200;
            int c1=6, c2=9, c3=13;
           
            points = 4;
            x[0, 0] = panel1.Width / 2;
            y[0, 0] = panel1.Height / 2;
            x[0, 1] = panel1.Width / 2 + c1;
            y[0, 1] = panel1.Height / 2 - 175;
            x[0, 2] = panel1.Width / 2;
            y[0, 2] = panel1.Height / 2-192;
            x[0, 3] = panel1.Width / 2-c1;
            y[0, 3] = panel1.Height / 2 - 175 ;

            x[1, 0] = panel1.Width / 2;
            y[1, 0] = panel1.Height / 2;
            x[1, 1] = panel1.Width / 2 + c2;
            y[1, 1] = panel1.Height / 2 - 150;
            x[1, 2] = panel1.Width / 2;
            y[1, 2] = panel1.Height / 2 - 175;
            x[1, 3] = panel1.Width / 2 - c2;
            y[1, 3] = panel1.Height / 2 - 150;

            x[2, 0] = panel1.Width / 2;
            y[2, 0] = panel1.Height / 2;
            x[2, 1] = panel1.Width / 2 + c3;
            y[2, 1] = panel1.Height / 2 - 110;
            x[2, 2] = panel1.Width / 2;
            y[2, 2] = panel1.Height / 2 - 140;
            x[2, 3] = panel1.Width / 2 - c3;
            y[2, 3] = panel1.Height / 2 - 110;


        }

        public void DisplayLine(double x1,double y1,double x2,double y2) 
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(Pens.Black, (float)x1,(float) y1,(float) x2,(float) y2);

        }

        public void DisplayPolygon(int o)
        {
            int j;
            for(int i = 0; i < points; i++)
            {
                j = (i + 1) % points;
                DisplayLine(x[o, i], y[o, i], x[o, j], y[o, j]);
            }

        }
        public void DisplayCircle()
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawEllipse(Pens.Black, xc-r, yc-r, 2*r, 2*r);

        }

        public void Rotate(int o,int i,double v)
        {
            double  x1, y1;
            x1 =x[o, i];
            y1 =y[o, i];

            x[o, i] = x1 * Math.Cos(v) - y1 * Math.Sin(v);
            y[o, i] = x1 * Math.Sin(v) + y1 * Math.Cos(v);

        }

        public void Translate(int o,int i,double tx,double ty)
        {
            x[o, i] += tx;
            y[o, i] += ty;
        }

        public void F_Rotate(int o,int i,double tx,double ty,float v)
        {
            Translate(o, i, -tx, -ty);
            Rotate(o, i, v);
            Translate(o, i, tx, ty);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            init();

            DisplayPolygon(0);
            DisplayPolygon(1);
            DisplayPolygon(2);
            DisplayCircle();
            int second = 0,minutes=0;

            while (true)
            {
                if (second == 60)
                {
                    second = 0;
                    for(int i = 0; i < points; i++)
                    {
                       F_Rotate(1, i, xc, yc, (float)(Math.PI / 30));
                    }
                    
                    minutes++;
                }
                if (minutes == 60)
                {
                    minutes = 0;
                    for (int i = 0; i < points; i++)
                    {
                        F_Rotate(2, i, xc, yc, (float)(Math.PI / 30));
                    }
                }

                for(int i = 0; i < points; i++)
                {
                    F_Rotate(0,i,xc,yc,(float)(Math.PI/30));
                   
                }

                second ++;

                System.Threading.Thread.Sleep(1000);
                panel1.Refresh();
                DisplayCircle();
                DisplayPolygon(0);
                DisplayPolygon(1);
                DisplayPolygon(2);
                

            }


        }
    }
}
