namespace CJTrainingAssessment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtbInformtion = new System.Windows.Forms.RichTextBox();
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblInformtion = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(29, 54);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "UserName";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(29, 104);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(88, 51);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(100, 20);
            this.tbxUser.TabIndex = 2;
            this.tbxUser.TextChanged += new System.EventHandler(this.tbxUser_TextChanged);
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(88, 101);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(100, 20);
            this.tbxPass.TabIndex = 3;
            this.tbxPass.TextChanged += new System.EventHandler(this.tbxPass_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(113, 141);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(113, 171);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbInformtion
            // 
            this.rtbInformtion.Location = new System.Drawing.Point(261, 51);
            this.rtbInformtion.Name = "rtbInformtion";
            this.rtbInformtion.Size = new System.Drawing.Size(222, 378);
            this.rtbInformtion.TabIndex = 7;
            this.rtbInformtion.Text = "";
            this.rtbInformtion.TextChanged += new System.EventHandler(this.rtbInformtion_TextChanged);
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.Location = new System.Drawing.Point(12, 279);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(210, 147);
            this.lbxPeople.TabIndex = 8;
            this.lbxPeople.Visible = false;
            this.lbxPeople.Click += new System.EventHandler(this.button1_Click);
            this.lbxPeople.SelectedIndexChanged += new System.EventHandler(this.lbxPeople_SelectedIndexChanged);
            this.lbxPeople.DoubleClick += new System.EventHandler(this.lbxPeople_DoubleClick);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(9, 6);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(104, 16);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "CJTraining 2019";
            // 
            // lblInformtion
            // 
            this.lblInformtion.AutoSize = true;
            this.lblInformtion.Location = new System.Drawing.Point(258, 38);
            this.lblInformtion.Name = "lblInformtion";
            this.lblInformtion.Size = new System.Drawing.Size(93, 13);
            this.lblInformtion.TabIndex = 11;
            this.lblInformtion.Text = "Student Informtion";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(12, 263);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(49, 13);
            this.lblStudents.TabIndex = 12;
            this.lblStudents.Text = "Students";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 452);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblInformtion);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbxPeople);
            this.Controls.Add(this.rtbInformtion);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.MinimumSize = new System.Drawing.Size(233, 272);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtbInformtion;
        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblInformtion;
        private System.Windows.Forms.Label lblStudents;
    }
}

