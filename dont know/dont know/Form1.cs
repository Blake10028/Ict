using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dont_know
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            InitializeComponent();
            var timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();


            Form2 level = new Form2();

            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            level.Show();

        }

    
        private void timer1_Tick(object sender, EventArgs e)
        {
            var colors = new[] { Color.Yellow, Color.Green, Color.Red, Color.Orange, Color.Blue, Color.Pink, Color.Purple };
            var index = DateTime.Now.Millisecond % colors.Length;
            this.BackColor = colors[index];
        }

        private void label1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            var timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

