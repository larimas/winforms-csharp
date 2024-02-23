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
    public partial class Cambio : Form
    /*credits for the imgs from the flags: https://www.flaticon.com/br/packs/countrys-flags */
    {
        public Cambio()
        {
            InitializeComponent();
        }

        private void Cambio_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {//a pop up to exit the application when you click the button to get out
            if (MessageBox.Show("Do you want to quit the application Money Exchange?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        public string ConvertValues(string FROMopt, string TOopt)
        {
            //verify if it's the same what it was chosen
            if (FROMopt == TOopt)
            { return (Convert.ToDouble(textFROM.Text)).ToString(); } //Just to remove if there is 0 before
            else
            {
                //creation of a dictionary to check and compare if it's an error
                Dictionary<string, double> ExchangeFactor = new Dictionary<string, double>();
                ExchangeFactor.Add("CADUSD", 0.797171);
                ExchangeFactor.Add("USDCAD", 1.25444);
                ExchangeFactor.Add("CADEUR", 1.48608);
                ExchangeFactor.Add("EURCAD", 0.672911);
                ExchangeFactor.Add("CADGBP", 1.72956);
                ExchangeFactor.Add("GBPCAD", 0.578180);
                ExchangeFactor.Add("CADWON", 0.93877);
                ExchangeFactor.Add("WONCAD", 1.07);
                ExchangeFactor.Add("USDEUR", 0.844274);
                ExchangeFactor.Add("EURUSD", 1.18445);
                ExchangeFactor.Add("USDGBP", 0.725285);
                ExchangeFactor.Add("GBPUSD", 1.37874);
                ExchangeFactor.Add("WONUSD", 0.77);
                ExchangeFactor.Add("USDWON", 1.29583);
                ExchangeFactor.Add("EURGBP", 0.859034);
                ExchangeFactor.Add("GBPEUR", 1.16410);
                ExchangeFactor.Add("EURWON", 0.72);
                ExchangeFactor.Add("WONEUR", 0.160561);
                ExchangeFactor.Add("GBPWON", 1.58414);
                ExchangeFactor.Add("WONGBP", 0.63);

                return (Convert.ToDouble(textFROM.Text) * ExchangeFactor[FROMopt + TOopt]).ToString("0.00");
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {//declaring obj to manipulate the file
                if (!File.Exists(@"../../txtfiles/MoneyConversions.txt")) throw new Exception("File not created yet. Please do a convertion first.");
                FileStream directory = new FileStream(@"../../txtfiles/MoneyConversions.txt", FileMode.Open, FileAccess.Read);
                StreamReader file = new StreamReader(directory);
                string textoprint = "FROM\tTO\t\tDATE\n" + file.ReadToEnd();
                file.Close();
                directory.Close();
                MessageBox.Show(textoprint, "MoneyConversions.txt");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string FROMoption = "", TOoption = "";
            try
            {
                //verifying the conversion and if's not right the exception will act
                //checks the option "FROM"
                foreach (RadioButton rbtnFrom in groupBox1.Controls.OfType<RadioButton>())
                { if (rbtnFrom.Checked) { FROMoption = rbtnFrom.Text; break; } }

                //same as above: checks the option "TO"
                foreach (RadioButton rbtnTo in groupBox2.Controls.OfType<RadioButton>())
                { if (rbtnTo.Checked) { TOoption = rbtnTo.Text; break; } }
                if (TOoption == "") { throw new InvalidOperationException("Please select one 'TO' option."); }
                textTO.Text = this.ConvertValues(FROMoption, TOoption);

                
                DateTime dateNOW = DateTime.Now; //store the time the form is loaded
                FileStream directory = new FileStream(@"../../txtfiles/MoneyConversions.txt", FileMode.Append, FileAccess.Write);
                StreamWriter file = new StreamWriter(directory);
                file.WriteLine(textFROM.Text + " " + FROMoption + " = " + textTO.Text + " " + TOoption + ", " + dateNOW.ToShortDateString() + " " + dateNOW.ToLongTimeString()); ;
                file.Close();
                directory.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textFROM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
