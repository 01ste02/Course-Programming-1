namespace Övning_10._7
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
            this.tbxDice = new System.Windows.Forms.TextBox();
            this.btnThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxDice
            // 
            this.tbxDice.Location = new System.Drawing.Point(31, 42);
            this.tbxDice.Multiline = true;
            this.tbxDice.Name = "tbxDice";
            this.tbxDice.Size = new System.Drawing.Size(188, 154);
            this.tbxDice.TabIndex = 0;
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(31, 13);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(188, 23);
            this.btnThrow.TabIndex = 1;
            this.btnThrow.Text = "Kasta Tärningarna";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 208);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.tbxDice);
            this.Name = "Form1";
            this.Text = "Övning 10.7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDice;
        private System.Windows.Forms.Button btnThrow;
    }
}

