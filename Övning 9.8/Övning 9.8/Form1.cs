using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.Blue);
            int x = 10;
            int y = 10;
            int size = 10;

            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    g.FillEllipse(brush, x, y, size, size);
                    x += 10 + size;
                }

                y += 10 + size;
                x = 10;
            }
        }
    }
}
