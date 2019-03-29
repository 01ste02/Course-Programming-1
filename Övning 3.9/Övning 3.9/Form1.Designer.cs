namespace Övning_3._9
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.tbxX = new System.Windows.Forms.TextBox();
            this.tbxY = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(59, 13);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(64, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X-koordinat:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(151, 13);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(64, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y-koordinat:";
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(62, 30);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(61, 20);
            this.tbxX.TabIndex = 2;
            // 
            // tbxY
            // 
            this.tbxY.Location = new System.Drawing.Point(154, 29);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(61, 20);
            this.tbxY.TabIndex = 3;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(62, 56);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(61, 23);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Kör";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbxY);
            this.Controls.Add(this.tbxX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.TextBox tbxY;
        private System.Windows.Forms.Button btnRun;
    }
}

