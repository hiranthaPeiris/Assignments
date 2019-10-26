using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayPoint(float x, float y)
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(Pens.Black, x, panel1.Height - y,x+0.1F, panel1.Height - y);
        }
        private void DisplayLine(float x1, float y1, float x2, float y2)
        {
            Graphics g = panel1.CreateGraphics();
            if(x1 == x2 && y1 == y2)
            {
                DisplayPoint(x1, y1);
            }
            else
            {
                g.DrawLine(Pens.Black, x1,panel1.Height - y1, x2,panel1.Height - y2);
                
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayLine(float.Parse(txtXs.Text), float.Parse(txtYs.Text), float.Parse(txtXe.Text), float.Parse(txtYe.Text));
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
