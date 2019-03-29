using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int start = int.Parse(tbxStart.Text);
            int end = int.Parse(tbxEnd.Text);
            int steps = int.Parse(tbxSteps.Text);
            String output = start.ToString();

            for (int i = 1; i < (((end - start)/steps) + 1); i++ )
            {
                output += " " + (start + steps * i);
            }
            tbxOutput.Text = output;
        }
    }
}
