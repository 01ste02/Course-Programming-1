namespace Övning_11._2
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
            this.tbxRadius = new System.Windows.Forms.TextBox();
            this.btnRadius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxRadius
            // 
            this.tbxRadius.Location = new System.Drawing.Point(299, 418);
            this.tbxRadius.Name = "tbxRadius";
            this.tbxRadius.Size = new System.Drawing.Size(100, 20);
            this.tbxRadius.TabIndex = 0;
            // 
            // btnRadius
            // 
            this.btnRadius.Location = new System.Drawing.Point(424, 418);
            this.btnRadius.Name = "btnRadius";
            this.btnRadius.Size = new System.Drawing.Size(75, 20);
            this.btnRadius.TabIndex = 1;
            this.btnRadius.Text = "Sätt radie";
            this.btnRadius.UseVisualStyleBackColor = true;
            this.btnRadius.Click += new System.EventHandler(this.btnRadius_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRadius);
            this.Controls.Add(this.tbxRadius);
            this.Name = "Form1";
            this.Text = "Övning";
            this.ResizeEnd += new System.EventHandler(this.updateCoords);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRadius;
        private System.Windows.Forms.Button btnRadius;
    }
}

