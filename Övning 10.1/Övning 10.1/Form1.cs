using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double calculate(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double error;
            if (double.TryParse(tbxRadius.Text, out error))
            {
                double radius = double.Parse(tbxRadius.Text);
                tbxArea.Text = calculate(radius).ToString();
            }
        }

        private void tbxRadius_TextChanged(object sender, EventArgs e)
        {
            tbxArea.Text = "";
        }
    }
}
