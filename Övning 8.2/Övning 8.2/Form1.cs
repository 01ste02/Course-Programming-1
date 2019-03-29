using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string status = "green";

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush, 22, 40, 75, 139);

            if (status == "red")
            {
                brush.Color = Color.Red;
                g.FillEllipse(brush, 35, 53, 50, 50);
                status = "green";
            }
            else if (status == "green")
            {
                brush.Color = Color.Green;
                g.FillEllipse(brush, 35, 116, 50, 50);
                status = "red";
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
