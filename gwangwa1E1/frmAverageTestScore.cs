using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gwangwa1E1
{
    public partial class txtgwangwa_ex1E : Form
    {
        public txtgwangwa_ex1E()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = 
               (
                ((Convert.ToDecimal(txtTest1Score.Text)) + 
                 (Convert.ToDecimal(txtTest2Score.Text)) + 
                 (Convert.ToDecimal(txtTest3Score.Text))
                )/ 3
               ).ToString("0.00");
            btnClear.Focus();
        }

        private void TxtClear_Click(object sender, EventArgs e)
        {
            txtTest1Score.Text = "0";
            txtTest2Score.Text = "0";
            txtTest3Score.Text = "0";
            txtAverage.Text    = " ";
            txtTest1Score.Focus();
        }

        private void TxtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTest3Score_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
