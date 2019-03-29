using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._3
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

            Pen pen = new Pen(Color.CadetBlue);

            int width = 10;
            int coord = 250;

            do
            {
                g.DrawEllipse(pen, coord, coord, width, width);
                width += 10;
                coord -= 5;
            } while (width < 101);
        }
    }
}
