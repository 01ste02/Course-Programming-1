using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tbxInput.Text);
            double cost = 0;
            String output = "";

            if (num <= 10)
            {
                cost = 9.90 * num; // no discount
            } else if (num > 10 && num <= 50)
            {
                cost = 9.90 * num * 0.95; // 5 % discount
            } else if (num > 50 && num <= 100)
            {
                cost = 9.90 * num * 0.90; // 10 % discount
            } else if (num > 100)
            {
                cost = 9.90 * num * 0.85; // 15 % discount
            }

            output = "Kostnaden för " + num.ToString() + " skivor är " + cost.ToString() + " kronor.";
            lblOutput.Text = output;
        }
    }
}