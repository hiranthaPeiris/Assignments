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
        private void DisplayPoint(float x,float y)
        {
            Graphics g = panel1.CreateGraphics();

            g.DrawLine(Pens.BlueViolet, x, panel1.Height - y, x + 0.1F, panel1.Height - y);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            int x, y;
            x = e.X;
            y = panel1.Height - e.Y;
            DisplayPoint(x, y);
            listBox1.Items.Add(x + "\t\t" + y);
        }
    }
}
