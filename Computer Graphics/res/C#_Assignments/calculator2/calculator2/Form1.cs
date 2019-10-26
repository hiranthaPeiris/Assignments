using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }
        double total1 = 0;
        
        double answer=0;

        string theOperator;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            if (answer == 0)
            {
                answer = num;
            }else
            {
                answer = answer + num;
            }
            //total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            //txtDisplay.Text = answer.ToString();

            theOperator = "+";

            plusButtonClicked = true;
            minusButtonClicked =false;

        }
        double total2=0;
        Boolean plusButtonClicked = false;
        Boolean minusButtonClicked = false;
        Boolean multiplyButtonClicked = false;
        Boolean divideButtonClicked = false;

        

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            switch (theOperator)
            {
                case "+":
                    total2 = total1 + double.Parse(txtDisplay.Text);
                    break;

                case "-":
                    //total2 = total1 - double.Parse(txtDisplay.Text);
                    answer = answer - double.Parse(txtDisplay.Text);
                    Console.Write(answer.ToString());
                    break;
                case "*":
                    total2 = total1 * double.Parse(txtDisplay.Text);
                    break;
                case "/":
                    total2 = total1 / double.Parse(txtDisplay.Text);
                    break;
                default:
                    Console.Write("default statement");
                    break;                
            }
            /*if(plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }else if(minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }else if (multiplyButtonClicked == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
            }
            */

            txtDisplay.Text = answer.ToString();
            total1 = 0;
        }

        
      

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            if (answer == 0)
            {
                answer = num;
            }
            else
            {
                answer = answer - num;
            }

            //total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            Console.Write(answer.ToString());
            theOperator = "-";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "*";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "/";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
        }
    }
}