using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_click(object sender, EventArgs e)
        {
            string sign = tbxSign.Text;

            int code = (int)sign[0];

            string result = sign + " har Unicode-nummret " + code;
            lblOutput.Text = result;
        }
    }
}
