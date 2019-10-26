using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interior_algo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a1, b1, a2, b2, a3, b3;
        float a, b;

        private void btnCheck_Click(object sender, EventArgs e)
        {
            float t0 = t(a1, b1, a2, b2, a3, b3);
            float t1 = t(a1, b1, a2, b2, a, b);
            float t2 = t(a2, b2, a3, b3, a, b);
            float t3 = t(a3, b3, a1, b1, a, b);

            if ((t0 * t1 > 0) && (t0 * t2 > 0) && (t0 * t3 > 0))
            {
                lblPosition.Text = "Inside";
            }
            else
            {
                lblPosition.Text = "Outside";
            }
        }

        private void btnDrawP_Click(object sender, EventArgs e)
        {
            a = float.Parse(txtX.Text);
            b = float.Parse(txtY.Text);

            DisplayPoint(a, b);
        }

        
        private void btnDrawTri_Click(object sender, EventArgs e)
        {
            a1 = float.Parse(txtX1.Text);
            b1 = float.Parse(txtY1.Text);
            a2 = float.Parse(txtX2.Text);
            b2 = float.Parse(txtY2.Text);
            a3 = float.Parse(txtX3.Text);
            b3 = float.Parse(txtY3.Text);


            DisplayLine(a1, b1, a2, b2);
            DisplayLine(a2, b2, a3, b3);
            DisplayLine(a3, b3, a1, b1);
        }

        
        private float t(float a1, float b1, float a2, float b2, float a3, float b3)
        {
            return a1 * (b2 - b3) + a2 * (b3 - b1) + a3 * (b1 - b2);
        }
        private void DisplayPoint(float x,float y)
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(Pens.Black, x, panel1.Height - y, x + 0.1F, panel1.Height - y);
        }
        private void DisplayLine(float x1, float y1,float x2, float y2)
        {
            Graphics g = panel1.CreateGraphics();
            if ((x1 == x2) && (y1 == y2))
            {
                DisplayPoint(x1, y1);
            }
            else
            {
                g.DrawLine(Pens.Black, x1, panel1.Height - y1, x2, panel1.Height - y2);
            }
        }

    }
}
