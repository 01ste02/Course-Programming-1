using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Övning_11._5
{
    public class TargetBoard
    {
        private int radius = 0;
        private int x = 0;
        private int y = 0;

        private Point position = new Point(0, 0);

        public TargetBoard (int xcoord = 0, int ycoord = 0, int r = 0)
        {
            if (xcoord < 0)
            {
                position.X = -xcoord;
            }
            else
            {
                position.X = xcoord;
            }

            if (ycoord < 0)
            {
                position.Y = -ycoord;
            }
            else
            {
                position.Y = ycoord;
            }

            if (radius < 0)
            {
                radius = -r;
            }
            else
            {
                radius = r;
            }
        }

        public void Draw ( Graphics g )
        {
            Pen black = new Pen(Brushes.Black, 4);
            g.FillEllipse(Brushes.White, x - radius, y - radius, radius * 2, radius * 2);
            g.FillEllipse(Brushes.Black, x - (float)(0.8 * radius), y - (float)(0.8 * radius), (float)(0.8 * radius * 2), (float)(0.8 * radius * 2));
            g.FillEllipse(Brushes.Blue, x - (float)(0.6 * radius), y - (float)(0.6 * radius), (float)(0.6 * radius * 2), (float)(0.6 * radius * 2));
            g.FillEllipse(Brushes.Red, x - (float)(0.4 * radius), y - (float)(0.4 * radius), (float)(0.4 * radius * 2), (float)(0.4 * radius * 2));
            g.FillEllipse(Brushes.Yellow, x - (float)(0.2 * radius), y - (float)(0.2 * radius), (float)(0.2 * radius * 2), (float)(0.2 * radius * 2));
            g.DrawEllipse(Pens.Black, x - radius, y - radius, radius * 2, radius * 2);
        }



        public int Radius
        {
            get { return radius; }
            set {
                if (value < 0)
                {
                    radius = -value;
                }
                else
                {
                    radius = value;
                }
             }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return Y; }
            set { y = value; }
        }

        public Point Position
        {
            get { return position; }
            set
            {
                if (value.X < 0)
                {
                    position.X = -value.X;
                }
                else
                {
                    position.X = value.X;
                }

                if (value.Y < 0)
                {
                    position.Y = -value.Y;
                }
                else
                {
                    position.Y = value.Y;
                }
             }
        }
     }
}
