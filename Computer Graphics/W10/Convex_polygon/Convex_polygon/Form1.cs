using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convex_polygon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] x = new int[100];
        int[] y = new int[100];
        int points;

        private void DisplayLine(int x1, int y1, int x2, int y2)
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(Pens.Black, x1, panel1.Height - y1, x2, panel1.Height - y2);
        }

        private void DeleteLine(int x1, int y1, int x2, int y2)
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(Pens.White, x1, panel1.Height - y1, x2, panel1.Height - y2);
        }

        private void DrawPolygon()
        {
            int i, j;
            for (i = 0; i < points; i++)
            {
                j = (i + 1) % points;
                DisplayLine(x[i], y[i], x[j], y[j]);
            }
        }

        private void DeletePolygon()
        {
            int i, j;
            for (i = 0; i < points; i++)
            {
                j = (i + 1) % points;
                DeleteLine(x[i], y[i], x[j], y[j]);
            }
        }

        private long t(int x1,int y1,int x2,int y2,int x3,int y3)
        {
            return x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
        }

        private Boolean isTowSides(int i,int j)
        {
            int iw, jw;
            iw = (i + 1) % points;
            jw = (j + 1) % points;

            if (t(x[i], y[i], x[iw], y[iw], x[j], y[j]) * t(x[i], y[i], x[iw], y[iw], x[jw], y[jw]) < 0)
            {
                return true;
            }
            return false;
        }

        private Boolean isIntersect(int i,int j)
        {
            if (isTowSides(i, j) && isTowSides(j, i))
            {
                return true;
            }
            return false;
        }
        private void btnGenarate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Boolean found;
            Boolean simple;
            int i, j;

            points = int.Parse(txtVertices.Text);

            found = false;
            while (!found)
            {
                simple = true;

                for (i = 0; i < points; i++)
                {
                    x[i] = r.Next(0, panel1.Width);
                    y[i] = r.Next(0, panel1.Height);
                }
                for (i = 0; i < points; i++)
                {
                    for ( j = 0; j < points; j++)
                    {
                        if (isIntersect(i, j))
                        {
                            simple = true;
                        }
                    }
                }
                if (simple)
                {
                    DrawPolygon();
                    found = true;
                }
            }
        }
    }
}
