using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            String[] buffer = new String[3];
            buffer[0] = tbx1.Text;
            buffer[1] = tbx2.Text;
            buffer[2] = tbx3.Text;

            tbx1.Text = buffer[2];
            tbx2.Text = buffer[0];
            tbx3.Text = buffer[1];
        }
    }
}
