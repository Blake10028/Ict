using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array
{
    public partial class Form1 : Form
    {
        string[] _Person;
        string[] _Job;
        public Form1()
        {
            InitializeComponent();

            _Person = new string[] { "Blake", "Mason", "Anton", "Sarah", "m", "d" };
            _Job = new string[10];

            _Job[0] = "clean";
            _Job[1] = "clean";
            _Job[2] = "clean";
            _Job[3] = "clean";
            _Job[4] = "clean";
            _Job[5] = "clean";
            _Job[6] = "clean";
            _Job[7] = "clean";
            _Job[8] = "clean";
            _Job[9] = "clean";               
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int selection = rng.Next(0, _Person.Count());

            lblPerson.Text = _Person[selection];
        }

        private void btnjob_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int selection = rng.Next(0, _Job.Count());

            lbljob.Text = _Job[selection];
        }
    }
}
