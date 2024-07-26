using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkFacebook_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFacebook.Checked)
                
            {
                tbxoutput.Text += "Facebook";
            }
            else
            {
                tbxoutput.Text = tbxoutput.Text.Replace("Facebook", "");
            }
            btngo1.Show();
            if (!chkFacebook.Checked)
            {
                btngo1.Hide();
            }
               
                 
            {

            }
            
        }


        private void chktwitter_CheckedChanged(object sender, EventArgs e)
        {
            if (chktwitter.Checked)
            {
                tbxoutput.Text += "twitter";
                
            }
            else
            {
                tbxoutput.Text = tbxoutput.Text.Replace("twitter", "");
            }
            btnGo4.Show();
            if (!chktwitter.Checked)
            {
                btnGo4.Hide();
            }
        }

        private void chkMyspace_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMyspace.Checked)
            {
                tbxoutput.Text += "myspace";
            
            }
            else
            {
                tbxoutput.Text = tbxoutput.Text.Replace("myspace","");
                
            }
            btnGo2.Show();
            if (!chkMyspace.Checked)
                btnGo2.Hide();
        }

        private void chkyoutube_CheckedChanged(object sender, EventArgs e)
        {
            if (chkyoutube.Checked) 
            {
                tbxoutput.Text += "youtube";
            }
         else
            {
                tbxoutput.Text = tbxoutput.Text.Replace("youtube", "");
            }
        }

        private void chkInstagram_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstagram.Checked) 
            {
                tbxoutput.Text += "instagram";
            }
            else
            {
                tbxoutput.Text = tbxoutput.Text.Replace("instagram", "");
            }
            btnGo3.Show();
            if (!chkInstagram.Checked)
            {
                btnGo3.Hide();
            }
          
               
            
            
        
        }

        private void chksteam_CheckedChanged(object sender, EventArgs e)
        {
            if (chksteam.Checked)
            {
                tbxoutput.Text += "steam";
            }
            else
            {
                tbxoutput.Text = tbxoutput.Text.Replace("steam", "");

                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnGo3.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btngo1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnGo4.Hide();

        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            btnGo2.Hide();
        }
    }
}
