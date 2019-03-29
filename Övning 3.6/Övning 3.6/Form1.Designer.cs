namespace Övning_3._6
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
            this.tbxFirstN = new System.Windows.Forms.TextBox();
            this.tbxSurN = new System.Windows.Forms.TextBox();
            this.lblFirstN = new System.Windows.Forms.Label();
            this.lblSurN = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxFirstN
            // 
            this.tbxFirstN.Location = new System.Drawing.Point(116, 40);
            this.tbxFirstN.Name = "tbxFirstN";
            this.tbxFirstN.Size = new System.Drawing.Size(100, 20);
            this.tbxFirstN.TabIndex = 0;
            // 
            // tbxSurN
            // 
            this.tbxSurN.Location = new System.Drawing.Point(116, 79);
            this.tbxSurN.Name = "tbxSurN";
            this.tbxSurN.Size = new System.Drawing.Size(100, 20);
            this.tbxSurN.TabIndex = 1;
            // 
            // lblFirstN
            // 
            this.lblFirstN.AutoSize = true;
            this.lblFirstN.Location = new System.Drawing.Point(41, 43);
            this.lblFirstN.Name = "lblFirstN";
            this.lblFirstN.Size = new System.Drawing.Size(48, 13);
            this.lblFirstN.TabIndex = 2;
            this.lblFirstN.Text = "Förnamn";
            // 
            // lblSurN
            // 
            this.lblSurN.AutoSize = true;
            this.lblSurN.Location = new System.Drawing.Point(41, 82);
            this.lblSurN.Name = "lblSurN";
            this.lblSurN.Size = new System.Drawing.Size(55, 13);
            this.lblSurN.TabIndex = 3;
            this.lblSurN.Text = "Efternamn";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.Info;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(44, 155);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(172, 23);
            this.lblOutput.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kör";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRun_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblSurN);
            this.Controls.Add(this.lblFirstN);
            this.Controls.Add(this.tbxSurN);
            this.Controls.Add(this.tbxFirstN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFirstN;
        private System.Windows.Forms.TextBox tbxSurN;
        private System.Windows.Forms.Label lblFirstN;
        private System.Windows.Forms.Label lblSurN;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button button1;
    }
}

