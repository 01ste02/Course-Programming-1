using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_click(object sender, EventArgs e)
        {
            int A = int.Parse(tbxA.Text);
            int B = int.Parse(tbxB.Text);
            int C = int.Parse(tbxC.Text);

            bool order = A < B && B < C;
            lblOutput.Text = order.ToString();
        }
    }
}
