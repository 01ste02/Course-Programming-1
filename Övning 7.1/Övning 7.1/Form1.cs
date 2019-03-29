using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxInput_update(object sender, EventArgs e)
        {
            String output = "";
            double gasLevel = 50;

            if (tbxInput.Text != "")
            {
                gasLevel = double.Parse(tbxInput.Text);

                if (gasLevel < 10)
                {
                    double fuelUp = 50 - gasLevel;
                    double cost = fuelUp * 14.5;
                    output = "Tanka " + fuelUp.ToString() + " liter. Det kostar " + cost.ToString() + " kr.";
                }
                else if (gasLevel >= 10)
                {
                    output = "Kör vidare.";
                }
            } else
            {
                output = "Mata in en giltig mängd bensin";
            }

            lblOutput.Text = output;
        }
    }
}
