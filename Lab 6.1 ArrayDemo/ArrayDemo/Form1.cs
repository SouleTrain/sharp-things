using System;
using System.Linq;
using System.Windows.Forms;

namespace ArrayDemo
{
    public partial class Form1 : Form
    {
        private static int[] intList = { 10, 15, 5, 25, 20 };
        public Form1()
        {
            InitializeComponent();
            foreach (int i in intList)
                listView.Items.Add(Convert.ToString(i));
        }

        private void ascButton_Click(object sender, EventArgs e)
        {
            outputList.Clear();
            Array.Sort(intList);
            foreach (int i in intList)
                outputList.Items.Add(Convert.ToString(i));
        }

        private void descButton_Click(object sender, EventArgs e)
        {
            outputList.Clear();
            Array.Sort(intList);
            Array.Reverse(intList);
            foreach(int i in intList)
                outputList.Items.Add(Convert.ToString(i));
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            outputList.Clear();
            int selection = Convert.ToInt32(customBox.Text);
            while (selection < 5)
            {
                outputList.Items.Add(Convert.ToString(intList[selection]));
                ++selection;
            }   
            
            
        }
    }
}
