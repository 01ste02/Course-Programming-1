using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_12._1
{
    public partial class Form1 : Form
    {
        private Sort sort = new Sort();
        public Form1 ()
        {
            InitializeComponent();
        }

        private void btnSort_Click (object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            try
            {
                int.TryParse(tbxNum1.Text, out int num1);
                int.TryParse(tbxNum2.Text, out int num2);
                int.TryParse(tbxNum3.Text, out int num3);
                int.TryParse(tbxNum4.Text, out int num4);
                int.TryParse(tbxNum5.Text, out int num5);

                numbers[0] = num1;
                numbers[1] = num2;
                numbers[2] = num3;
                numbers[3] = num4;
                numbers[4] = num5;
            }
            catch
            {

            }

            numbers = sort.SortInt(numbers);

            tbxNum1.Text = numbers[0].ToString();
            tbxNum2.Text = numbers[1].ToString();
            tbxNum3.Text = numbers[2].ToString();
            tbxNum4.Text = numbers[3].ToString();
            tbxNum5.Text = numbers[4].ToString();
        }
    }
}
