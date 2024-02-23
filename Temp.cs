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
    public partial class Temp : Form
    {
        public Temp()
        {
            InitializeComponent();
        }

        TempCalc Cal1 = new TempCalc();
        //true = C to F
        //false = F to C

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {//calculating the temperature
                Cal1.Initval = Convert.ToDouble(txtInput.Text);
                if (Cal1.Convertstatus)
                    Cal1.Finalval = ((Cal1.Initval * 9 / 5) + 32);
                else
                    Cal1.Finalval = (Cal1.Initval - 32) * 5 / 9;
                txtResult.Text = Cal1.Finalval.ToString();
                txtboxMessage.Text = Cal1.Message();

                //starting exportation
                //declaring the structures to be used into classes
                //declaring the showing dates structure
                //declaring the path to write the file
                DateTime dateodnow = DateTime.Now;
                FileStream directory = new FileStream(@"../../txtfiles/TempConversions.txt", FileMode.Append, FileAccess.Write);
                StreamWriter file = new StreamWriter(directory);
                if (Cal1.Convertstatus)
                    file.WriteLine(txtInput.Text + " C = " + txtResult.Text + " " + " F , " + dateodnow.ToShortDateString() + " " + dateodnow.ToLongTimeString());
                else
                    file.WriteLine(txtInput.Text + " F = " + txtResult.Text + " " + " C , " + dateodnow.ToShortDateString() + " " + dateodnow.ToLongTimeString());
                file.Close();
                directory.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message + "\nPlease put only numbers.", "Error");
                txtInput.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application TempApp?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void radiobtnCtoF_CheckedChanged(object sender, EventArgs e)
        {
            labelResult.Text = "F";
            labelInput.Text = "C";
            txtInput.Text = txtResult.Text = "";
            Cal1.Convertstatus = true;
        }

        private void radiobtnFtoC_CheckedChanged(object sender, EventArgs e)
        {
            labelResult.Text = "C";
            labelInput.Text = "F";
            txtInput.Text = txtResult.Text = "";
            Cal1.Convertstatus = false;
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {//the object which read the file and an instant put in
                //the indicated file
                if (!File.Exists(@"../../txtfiles/TempConversions.txt")) throw new Exception("File not created yet. Please do one convertion first.");
                FileStream directory = new FileStream(@"../../txtfiles/TempConversions.txt", FileMode.Open, FileAccess.Read);
                StreamReader file = new StreamReader(directory);
                string textoprint = "FROM\tTO\t\tDATE\n" + file.ReadToEnd();
                file.Close();
                directory.Close(); //the list will be printed on a new window
                MessageBox.Show(textoprint, "TempConversions.txt");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }
        }

        private void Temp_Load(object sender, EventArgs e)
        {

        }

        public class TempCalc
        {
            private bool convertstatus;
            private double initval, finalval;

            public bool Convertstatus { get; set; }
            public double Initval { get; set; }
            public double Finalval { get; set; }

            //messages showing depending on the value input
            public string Message()
            {
                if ((Convertstatus && Initval == 100) || (!Convertstatus && Initval == 212))
                {
                    return "Water boils";
                }
                else if ((Convertstatus && Initval == 40) || (!Convertstatus && Initval == 104))
                {
                    return "Hot Bath";
                }
                else if ((Convertstatus && Initval == 37) || (!Convertstatus && Initval == 98.6))
                {
                    return "Body temperature";
                }
                else if ((Convertstatus && Initval == 30) || (!Convertstatus && Initval == 86))
                {
                    return "Beach weather";
                }
                else if ((Convertstatus && Initval == 21) || (!Convertstatus && Initval == 70))
                {
                    return "Room temperature";
                }
                else if ((Convertstatus && Initval == 10) || (!Convertstatus && Initval == 50))
                {
                    return "Cool Day";
                }
                else if ((Convertstatus && Initval == 0) || (!Convertstatus && Initval == 32))
                {
                    return "Freezing point of water";
                }
                else if ((Convertstatus && Initval == -18) || (!Convertstatus && Initval == 0))
                {
                    return "Very Cold Day";
                }
                else if (Initval == -40)
                {
                    return "Extremely Cold Day\n(and the same number!)";
                }
                else { return ""; }
            }


        }
    }
}
