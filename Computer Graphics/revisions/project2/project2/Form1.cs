using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayPoint(float x, float y)
        {
            Graphics g = panel.CreateGraphics();
            g.DrawLine(Pens.Black, x, panel.Height - y, x + 0.1F, panel.Height - y);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int points=0;
            int i,x,y;
            Random r = new Random();

            try
            {
                points = int.Parse(txtPoints.Text);
            }
            catch
            {
                MessageBox.Show("Error");
                txtPoints.Clear();
                txtPoints.Focus();
            }

            for (i=0;i< points;i++)
            {
                x = r.Next(0,panel.Width);
                y = r.Next(0,panel.Width);
                DisplayPoint(x,y);
            }
        }
    }
}
