namespace Övning_10._2
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.tbxRadius = new System.Windows.Forms.TextBox();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbxVolume = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(12, 16);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(38, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radie:";
            // 
            // tbxRadius
            // 
            this.tbxRadius.Location = new System.Drawing.Point(79, 13);
            this.tbxRadius.Name = "tbxRadius";
            this.tbxRadius.Size = new System.Drawing.Size(100, 20);
            this.tbxRadius.TabIndex = 1;
            this.tbxRadius.TextChanged += new System.EventHandler(this.tbxRadius_TextChanged);
            // 
            // tbxHeight
            // 
            this.tbxHeight.Location = new System.Drawing.Point(79, 39);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(100, 20);
            this.tbxHeight.TabIndex = 3;
            this.tbxHeight.TextChanged += new System.EventHandler(this.tbxHeight_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 42);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(29, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Höjd";
            // 
            // tbxVolume
            // 
            this.tbxVolume.Enabled = false;
            this.tbxVolume.Location = new System.Drawing.Point(79, 65);
            this.tbxVolume.Name = "tbxVolume";
            this.tbxVolume.Size = new System.Drawing.Size(100, 20);
            this.tbxVolume.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 65);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(61, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Volym";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 98);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxVolume);
            this.Controls.Add(this.tbxHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.tbxRadius);
            this.Controls.Add(this.lblRadius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox tbxRadius;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbxVolume;
        private System.Windows.Forms.Button btnCalculate;
    }
}

