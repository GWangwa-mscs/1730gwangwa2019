using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gwangwa1d1
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }
        /*
        the TextChange funcion created here is a pointer that is used by both 
        the amount and rate of the same currency such that the txtUSD'country' changes whenever any of them changes
        the same function is used when the TotalUSD is calculated so that 
        it also changes whenever any of the amount or rate of any of the currencies change
        */
        private void australiaTextChange(object sender, EventArgs e)
       {
              txtUSDAustralia.Text = 
                  (
                 Convert.ToDecimal (txtAmountAustralia.Text) * Convert.ToDecimal (txtRateAustralia.Text)
                  ).ToString("0.00");
        }

        private void bhutanTextChange(object sender, EventArgs e)
        {
            txtUSDBhutan.Text =
                (
                Convert.ToDecimal(txtAmountBhutan.Text) * Convert.ToDecimal(txtRateBhutan.Text)
                ).ToString("0.00");
        }

        private void shillingTextChange(object sender, EventArgs e)
        {
             txtUSDShilling.Text =
               (
               Convert.ToDecimal(txtAmountShilling.Text) * Convert.ToDecimal(txtRateShilling.Text)
               ).ToString("0.00");
        }

        private void euroTextChange(object sender, EventArgs e)
        {
            txtUSDEuro.Text =
              (
              Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)
              ).ToString("0.00");
        }

        private void usdTextChange(object sender, EventArgs e)
        {
            txtTotalUSD.Text =
                (
                Convert.ToDecimal(txtUSDAustralia.Text) +
                Convert.ToDecimal(txtUSDBhutan.Text) +
                Convert.ToDecimal(txtUSDShilling.Text) +
                Convert.ToDecimal(txtUSDEuro.Text)
                 ).ToString("0.00");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = ("0.00");
            txtAmountBhutan.Text    = ("0.00");
            txtAmountShilling.Text  = ("0.00");
            txtAmountEuro.Text      = ("0.00");
            /*
            this is the default value of the exchage rates 
            however the text boxes are editable to the current exchange rate
            since the rates are constantly changing.
            hitting the reset will bring you back to these values.
            */
            txtRateAustralia.Text   = ("0.687898");
            txtRateBhutan.Text      = ("0.0140812");
            txtRateShilling.Text    = ("0.00964597");
            txtRateEuro.Text        = ("1.10746");
         
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
