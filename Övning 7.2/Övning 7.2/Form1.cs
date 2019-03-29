using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxInput_changed(object sender, EventArgs e)
        {
            if (tbxInput.Text != "")
            {
                Random random = new Random();
                double age = double.Parse(tbxInput.Text);
                int cost = 0;
                String output = "";

                if (random.Next(0, 1) == 0)
                {
                    if (age >= 15 && age <= 65)
                    {
                        cost = 20;
                    }
                    else
                    {
                        cost = 10;
                    }
                }
                else
                {
                    if (age < 10 || age > 65)
                    {
                        cost = 10;
                    }
                    else
                    {
                        cost = 20;
                    }
                }

                output = "Det kostar " + cost.ToString() + " kr.";
                lblOutput.Text = output;
            }
        }
    }
}
