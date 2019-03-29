using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_click(object sender, EventArgs e)
        {
            string firstName = tbxFirstN.Text;
            string surName = tbxSurN.Text;

            string result = firstName + " " + surName + " har initialerna " + firstName[0] + "." + surName[0] + ".";

            lblOutput.Text = result;
        }
    }
}
