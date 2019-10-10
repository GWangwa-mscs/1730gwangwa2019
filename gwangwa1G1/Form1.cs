using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gwangwa1G1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 1
            txtBox1C.Text = txtBox1A.Text + txtBox1B.Text;
            // 2
            txtBox2C.Text = (
                    Convert.ToInt32(txtBox2A.Text) + Convert.ToInt32(txtBox2B.Text)
                ).ToString();
            // 3
            txtBox3C.Text = (
                    Convert.ToInt32(txtBox3A.Text + txtBox3B.Text)
                ).ToString();
            // 4
            txtBox1A.Text = (
                Convert.ToInt32(txtBox1B.Text).ToString() + txtBox1C.Text
                ).ToString();
            // 5
            txtBox2A.Text = txtBox2B.Text + Convert.ToInt32(txtBox2C.Text).ToString();
            // 6
            txtBox3A.Text = (
                    txtBox3B.MaxLength + txtBox3C.SelectionLength
                ).ToString();
            // 7
            txtBox1B.Text = (
                    Convert.ToInt32(txtBox1A.Text) - Convert.ToInt32(txtBox1C.Text)
                ).ToString("n2");
            // 8
            txtBox2B.Text = (
                    Convert.ToDecimal(txtBox1A.Text) * Convert.ToDecimal(txtBox1C.Text)
                ).ToString("n2");
            // 9
            txtBox3B.Text = (
                    Convert.ToDecimal(txtBox3A.Text) / Convert.ToDecimal(txtBox3C.Text)
                ).ToString("n2");
        }

    }
}
