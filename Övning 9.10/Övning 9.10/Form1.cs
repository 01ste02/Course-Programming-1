using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._10
{
    public partial class Form1 : Form
    {
        public TextBox[] textBoxes = new TextBox[999];
        public Form1()
        {
            InitializeComponent();
            lbxMenu.SelectedIndex = 0;
            
                int c = 0;
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is TextBox)
                    {
                        textBoxes[c] = (TextBox)this.Controls[i];
                        c++;
                    }
                }
        }

        public int[,] rows = new int[4, 6];

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    rows[i, j] = random.Next(1, 20);
                }
            }

            for (int i = 1; i < 4; i++)
            {
                textBoxes[i].Clear();
                for (int j = 0; j < 6; j++)
                {
                    textBoxes[i].AppendText(rows[i, j].ToString() + "\n");
                }
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            int index = 4 - (lbxMenu.SelectedIndex + 1);
            tbxChoice.Clear();

            for (int i = 0; i < 6; i++)
            {
                tbxChoice.AppendText(rows[index, i].ToString() + "\n");
            }
        }
    }
}
