using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_13._2
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        private Stack<char> word = new Stack<char>();

        private void btnRun_Click (object sender, EventArgs e)
        {
            string beginWord = tbxWord.Text;
            for (int i = 0; i < tbxWord.Text.Length; i++)
            {
                word.Push(tbxWord.Text[i]);
            }

            string result = "";
            int wordLength = word.Count;
            for (int i = 0; i < wordLength; i++)
            {
                result += word.Pop(); 
            }

            string output = "";

            if (result == beginWord)
            {
                output = beginWord + " är ett palindrom.";
            }
            else
            {
                output = beginWord + " är inte ett palindrom";
            }

            tbxOutput.Text = output;
        }
    }
}
