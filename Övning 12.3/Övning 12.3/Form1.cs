using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_12._3
{
    public partial class Form1 : Form
    {
        private GenerateNumbers generator = new GenerateNumbers();
        private Bubblesort sort = new Bubblesort();
        private Search search = new Search();
        private Random random = new Random();

        private int[] numbers;

        public Form1 ()
        {
            InitializeComponent();
            btnBinSearch.Enabled = false;
            btnSearch.Enabled = false;
            btnSort.Enabled = false;
        }

        private void btnGenerate_Click (object sender, EventArgs e)
        {
            numbers = generator.Generate(random, int.Parse(tbxNum.Text), 0, 10000);
            btnSearch.Enabled = true;
            btnSort.Enabled = true;
            btnBinSearch.Enabled = false;
        }

        private void btnSearch_Click (object sender, EventArgs e)
        {
            int index;
            try
            {
                index = search.SearchRegularInt(numbers, int.Parse(tbxSearch.Text));
            }
            catch
            {
                index = -1;
            }

            if (index == -1)
            {
                lblResult.Text = "Värdet finns ej.";
            }
            else
            {
                lblResult.Text = "Värdet har index " + index + ".";
            }
        }

        private void btnSort_Click (object sender, EventArgs e)
        {
            numbers = sort.Sort(numbers);
            btnBinSearch.Enabled = true;
        }

        private void btnBinSearch_Click (object sender, EventArgs e)
        {
            int index;
            try
            {
                index = search.SearchBinInt(numbers, int.Parse(tbxSearch.Text));
            }
            catch
            {
                index = -1;
            }

            if (index == -1)
            {
                lblResult.Text = "Värdet finns ej.";
            }
            else
            {
                lblResult.Text = "Värdet har index " + index + ".";
            }
        }
    }
}
