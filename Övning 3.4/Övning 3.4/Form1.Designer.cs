namespace Övning_3._4
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
            this.btnRun = new System.Windows.Forms.Button();
            this.tbxSwe = new System.Windows.Forms.TextBox();
            this.tbxEng = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.lblSwe = new System.Windows.Forms.Label();
            this.lblEng = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(136, 104);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Kör";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRunClick);
            // 
            // tbxSwe
            // 
            this.tbxSwe.Location = new System.Drawing.Point(126, 27);
            this.tbxSwe.Name = "tbxSwe";
            this.tbxSwe.Size = new System.Drawing.Size(100, 20);
            this.tbxSwe.TabIndex = 1;
            // 
            // tbxEng
            // 
            this.tbxEng.Location = new System.Drawing.Point(126, 57);
            this.tbxEng.Name = "tbxEng";
            this.tbxEng.Size = new System.Drawing.Size(100, 20);
            this.tbxEng.TabIndex = 2;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(41, 146);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(32, 13);
            this.lblAns.TabIndex = 3;
            this.lblAns.Text = "Svar:";
            // 
            // lblSwe
            // 
            this.lblSwe.AutoSize = true;
            this.lblSwe.Location = new System.Drawing.Point(41, 30);
            this.lblSwe.Name = "lblSwe";
            this.lblSwe.Size = new System.Drawing.Size(55, 13);
            this.lblSwe.TabIndex = 4;
            this.lblSwe.Text = "Svenska: ";
            // 
            // lblEng
            // 
            this.lblEng.AutoSize = true;
            this.lblEng.Location = new System.Drawing.Point(41, 60);
            this.lblEng.Name = "lblEng";
            this.lblEng.Size = new System.Drawing.Size(54, 13);
            this.lblEng.TabIndex = 5;
            this.lblEng.Text = "Engelska:";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.Info;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(79, 146);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(198, 23);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 190);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblEng);
            this.Controls.Add(this.lblSwe);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.tbxEng);
            this.Controls.Add(this.tbxSwe);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbxSwe;
        private System.Windows.Forms.TextBox tbxEng;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Label lblSwe;
        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.Label lblOutput;
    }
}

