namespace array
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
            this.btnnames = new System.Windows.Forms.Button();
            this.btnjob = new System.Windows.Forms.Button();
            this.lbljob = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnnames
            // 
            this.btnnames.Location = new System.Drawing.Point(12, 72);
            this.btnnames.Name = "btnnames";
            this.btnnames.Size = new System.Drawing.Size(75, 23);
            this.btnnames.TabIndex = 0;
            this.btnnames.Text = "person";
            this.btnnames.UseVisualStyleBackColor = true;
            this.btnnames.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnjob
            // 
            this.btnjob.Location = new System.Drawing.Point(197, 72);
            this.btnjob.Name = "btnjob";
            this.btnjob.Size = new System.Drawing.Size(75, 23);
            this.btnjob.TabIndex = 1;
            this.btnjob.Text = "Job";
            this.btnjob.UseVisualStyleBackColor = true;
            this.btnjob.Click += new System.EventHandler(this.btnjob_Click);
            // 
            // lbljob
            // 
            this.lbljob.AutoSize = true;
            this.lbljob.Location = new System.Drawing.Point(237, 129);
            this.lbljob.Name = "lbljob";
            this.lbljob.Size = new System.Drawing.Size(24, 13);
            this.lbljob.TabIndex = 2;
            this.lbljob.Text = "Job";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(12, 129);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(40, 13);
            this.lblPerson.TabIndex = 3;
            this.lblPerson.Text = "Person";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.lbljob);
            this.Controls.Add(this.btnjob);
            this.Controls.Add(this.btnnames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnames;
        private System.Windows.Forms.Button btnjob;
        private System.Windows.Forms.Label lbljob;
        private System.Windows.Forms.Label lblPerson;
    }
}

