using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1_1935538
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //blake hughes
            //18/2/19
            //open form1 
            Form1 bhform = new Form1();

          
            bhform.Show();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 bform = new Form3();

            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            bform.Show();
        }
    }
}
