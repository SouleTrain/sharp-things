using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenue
{
    public partial class Form1 : Form
    {
        private char check;
        private string[] contestCodes;
        private string[] contestNamesList;
        int Mcounter = 0,
            Dcounter = 0,
            Scounter = 0,
            OCounter = 0;
        int i = 0;

        private void resetButton_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            revenueLabel.Text = null;
            numericUpDown.Value = 0;
            numericUpDown.Enabled = true;
            Mcounter = 0;
            Dcounter = 0;
            Scounter = 0;
            OCounter = 0;
            i = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void AddContestButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown.Value <= 0)
            {
                MessageBox.Show("Contestants cannot be null");
            }
            else
            {
                int numofContestants = Convert.ToInt32(numericUpDown.Value);
                contestNamesList = new string[numofContestants];
                contestCodes = new string[numofContestants];
                numericUpDown.Enabled = false;
                int revenue = Convert.ToInt32(numericUpDown.Value) * 25;
                revenueLabel.Text = $"{numericUpDown.Value} contestants is \n{revenue.ToString("C")} in revenue!";
            }
        }            
        private void ContestNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown.Value == 0)
                {
                    MessageBox.Show("Contestants value cannot be null");
                }
                else if (musicCheck.Checked)
                {
                    check = 'M';
                    Mcounter++;
                    contestCodes[i] = Convert.ToString($"{check}{Mcounter}");
                    contestNamesList[i] = nameBox.Text;
                    listView1.Items.Add($"{contestNamesList[i]} Signed in with code {contestCodes[i]}");
                    i++;
                }
                else if (singCheck.Checked)
                {
                    check = 'S';
                    Scounter++;
                    contestCodes[i] = Convert.ToString($"{check}{Scounter}");
                    contestNamesList[i] = nameBox.Text;
                    listView1.Items.Add($"{contestNamesList[i]} Signed in with code {contestCodes[i]}");
                    i++;
                }
                else if (danceCheck.Checked)
                {
                    check = 'D';
                    Dcounter++;
                    contestCodes[i] = Convert.ToString($"{check}{Dcounter}");
                    contestNamesList[i] = nameBox.Text;
                    listView1.Items.Add($"{contestNamesList[i]} Signed in with code {contestCodes[i]}");
                    i++;
                }
                else if (otherCheck.Checked)
                {
                    check = 'O';
                    OCounter++;
                    contestCodes[i] = Convert.ToString($"{check}{OCounter}");
                    contestNamesList[i] = nameBox.Text;
                    listView1.Items.Add($"{contestNamesList[i]} Signed in with code {contestCodes[i]}");
                    i++;
                }
                else
                    MessageBox.Show("Please enter valid talent type");
            }
            catch (Exception)
            {
                MessageBox.Show("Maximum amount of contestants reached");
            }
        }
    }
}
