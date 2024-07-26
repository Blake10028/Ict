namespace File_Calculator
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
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.ofdFoldFinder = new System.Windows.Forms.OpenFileDialog();
            this.lblanwer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(400, 140);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 0;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(400, 111);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 1;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(124, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(43, 140);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(43, 114);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(337, 20);
            this.tbxInput.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Enter Comma Seperated Values";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(271, 209);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(74, 20);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Output: ";
            // 
            // ofdFoldFinder
            // 
            this.ofdFoldFinder.FileName = "ofdFinder";
            // 
            // lblanwer
            // 
            this.lblanwer.AutoSize = true;
            this.lblanwer.Location = new System.Drawing.Point(345, 214);
            this.lblanwer.Name = "lblanwer";
            this.lblanwer.Size = new System.Drawing.Size(16, 13);
            this.lblanwer.TabIndex = 9;
            this.lblanwer.Text = "...";
            this.lblanwer.Click += new System.EventHandler(this.lblanwer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 261);
            this.Controls.Add(this.lblanwer);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnAverage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.OpenFileDialog ofdFoldFinder;
        private System.Windows.Forms.Label lblanwer;
    }
}

