using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    public partial class Form1 : Form
    {
        int start;
        int end;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            start = int.Parse(tbxStart.Text);
            end = int.Parse(tbxEnd.Text);
             
            for(int i = start; i < end; i++)
            {
                for (int x = end; x <2; x++)
                {
                    end++;
                }
            }
            lbxResult.Show($"{start}x{end}={lbxResult.Items}");
                
                
        }

        private void lsb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
