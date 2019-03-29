using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunClick(object sender, EventArgs e)
        {
            string swe = tbxSwe.Text;
            string eng = tbxEng.Text;

            string output = swe + " betyder " + eng + " på engelska.";
            lblOutput.Text = output;
        }
    }
}
