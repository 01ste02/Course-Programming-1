using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_13._1
{
    public partial class Form1 : Form
    {
        private Square[] squares = new Square[16];
        public Form1 ()
        {
            InitializeComponent();
            Startup();
        }

        public void Startup()
        {
            int width = (int)(ClientSize.Width / 6.5);
            int height = (int)(ClientSize.Height / 6.5);
            int xStart = (int)(0.5 * width);
            int yStart = (int)(0.5 * height);
            int index = 0;

            for(int i = 0; i < 4; i++)
            {
                xStart = (int)(0.5 * width);

                for (int j = 0; j < 4; j++)
                {
                    squares[index] = new Square(xStart, yStart, width, height, Brushes.Red);
                    xStart += (int)(width * 1.5);
                    index++;
                }

                yStart += (int)(height * 1.5);
            }

            Invalidate();
        }

        protected override void OnPaint (PaintEventArgs e)
        {
            for (int i = 0; i < squares.Length; i++)
            {
                squares[i].Draw(e.Graphics);
            }
        }

        private void ReDraw (object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_MouseClick (object sender, MouseEventArgs e)
        {
            string hit = " and it was a dud.";
            for (int i = 0; i < squares.Length; i++)
            {
                if (squares[i].Hit(e.X, e.Y))
                {
                    squares[i].Hidden = true;
                    hit = " and it was a hit.";
                }
            }

            Console.WriteLine("There was a click at: " + e.X + ", " + e.Y + hit);

            Invalidate();
        }
    }
}
