using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tbxInput.Text);
            String day = "";
            String output = "";

            switch (num)
            {
                case 1:
                    day = "Måndag";
                    break;
                case 2:
                    day = "Tisdag";
                    break;
                case 3:
                    day = "Onsdag";
                    break;
                case 4:
                    day = "Torsdag";
                    break;
                case 5:
                    day = "Fredag";
                    break;
                case 6:
                    day = "Lördag";
                    break;
                case 7:
                    day = "Söndag";
                    break;
            }

            output = "Veckodag " + num.ToString() + " motsvarar " + day + ".";
            lblOutput.Text = output;
        }
    }
}
