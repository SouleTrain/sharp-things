using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessANumber
{
    public partial class Form1 : Form
    {
        int[] Answer = new int[1];

        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            int answer = rnd.Next(1, 6);
            Answer[0] = answer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (Num1.Checked == true)
            {
                i = 1;
            }
            else if (Num2.Checked == true)
            {
                i = 2;
            }
            else if (Num3.Checked == true)
            {
                i = 3;
            }
            else if (Num4.Checked == true)
            {
                i = 4;
            }
            else if (Num5.Checked == true)
            {
                i = 5;
            }
            if (i == Answer[0])
            {
                label2.Text = $"Correct!!";
            }
            else
            {
                label2.Text = $"Incorrect!!";
            }
        }
    }
}
