using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayNight_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DayButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightYellow;
        }

        private void NightButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.MidnightBlue;
        }
    }
}
