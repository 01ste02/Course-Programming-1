using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_10._7
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int number = 5;
        int[] dice = new int[5];
        int sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            throwDice(dice, number);
            sumDice(dice, number);
            showDice(dice, number);
        }

        public void throwDice(int[] dices, int num)
        {
            for (int i = 0; i < num; i++)
            {
                dices[i] = rand.Next(1, 7);
            }
        }

        public void sumDice(int[] dices, int num)
        {
            sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum += dices[i];
            }
        }

        public void showDice(int[] dices, int num)
        {
            tbxDice.Text = "";
            for (int i = 0; i < num; i++)
            {
                tbxDice.AppendText("Tärning " + (i + 1).ToString() + ":    " + dices[i].ToString() + "\n");
            }

            tbxDice.AppendText("\r\n" + "Antal prickar: " + sum.ToString());
        }
    }
}
