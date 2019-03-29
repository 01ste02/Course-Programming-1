using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Övning_11._4
{
    public partial class TargetPractice : Form
    {
        TargetBoard target = new TargetBoard();
        Sight sight = new Sight();
        public TargetPractice ()
        {
            InitializeComponent();
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

        private void btnUp_Click (object sender, EventArgs e)
        {
            sight.MoveY(-1);
            Invalidate();
        }

        private void btnDown_Click (object sender, EventArgs e)
        {
            sight.MoveY(1);
            Invalidate();
        }

        private void btnLeft_Click (object sender, EventArgs e)
        {
            sight.MoveX(-1);
            Invalidate();
        }

        private void btnRight_Click (object sender, EventArgs e)
        {
            sight.MoveX(1);
            Invalidate();
        }
    }
}
