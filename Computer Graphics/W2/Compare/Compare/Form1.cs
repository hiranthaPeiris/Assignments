using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;

            firstNumber = int.Parse(textBox1.Text);
            secondNumber = int.Parse(textBox2.Text);

            if(firstNumber > secondNumber)
            {
                MessageBox.Show("The first Number is greater than the second number");
            }
            if (firstNumber < secondNumber)
            {
                MessageBox.Show("The first number is less than the second number");
            }
            if(firstNumber == secondNumber)
            {
                MessageBox.Show("The first number is equal to the sescond number");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(textBox3.Text);

            if (age < 16)
            {
                MessageBox.Show("Still a young");
            }else if (age < 25)
            {
                MessageBox.Show("Fame Beckons!");
            }else if(age<)

        }
    }
}
