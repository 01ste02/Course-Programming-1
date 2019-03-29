using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThrow_click(object sender, EventArgs e)
        {
            Random random = new Random();

            int result = random.Next(1, (int.Parse(tbxInput.Text) + 1));

            if (result == 6)
            {
                System.Windows.Forms.MessageBox.Show("Grattis! Du slog en sexa!");
            }
        }
    }
}
