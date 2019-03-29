using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_10._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool draw = false;

        void drawTriangle (Graphics g, int height)
        {
            Color red = Color.FromArgb(255, 0, 0);
            Brush redBrush = new SolidBrush(red);

            int x = 200;
            int y = 19;

            for (int i = 0; i < height; i++)
            {
                x = 200;
                y += 31;
                for (int j = 0; j < (i + 1); j++)
                {
                    g.FillEllipse(redBrush, x, y, 30, 30);
                    x -= 31;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int error;
            if (int.TryParse(tbxHeight.Text, out error) && draw)
            {
                Graphics g = e.Graphics;
                int height = int.Parse(tbxHeight.Text);
                drawTriangle(g, height);
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            draw = true;
            Invalidate();
        }
    }
}
