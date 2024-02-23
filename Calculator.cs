using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Project
{
    public partial class Calculator : Form
    {
        string input = string.Empty;        //storing user input
        String operand1 = string.Empty;     
        String operand2 = string.Empty;     
        char calc;                     // stores the value of the op
        double result = 0.0;                //get result
        public Calculator()
        {
            InitializeComponent();
        }

        //if the number 1 is clicked then it'll generate the number 1
        // and so on; if the number 0 is on the text box it will substitute
        //by 1, if not it'll concatenate the number 1

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "";
            input += "1";
            this.textBoxOutput.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "";
            input += "2";
            this.textBoxOutput.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "";
            input += "3";
            this.textBoxOutput.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "";
            input += "4";
            this.textBoxOutput.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "";
            input += "5";
            this.textBoxOutput.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "";
            input += "6";
            this.textBoxOutput.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "";
            input += "7";
            this.textBoxOutput.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "";
            input += "8";
            this.textBoxOutput.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "";
            input += "9";
            this.textBoxOutput.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "";
            input += "0";
            this.textBoxOutput.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operand1 = input;
            calc = '*';
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = input;
            calc = '/';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = input;
            calc = '-';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = input;
            calc = '+';
            input = string.Empty;
        }

        //code for the calcs fot the choosen operation
        private void button16_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            string equation = "";

            if (calc == '+')
            {
                result = num1 + num2;
                textBoxOutput.Text = result.ToString();
                equation = num1 + " + " + num2 + " = " + result;
                textBox1.Text = equation;
            }
            else if (calc == '-')
            {
                result = num1 - num2;
                textBoxOutput.Text = result.ToString();
                equation = num1 + " - " + num2 + " = " + result;
                textBox1.Text = equation;
            }
            else if (calc == '*')
            {
                result = num1 * num2;
                textBoxOutput.Text = result.ToString();
                equation = num1 + " * " + num2 + " = " + result;
                textBox1.Text = equation;
            }
            else if (calc == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBoxOutput.Text = result.ToString();
                    equation = num1 + " / " + num2 + " = " + result;
                    textBox1.Text = equation;
                }
                else
                {
                    textBoxOutput.Text = "ERROR DIV BY ZERO";
                }
            }
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        //clear the space
        private void button17_Click(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
    }
}
