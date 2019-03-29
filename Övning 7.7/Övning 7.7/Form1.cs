using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_click(object sender, EventArgs e)
        {
            float num1 = float.Parse(tbxNum1.Text);
            float num2 = float.Parse(tbxNum2.Text);
            float result;

            String output;
            
            if (num1 < num2)
            {
                result = num1;
            } else
            {
                result = num2;
            }

            output = "Det minsta talet är " + result.ToString();
            lblOutput.Text = output;
        }
    }
}
