using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_click(object sender, EventArgs e)
        {
            char letter = tbxLetter.Text[0];
            int letterCode = (int)letter;
            int smallLetterCode = letterCode + 32;

            char smallLetter = (char)smallLetterCode;
            lblOutput.Text = smallLetter.ToString();
        }
    }
}
