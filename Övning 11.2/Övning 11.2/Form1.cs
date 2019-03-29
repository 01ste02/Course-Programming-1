using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_11._2
{
    public partial class Form1 : Form
    {
        TargetBoard target = new TargetBoard();

        public Form1 ()
        {
            InitializeComponent();
            target.X = ClientSize.Width / 2;
            target.Y = ClientSize.Height / 2;
            target.Radius = 50;
        }

        private void btnRadius_Click (object sender, EventArgs e)
        {
            if (int.TryParse(tbxRadius.Text, out int radius))
            {
                target.Radius = radius;
                Invalidate();
            }
        }

        private void updateCoords ( object sender, EventArgs e)
        {
            target.X = ClientSize.Width / 2;
            target.Y = ClientSize.Height / 2;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            target.Draw( e.Graphics );
        }
    }
}
