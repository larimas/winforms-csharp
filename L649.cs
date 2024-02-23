using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{

    public partial class L649 : Form
    {//declaring the structures, date and paths that will be with the generated
        //file
        DateTime currentDateTime = DateTime.Now;
        FileStream fs = null;
        string path = @"../../txtfiles/LottoNumbers.txt";
        public L649()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {//declaring the random number, the variables for the numbers
            //and the obj to manipulate the files
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            Random random = new Random();
            int value;
            string[] g = new string[8];

            //number is generated amd stored into the array, checks
            //if it's a repeated number
            showbox.Text = "";
            for (int i = 0; i < 7; i++)
            {
                value = random.Next(1, 49);
                showbox.Text += value.ToString() + "\r\n";
                g[i] = value.ToString();

            }
           //clear the label for each iteration
           //check if there's a repeated number etc
            showNumbers.Text = "";
            for (int i = 0; i < 7; i++)
            {
                value = random.Next(0, 10);
                showNumbers.Text += value.ToString();

            }


            textOut.Write("649" + "\t" + "|");
            for (int i = 0; i < 6; i++)
            {
                textOut.Write(g[i] + ",");
            }

            textOut.Write("  Extra (" + g[6] + ")" + "|");
            textOut.WriteLine("  " + currentDateTime);

            textOut.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal = Convert.ToByte(MessageBox.Show("Do you want to exit?", "Lotto Max", MessageBoxButtons.OKCancel));

            if (btnVal == 1)
            {
                this.Close();
            }
        }      
        private void btnreadfile_Click(object sender, EventArgs e)
        {
            // read the data from the file and store it in the list  
            try
            {
                if (!File.Exists(@"../../txtfiles/LottoNumbers.txt")) throw new Exception("File not created yet. Please generate some numbers first.");
                if (!File.Exists(@"../../txtfiles/LottoNumbers.txt")) throw new Exception("File not created yet. Please generate some lotto numbers first.");
                FileStream directory = new FileStream(@"../../txtfiles/LottoNumbers.txt", FileMode.Open, FileAccess.Read);
                StreamReader file = new StreamReader(directory);
                string textoprint = file.ReadToEnd();
                file.Close();
                directory.Close();
                MessageBox.Show(textoprint, "All Winning Numbers");
            }// close the input stream for the text file  
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
