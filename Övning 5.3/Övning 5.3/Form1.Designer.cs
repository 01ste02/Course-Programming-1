namespace Övning_5._3
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
            this.lblFunds = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.tbxFunds = new System.Windows.Forms.TextBox();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblTF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFunds
            // 
            this.lblFunds.AutoSize = true;
            this.lblFunds.Location = new System.Drawing.Point(13, 13);
            this.lblFunds.Name = "lblFunds";
            this.lblFunds.Size = new System.Drawing.Size(72, 13);
            this.lblFunds.TabIndex = 0;
            this.lblFunds.Text = "Mina pengar: ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(12, 41);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(65, 13);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "Varans pris: ";
            // 
            // tbxFunds
            // 
            this.tbxFunds.Location = new System.Drawing.Point(105, 10);
            this.tbxFunds.Name = "tbxFunds";
            this.tbxFunds.Size = new System.Drawing.Size(100, 20);
            this.tbxFunds.TabIndex = 2;
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(104, 38);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(100, 20);
            this.tbxCost.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.Info;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(105, 65);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 20);
            this.lblOutput.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(108, 94);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(96, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Kör";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_click);
            // 
            // lblTF
            // 
            this.lblTF.AutoSize = true;
            this.lblTF.Location = new System.Drawing.Point(13, 66);
            this.lblTF.Name = "lblTF";
            this.lblTF.Size = new System.Drawing.Size(80, 13);
            this.lblTF.TabIndex = 6;
            this.lblTF.Text = "Pengar räcker?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 130);
            this.Controls.Add(this.lblTF);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.tbxFunds);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblFunds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunds;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox tbxFunds;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblTF;
    }
}

