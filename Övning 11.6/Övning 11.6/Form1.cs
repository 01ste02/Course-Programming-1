using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_11._6
{
    public partial class Form1 : Form
    {
        TargetBoard target = new TargetBoard();
        Sight sight = new Sight();
        Arrow[] arrow = new Arrow[5];
        int arrowCount = 5;

        public Form1 ()
        {
            InitializeComponent();
            DoubleBuffered = true;
            target.X = ClientSize.Width / 2;
            target.Y = ClientSize.Height / 2;
            target.Radius = 100;
            lblArrowCount.Text = arrowCount.ToString();
        }

        private void updateCoords (object sender, EventArgs e)
        {
            target.X = ClientSize.Width / 2;
            target.Y = ClientSize.Height / 2;
            Invalidate();
        }

        protected override void OnPaint (PaintEventArgs e)
        {
            target.Draw(e.Graphics);
            sight.Draw(e.Graphics);

            for (int i = 0; i < arrow.Length; i++)
            {
                if (arrow[i] != null)
                {
                    arrow[i].Draw(e.Graphics);
                }
            }
        }

        protected override void OnMouseMove (MouseEventArgs e)
        {
            sight.X = e.X;
            sight.Y = e.Y;
            Invalidate();
        }

        protected override void OnMouseUp (MouseEventArgs e)
        {
            if (arrowCount > 0)
            {
                arrow[5 - arrowCount] = new Arrow(e.X, e.Y);
                arrowCount--;
                lblArrowCount.Text = arrowCount.ToString();
                Invalidate();
            }
            else
            {
                MessageBox.Show(this, "You have used all of your arrows!", "Out of arrows", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
