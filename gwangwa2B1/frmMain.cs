using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gwangwa2B1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal amountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal amountShilling = Convert.ToDecimal(txtAmountShilling.Text);
            decimal amountEuro = Convert.ToDecimal(txtAmountEuro.Text);

            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal rateBhutan = Convert.ToDecimal(txtRateBhutan.Text);
            decimal rateShilling = Convert.ToDecimal(txtRateShilling.Text);
            decimal rateEuro = Convert.ToDecimal(txtRateEuro.Text);

            decimal USDAustralia = amountAustralia * rateAustralia;
            decimal USDBhutan = amountBhutan * rateBhutan;
            decimal USDShilling = amountShilling * rateShilling;
            decimal USDEuro = amountEuro * rateEuro;
            decimal USDTotal = USDAustralia + USDBhutan + USDEuro + USDShilling;

            txtUSDAustralia.Text = USDAustralia.ToString("0.00");
            txtUSDBhutan.Text = USDBhutan.ToString("0.00");
            txtUSDEuro.Text = USDEuro.ToString("0.00");
            txtUSDShilling.Text = USDShilling.ToString("0.00");
            txtTotalUSD.Text =  USDTotal.ToString("0.00");



        }

        private void txtResetButton_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = ("0.00");
            txtAmountBhutan.Text = ("0.00");
            txtAmountShilling.Text = ("0.00");
            txtAmountEuro.Text = ("0.00");
            txtTotalUSD.Text = (" ");
            /*
            this is the default value of the exchage rates 
            however the text boxes are editable to the current exchange rate
            since the rates are constantly changing.
            hitting the reset will bring you back to these values.
            */
            txtRateAustralia.Text = ("0.687898");
            txtRateBhutan.Text = ("0.0140812");
            txtRateShilling.Text = ("0.00964597");
            txtRateEuro.Text = ("1.10746");

        }

        private void txtExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
