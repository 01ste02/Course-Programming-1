using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_11._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint (PaintEventArgs e)
        {
            Cirkel circle = new Cirkel();
            circle.x = 10;
            circle.y = 10;
            circle.width = 20;
            circle.height = 100;

            Cirkel two = new Cirkel();
            two.x = 100;
            two.y = 30;
            two.width = 100;
            two.height = 20;

            e.Graphics.FillEllipse(new SolidBrush(Color.Red), )
        }
    }
}
