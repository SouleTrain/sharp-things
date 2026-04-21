using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (FontBox.SelectedIndex != -1 && SizeBox.SelectedIndex != -1)
            {
                Font demoFont = new Font(FontBox.SelectedItem.ToString(), Convert.ToInt32(SizeBox.SelectedItem));
                OutputLabel.Font = demoFont;
                OutputLabel.Text = "Hello, world.";
            }
            else if (FontBox.SelectedIndex == -1 || SizeBox.SelectedIndex == -1) 
            {
                Font defaultFont = new Font("Arial", 8);
                OutputLabel.Font = defaultFont;
                OutputLabel.Text = "Hello, world";
            }
        }
    }
}
