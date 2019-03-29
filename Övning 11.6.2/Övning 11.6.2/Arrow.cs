using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Övning_11._6
{
    class Arrow
    {
        private int x;
        private int y;
        private int radius = 9;
        Brush brush;

        public Arrow (int X, int Y, Brush brushTemp, int Radius = 9)
        {
            x = X;
            y = Y;
            radius = Radius;
            brush = brushTemp;
        }

        public void Draw ( Graphics g )
        {
            Pen pen = new Pen(brush, 3);

            g.DrawLine(pen, x - (radius / 1), y - (radius / 1), x + (radius / 1), y + (radius / 1));
            g.DrawLine(pen, x - (radius / 1), y + (radius / 1), x + (radius / 1), y - (radius / 1));
        }

    }
}
