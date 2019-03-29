using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_11._5
{
    public partial class Form1 : Form
    {
        TargetBoard target = new TargetBoard();
        Sight sight = new Sight();

        public Form1 ()
        {
            InitializeComponent();
            DoubleBuffered = true;
            target.X = ClientSize.Width / 2;
            target.Y = ClientSize.Height / 2;
            target.Radius = 50;
        }

        private void updateCoords (object sender, EventArgs e)
        {
            target.X = ClientSize.Width / 2;
            target.Y = ClientSize.Height / 2;
        }

        protected override void OnPaint (PaintEventArgs e)
        {
            target.Draw(e.Graphics);
            sight.Draw(e.Graphics);
        }

        protected override void OnMouseMove (MouseEventArgs e)
        {
            sight.X = e.X;
            sight.Y = e.Y;
            Invalidate();
        }
    }
}
