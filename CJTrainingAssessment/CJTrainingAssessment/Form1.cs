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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = tbxUser.Text;
            string pass = tbxPass.Text;
            string[] people = Directory.GetFiles("people/");



            //admin login 
            if (User == "1935538")
            { 
                //password for admin
                if(pass == "26346")
                {
                    //change the form size and show admin buttons and meuns
                    this.MaximumSize = new Size(576, 491);
                    this.MinimumSize = new Size(576, 491);
                    Form1.ActiveForm.Size = new Size(576, 491);
                    btnAdd.Visible = true;                   
                    lbxPeople.Visible = true;                    
                    for (int i = 0; i < people.Length; i++)
                    {
                        lbxPeople.Items.Add(people[i].Split('/')[1].Split ('.')[0]);
                    
                    }
                    
                        

                }
            
            }
            //code of login in if you are not the admin 
            else
            { 
                //looking for the persons text file
                using (StreamReader reader = new StreamReader($"people/{tbxUser.Text}.CJTrain"))
                {
                    //making the first line/ the password on the text a string so i can chack if its right
                    string passwordfromfile = reader.ReadLine();

                    //check if the user password = his password 
                            if (pass == passwordfromfile)
                    {
                        //change the size and shows all the information in his text file
                        this.MaximumSize = new Size(576, 491);
                        this.MinimumSize = new Size(576, 491);
                        Form1.ActiveForm.Size = new Size(576, 491);
                        rtbInformtion.AppendText(reader.ReadToEnd());
                        
                        
                    }
                            //tell the user they have got something worry 
                            else
                    {
                        MessageBox.Show($"sorry the username or password is worry try again");
                    }

                    

                }
            }



        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //close the form 
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //so the admin can make new user 
            StreamWriter ns = new StreamWriter($"people/{tbxUser.Text}.CJTrain",false);
            ns.WriteLine($"{tbxPass.Text}");
            ns.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //shows the student that has been clicked on there informtion
            using (StreamReader reader = new StreamReader($"people/{lbxPeople.Text}.CJTrain"))
            {

                rtbInformtion.Clear();
                reader.ReadLine();
                rtbInformtion.AppendText(reader.ReadToEnd());
            }
        
    }

        private void tbxPeople_TextChanged(object sender, EventArgs e)
        {
            

           
            
        }

        private void lbxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxPeople_DoubleClick(object sender, EventArgs e)
        {
            CJTrainingEdit bob = new CJTrainingEdit();
            bob.Show();
            bob.file = ($"people/{lbxPeople.Text}.CJTrain");
            bob.Load();
        }

        private void rtbInformtion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
