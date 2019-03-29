using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            int birthYear = int.Parse(tbxYear.Text);

            int year = birthYear + 50;
            string result = "År " + year.ToString() + " fyller " + name + " 50 år!";
            lblOutput.Text = result;
        }
    }
}
