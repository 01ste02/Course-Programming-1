using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            String name1 = tbxName1.Text;
            String name2 = tbxName2.Text;
            String output = "";

            if (name1.CompareTo(name2) < 0)
            {
                output = name1 + " " + name2;
            } else if (name1.CompareTo(name2) > 0)
            {
                output = name2 + " " + name1;
            } else
            {
                output = name1 + " " + name2;
            }

            lblOutput.Text = output;
        }
    }
}
