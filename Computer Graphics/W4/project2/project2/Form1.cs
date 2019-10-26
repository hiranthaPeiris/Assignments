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
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void DisplayPoint(float x, float y)
        {

            Graphics g = panel1.CreateGraphics();
            Color newc = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            g.DrawLine(new Pen(newc,2), x, panel1.Height - y, x + 0.1F, panel1.Height - y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points=0;
            int i, x, y;

            Random r = new Random();

            try
            {
                points = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Enter valid number of points");
                textBox1.Clear();
                textBox1.Focus();
            }

            for ( i = 0; i < points; i++)
            {
                x = r.Next(0, panel1.Width);
                y = r.Next(0, panel1.Height);
                DisplayPoint(x, y);
            }
        }
    }
}
