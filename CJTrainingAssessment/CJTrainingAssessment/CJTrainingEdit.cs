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

namespace CJTrainingAssessment
{
    public partial class CJTrainingEdit : Form
    {
        public string file;
        public CJTrainingEdit()

        {
            InitializeComponent();
        }

        public void Load()
        {


            using (StreamReader reader = new StreamReader(file))
            {

                //making the first line/ the password on the text a string so i can chack if its right
                string password = reader.ReadLine();
                tbxPassanw.Text = password;
                string passwor = reader.ReadLine(); 
                textBox1.Text = passwor;
                string passwo = reader.ReadLine();
                textBox2.Text = passwo;
                string passw = reader.ReadLine();
                textBox3.Text = passw;
                string pass = reader.ReadLine();
                textBox4.Text = pass;
                string pas = reader.ReadLine();
                textBox5.Text = pas;
                string pa = reader.ReadLine();
                textBox6.Text = pa;
                string p = reader.ReadLine();
                textBox7.Text = p;
                string mean = reader.ReadLine();
                textBox8.Text = mean;
                string mea = reader.ReadLine();
                textBox9.Text = mea;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter ns = new StreamWriter(file);
            ns.WriteLine($"{tbxPassanw.Text}");
            ns.WriteLine($"{textBox1.Text}");
            ns.WriteLine($"{textBox2.Text}");
            ns.WriteLine($"{textBox3.Text}");
            ns.WriteLine($"{textBox4.Text}");
            ns.WriteLine($"{textBox5.Text}");
            ns.WriteLine($"{textBox6.Text}");
            ns.WriteLine($"{textBox7.Text}");
            ns.WriteLine($"{textBox8.Text}");
            ns.WriteLine($"{textBox9.Text}");
            ns.Close();
        }

        private void CJTrainingEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
