using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Övning_13._1
{
    class Square
    {
        private int xStart;
        private int yStart;
        private int sizeX;
        private int sizeY;
        private Brush brush;
        private bool hidden = false;

        public Square(int xStart, int yStart, int sizeX, int sizeY, Brush brush)
        {
            this.xStart = xStart;
            this.yStart = yStart;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.brush = brush;
        }

        public void Draw (Graphics g)
        {
            if (!hidden)
            {
                g.FillRectangle(brush, xStart, yStart, sizeX, sizeY);
            }
        }

        public bool Hit(int mouseX, int mouseY)
        {
            if(mouseX <= xStart + sizeX && mouseX >= xStart && mouseY <= yStart + sizeY && mouseY >= yStart && !hidden)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Hidden
        {
            get
            {
                return hidden;
            }

            set
            {
                if (value == true || value == false)
                {
                    hidden = value;
                }
            }
        }
    }
}
