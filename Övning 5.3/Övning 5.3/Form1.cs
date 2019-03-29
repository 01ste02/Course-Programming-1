using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_click(object sender, EventArgs e)
        {
            double funds = double.Parse(tbxFunds.Text);
            double cost = double.Parse(tbxCost.Text);

            bool enough = funds > cost;

            lblOutput.Text = enough.ToString();
        }
    }
}
