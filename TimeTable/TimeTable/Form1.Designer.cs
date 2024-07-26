namespace TimeTable
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
            this.btnGo = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.tbxEnd = new System.Windows.Forms.TextBox();
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.lbxResult = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.AccessibleName = "";
            this.btnGo.Location = new System.Drawing.Point(245, 256);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(194, 120);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(42, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start At";
            this.lblStart.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(194, 165);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(39, 13);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "End At";
            // 
            // tbxEnd
            // 
            this.tbxEnd.Location = new System.Drawing.Point(269, 158);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.Size = new System.Drawing.Size(141, 20);
            this.tbxEnd.TabIndex = 3;
            // 
            // tbxStart
            // 
            this.tbxStart.Location = new System.Drawing.Point(269, 113);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(141, 20);
            this.tbxStart.TabIndex = 4;
            // 
            // lbxResult
            // 
            this.lbxResult.FormattingEnabled = true;
            this.lbxResult.Location = new System.Drawing.Point(141, 285);
            this.lbxResult.Name = "lbxResult";
            this.lbxResult.Size = new System.Drawing.Size(304, 160);
            this.lbxResult.TabIndex = 5;
            this.lbxResult.SelectedIndexChanged += new System.EventHandler(this.lsb_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(269, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(194, 217);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(48, 13);
            this.lblMultiplier.TabIndex = 8;
            this.lblMultiplier.Text = "Multiplier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbxResult);
            this.Controls.Add(this.tbxStart);
            this.Controls.Add(this.tbxEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnGo);
            this.Name = "Form1";
            this.Text = "TimeTable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox tbxEnd;
        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.ListBox lbxResult;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMultiplier;
    }
}

