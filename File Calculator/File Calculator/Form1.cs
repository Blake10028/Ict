using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //blake hughes
            //10-06-2019
            //make new files
            StreamWriter ns = new StreamWriter($"{tbxInput.Text}.txt", false);
            ns.WriteLine($"{tbxInput.Text}");
            ns.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

         //open old files
            string FileName = "";

            ofdFoldFinder.Filter = "text (*.txt)|*.txt";
            ofdFoldFinder.FileName = "";
            ofdFoldFinder.Title = "Select File";

            if (ofdFoldFinder.ShowDialog() == DialogResult.OK)
            {
                FileName = ofdFoldFinder.FileName;
                

                using (StreamReader reader = new StreamReader(FileName))
                {

                    string line = reader.ReadLine();
                    tbxInput.Text = line;
                }


            }
            else
            {
                MessageBox.Show($"try again");
            }



           


            }

        private void btnTotal_Click(object sender, EventArgs e)
        {

            //split between . and , 
            string[] splitnum = tbxInput.Text.Split(new char[] { ',','.' });

            //cal  the total
            int total = 0;

            for (int i = 0; i < splitnum.Length; i++)
            {
                total += Convert.ToInt32(splitnum[i]);
                lblanwer.Text = total.ToString();
            }
            
            

           
           
           

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //split between . and , 
            string[] splitnum = tbxInput.Text.Split(new char[] { ',', '.' });

            //cal  the average
            int total = 0;

            for (int i = 0; i < splitnum.Length; i++)
            {
                total += Convert.ToInt32(splitnum[i]);
                
            }

            int avg = total / splitnum.Length;
            lblanwer.Text = avg.ToString();

        }

        private void btnSmallest_Click(object sender, EventArgs e)
        {

        }

        private void lblanwer_Click(object sender, EventArgs e)
        {

        }
    }
}
 