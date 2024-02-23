using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {// it'll be activated where a new window will open when you click the button
            //for the Calculator
            Calculator obj = new Calculator();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {// it'll be activated where a new window will open when you click the button
            //for to close the dashboard and to exit the applications
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {// it'll be activated where a new window will open when you click the button
            //for the IP Calculator
            IPcalc obj = new IPcalc();
            obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {// it'll be activated where a new window will open when you click the button
            //for the Money Exchange
            Cambio obj = new Cambio();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {// it'll be activated where a new window will open when you click the button
            //for the Temperature Calculator
            Temp obj = new Temp();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {// it'll be activated where a new window will open when you click the button
            //for the Lotto Max
            LMax obj = new LMax();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {// it'll be activated where a new window will open when you click the button
            //for the Lotto 649
            L649 obj = new L649();
            obj.ShowDialog();
        }
    }
}
