namespace Övning_13._3
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
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnExpedite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Namn: ";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(99, 20);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(194, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxOutput
            // 
            this.tbxOutput.Enabled = false;
            this.tbxOutput.Location = new System.Drawing.Point(15, 53);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(278, 20);
            this.tbxOutput.TabIndex = 2;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(15, 79);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(125, 23);
            this.btnNewCustomer.TabIndex = 3;
            this.btnNewCustomer.Text = "Ny kund";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnExpedite
            // 
            this.btnExpedite.Location = new System.Drawing.Point(158, 79);
            this.btnExpedite.Name = "btnExpedite";
            this.btnExpedite.Size = new System.Drawing.Size(135, 23);
            this.btnExpedite.TabIndex = 4;
            this.btnExpedite.Text = "Expediera kund";
            this.btnExpedite.UseVisualStyleBackColor = true;
            this.btnExpedite.Click += new System.EventHandler(this.btnExpedite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 118);
            this.Controls.Add(this.btnExpedite);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnExpedite;
    }
}

