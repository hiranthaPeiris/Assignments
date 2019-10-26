using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int firstNumber;
            //int secondNumber;
            int integerAnswer;

            firstNumber = 10;
            //secondNumber = 32;

            integerAnswer = firstNumber + 10+32;

            MessageBox.Show(integerAnswer.ToString());
        }

        private void BtnFloat_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float floatAnswer;
            int integerAnswer;

            firstNumber = 10.5F;
            secondNumber = 32.5F;

            floatAnswer = firstNumber + secondNumber;
            integerAnswer = (int)firstNumber + (int)secondNumber;

            MessageBox.Show(floatAnswer.ToString());
        }

        private void BtnSubstract_Click(object sender, EventArgs e)
        {
            int answerSubtract;
            int numberOne = 10;

            answerSubtract = 50 - numberOne;
            MessageBox.Show(answerSubtract.ToString());
        }

        private void BtnMixed_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;

            int answer;

            firstNumber = 100;
            secondNumber = 75;
            thirdNumber = 50;

            answer =(firstNumber * secondNumber )- thirdNumber;

            MessageBox.Show(answer.ToString());


        }
    }
}
