using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIntegers_Click(object sender, EventArgs e)
        {
            int myInteger;
            myInteger = 25;
            MessageBox.Show(myInteger.ToString());
        }

        private void BtnFloat_Click(object sender, EventArgs e)
        {
            float myFloat;
            myFloat = 0.42F;
            MessageBox.Show(myFloat.ToString());
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            double myDouble;
            myDouble = 0.007;
            MessageBox.Show(myDouble.ToString());

        }
    }
}
