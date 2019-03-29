using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Read(ref double radius, ref double height)
        {
            double error;
            if (double.TryParse(tbxHeight.Text, out error) && double.TryParse(tbxRadius.Text, out error))
            {
                height = double.Parse(tbxHeight.Text);
                radius = double.Parse(tbxRadius.Text);
            }
            return radius;
        }

        double calculateCylinderVolume(double radius, double height)
        {
            double volume = Math.PI * radius * radius * height;
            return volume;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double radius = 0;
            double height = 0;
            Read(ref radius, ref height);
            tbxVolume.Text = calculateCylinderVolume(radius, height).ToString();
        }

        private void tbxRadius_TextChanged(object sender, EventArgs e)
        {
            tbxVolume.Text = "";
        }

        private void tbxHeight_TextChanged(object sender, EventArgs e)
        {
            tbxVolume.Text = "";
        }
    }
}
