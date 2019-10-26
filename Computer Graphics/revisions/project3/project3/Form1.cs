using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3
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

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            int x, y;
            x = e.X;
            y = panel.Height-e.Y;
            DisplayPoint(x,y);
            listBox1.Items.Add(x+"\t\t"+y);
        }
    }
}
