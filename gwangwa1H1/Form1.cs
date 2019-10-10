using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gwangwa1H1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Text = "MessageC" + textBox1.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           label1.Text = (groupBox1.TabIndex + 1).ToString();
            textBox3.Text = (textBox1.Text) + (textBox2.Text);
            label2.Text = (2 * groupBox3.TabIndex).ToString("n2");


        }
    }
}
