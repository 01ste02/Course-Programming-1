using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int level = int.Parse(tbxLevel.Text);
            String output = "";
            tbxOutput.Text = "";

            for (int i = 1; i < (level + 1); i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    output += (i * j).ToString() + "\t";
                }
                tbxOutput.AppendText(output + "\n");
                output = "";
            }
        }
    }
}
