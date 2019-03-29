using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_13._3
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        private Queue<string> queue = new Queue<string>();

        private void btnNewCustomer_Click (object sender, EventArgs e)
        {
            string name = tbxName.Text;
            queue.Enqueue(name);
            tbxOutput.Text = name + " har ställt sig i kön";
        }

        private void btnExpedite_Click (object sender, EventArgs e)
        {
            string name = queue.Dequeue();
            tbxOutput.Text = name + " har expedierats.";
        }
    }
}
