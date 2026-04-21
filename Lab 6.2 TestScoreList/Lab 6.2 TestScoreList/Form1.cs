using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//characters and whitespaces will break this code
namespace Lab_6._2_TestScoreList
{
    public partial class TestScoreList : Form
    {
        public int[] scoreList = new int[8];
        public TestScoreList()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count < 8)
            {
                listView1.Items.Add(scoreBox.Text);
                scoreList[listView1.Items.Count - 1] = Convert.ToInt32(scoreBox.Text);
            }
            else
                errorLabel1.Text = $"Only eight scores\n" +
                                    $"are supported";
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            double average = scoreList.Average();
            for (int i = 1; i < 9; i++)
            {
                listView2.Items.Add($"Student {i} scored: {scoreList[i - 1]}, {scoreList[i - 1] - average} away from {average}");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            scoreList = new int[8];
            errorLabel1.Text = "";
        }
    }
}
