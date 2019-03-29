using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_click(object sender, EventArgs e)
        {
            int newX = int.Parse(tbxX.Text);
            int newY = int.Parse(tbxY.Text);

            Point newPoint = new Point(newX, newY);
            btnRun.Location = newPoint;
        }
    }
}
