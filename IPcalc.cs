using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class IPcalc : Form
    {
        //declaring the obj to store the time when 
        //the app opens
        DateTime currentDate = DateTime.Now;
        public IPcalc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                //the regex obj is declared here
                Regex myObj = new Regex(@"^([0-9]{1,3})\.([0-9]{1,3})\.([0-9]{1,3})\.([0-9]{1,3})$");
                if (myObj.IsMatch(textBox1.Text.Trim()) == true)
                {//the number will be trimmed and if put correctly will be displayed


                    MessageBox.Show(textBox1.Text.Trim() + "\nThe IP is correct. It's a valid IP!");

                }
                else
                {//if it's wrong it'll show a message if the correct way
                    MessageBox.Show(textBox1.Text.Trim() + "\nThis IP adress is wrong\nThe IP should be 4 byts\nInteger between 0 to 255\nseperated by a dot\n(255.255.255.255)");
                    textBox1.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IPcalc_Load(object sender, EventArgs e)
        {//time that the form is loaded
            labelToday.Text = "Today: " + DateTime.Now.ToLongDateString();
        }
    }
}
