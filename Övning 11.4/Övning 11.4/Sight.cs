using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Övning_11._4
{
    class Sight
    {
        private Point pos = new Point(0, 0);
        private int radius = 25;

        public Sight ()
        {

        }

        public void MoveY( int value)
        {
            pos.Y += value;
        }

        public void MoveX (int value)
        {
            pos.X += value;
        }

        public void Draw ( Graphics g)
        {
            Pen circle = new Pen(Brushes.Green, 5);
            Pen line = new Pen(Brushes.Green, 2);

            g.DrawEllipse(circle, pos.X - radius, pos.Y - radius, radius * 2, radius * 2);
            g.DrawLine(line, pos.X - radius, pos.Y, pos.X + radius, pos.Y);
            g.DrawLine(line, pos.X, pos.Y - radius, pos.X, pos.Y + radius);
        }

        public Point Position
        {
            get { return pos; }
            set
            {
                if (value.X < 0)
                {
                    pos.X = -value.X;
                }
                else
                {
                    pos.X = value.X;
                }

                if (value.Y < 0)
                {
                    pos.Y = -value.Y;
                }
                else
                {
                    pos.Y = value.Y;
                }
            }
        }

        public int Radius
        {
            get { return radius; }
            set
            {
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

    }
}
