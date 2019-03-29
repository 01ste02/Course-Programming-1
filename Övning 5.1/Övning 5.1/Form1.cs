using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_click(object sender, EventArgs e)
        {
            int time = int.Parse(tbxTime.Text);

            int year = time / 12;
            int months = time % 12;

            string result = year.ToString() + " år och " + months.ToString() + " månader.";
            lblOutput.Text = result;
        }
    }
}
