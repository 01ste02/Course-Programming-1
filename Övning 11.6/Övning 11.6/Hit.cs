using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Övning_11._6
{
    class Hit
    {
        private int x;
        private int y;
        private int radius = 9;

        public Hit (int X, int Y, int Radius = 9)
        {
            x = X;
            y = Y;
            radius = Radius;
        }

        public void Draw ( Graphics g )
        {
            Brush white = Brushes.White;
            Pen black = Pens.Black;

            g.FillEllipse(white, x - (radius / 2), y - (radius / 2), radius, radius);
            g.DrawEllipse(black, x - ((radius + 1) / 2), y - ((radius + 1) / 2), radius + 1, radius + 1);
        }

    }
}
