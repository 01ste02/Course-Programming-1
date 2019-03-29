namespace Övning_7._6
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
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tbxName1 = new System.Windows.Forms.TextBox();
            this.tbxName2 = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(13, 13);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(47, 13);
            this.lblName1.TabIndex = 0;
            this.lblName1.Text = "Namn 1:";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(12, 42);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(47, 13);
            this.lblName2.TabIndex = 1;
            this.lblName2.Text = "Namn 2:";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.Info;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(12, 70);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(154, 19);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxName1
            // 
            this.tbxName1.Location = new System.Drawing.Point(66, 10);
            this.tbxName1.Name = "tbxName1";
            this.tbxName1.Size = new System.Drawing.Size(100, 20);
            this.tbxName1.TabIndex = 3;
            // 
            // tbxName2
            // 
            this.tbxName2.Location = new System.Drawing.Point(66, 39);
            this.tbxName2.Name = "tbxName2";
            this.tbxName2.Size = new System.Drawing.Size(100, 20);
            this.tbxName2.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(44, 102);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(90, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Jämför namnen";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 132);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbxName2);
            this.Controls.Add(this.tbxName1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox tbxName1;
        private System.Windows.Forms.TextBox tbxName2;
        private System.Windows.Forms.Button btnRun;
    }
}

