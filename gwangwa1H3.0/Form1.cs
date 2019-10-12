using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gwangwa1H3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {

            thirdTextBox.Text = (Convert.ToInt32(firstTextBox.Text) + Convert.ToInt32(secondTextBox.Text)).ToString();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            firstLabel.Text = (firstGroupBox.TabIndex + 1).ToString();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            secondLabel.Text = (2 * secondGroupBox.TabIndex).ToString("n2");
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            fourthTextBox.Text = firstTextBox.Text + secondTextBox.Text;
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            fourthTextBox.Text = Convert.ToInt32(firstTextBox.Text + secondTextBox.Text).ToString();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            secondLabel.Text = "MessageC" + firstTextBox.Text;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            thirdTextBox.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            thirdTextBox.Text = firstLabel.Text + (Convert.ToInt32(secondTextBox.Text) - 2).ToString();
        }
    }
}
