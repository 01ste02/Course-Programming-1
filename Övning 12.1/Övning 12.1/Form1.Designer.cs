namespace Övning_12._1
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.tbxNum1 = new System.Windows.Forms.TextBox();
            this.tbxNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.tbxNum3 = new System.Windows.Forms.TextBox();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.tbxNum4 = new System.Windows.Forms.TextBox();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.tbxNum5 = new System.Windows.Forms.TextBox();
            this.lblNum5 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(55, 13);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(38, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Num 1";
            // 
            // tbxNum1
            // 
            this.tbxNum1.Location = new System.Drawing.Point(106, 10);
            this.tbxNum1.Name = "tbxNum1";
            this.tbxNum1.Size = new System.Drawing.Size(53, 20);
            this.tbxNum1.TabIndex = 1;
            // 
            // tbxNum2
            // 
            this.tbxNum2.Location = new System.Drawing.Point(106, 39);
            this.tbxNum2.Name = "tbxNum2";
            this.tbxNum2.Size = new System.Drawing.Size(53, 20);
            this.tbxNum2.TabIndex = 3;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(55, 42);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(38, 13);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Num 2";
            // 
            // tbxNum3
            // 
            this.tbxNum3.Location = new System.Drawing.Point(106, 70);
            this.tbxNum3.Name = "tbxNum3";
            this.tbxNum3.Size = new System.Drawing.Size(53, 20);
            this.tbxNum3.TabIndex = 5;
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.Location = new System.Drawing.Point(55, 73);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(38, 13);
            this.lblNum3.TabIndex = 4;
            this.lblNum3.Text = "Num 3";
            // 
            // tbxNum4
            // 
            this.tbxNum4.Location = new System.Drawing.Point(106, 101);
            this.tbxNum4.Name = "tbxNum4";
            this.tbxNum4.Size = new System.Drawing.Size(53, 20);
            this.tbxNum4.TabIndex = 7;
            // 
            // lblNum4
            // 
            this.lblNum4.AutoSize = true;
            this.lblNum4.Location = new System.Drawing.Point(55, 104);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(38, 13);
            this.lblNum4.TabIndex = 6;
            this.lblNum4.Text = "Num 4";
            // 
            // tbxNum5
            // 
            this.tbxNum5.Location = new System.Drawing.Point(106, 135);
            this.tbxNum5.Name = "tbxNum5";
            this.tbxNum5.Size = new System.Drawing.Size(53, 20);
            this.tbxNum5.TabIndex = 9;
            // 
            // lblNum5
            // 
            this.lblNum5.AutoSize = true;
            this.lblNum5.Location = new System.Drawing.Point(55, 138);
            this.lblNum5.Name = "lblNum5";
            this.lblNum5.Size = new System.Drawing.Size(38, 13);
            this.lblNum5.TabIndex = 8;
            this.lblNum5.Text = "Num 5";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(106, 161);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(53, 23);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 200);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.tbxNum5);
            this.Controls.Add(this.lblNum5);
            this.Controls.Add(this.tbxNum4);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.tbxNum3);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.tbxNum2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.tbxNum1);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox tbxNum1;
        private System.Windows.Forms.TextBox tbxNum2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox tbxNum3;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.TextBox tbxNum4;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.TextBox tbxNum5;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Button btnSort;
    }
}

