using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gwangwa1F1
{
    public partial class frmCurrencyConverterV2 : Form
    {
        public frmCurrencyConverterV2()
        {
            InitializeComponent();
        }

        private void FrmCurrencyConverterV2_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnKenya.BackgroundImage = picKenyaDim.Image;
            txtRate.Text = ("0.687898");
            txtUSDollars.Text = ("0.00");
            txtTotalUSD.Text = ("0.00");
            lblCurrency.Text = btnAustralia.Text +":";
            lblEquation.Text = ("0.00");
            txtCurrency.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnKenya.BackgroundImage = picKenyaDim.Image;
            lblCurrency.Text = ("Australian Dollar:");
            txtRate.Text = ("0.687898");
            txtCurrency.Focus();
        }

        private void BtnBhutan_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnKenya.BackgroundImage = picKenyaDim.Image;
            lblCurrency.Text = ("Bhutan Ngultram:");
            txtRate.Text = ("0.0140812");
            txtCurrency.Focus();
        }

        private void BtnEU_Click(object sender, EventArgs e)
        {
            btnEU.BackgroundImage = picEU.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnKenya.BackgroundImage = picKenyaDim.Image;
            txtRate.Text = ("1.10746");
            lblCurrency.Text = ("Euro:");
            txtCurrency.Focus();
        }

        private void BtnKenya_Click(object sender, EventArgs e)
        {
            btnEU.BackgroundImage = picEUDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnKenya.BackgroundImage = picKenya.Image;
            lblCurrency.Text = ("Kenyan Shilling:");
            txtRate.Text = ("0.00964597");
            txtCurrency.Focus();
        }

        private void LblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void LblRate_Click(object sender, EventArgs e)
        {

        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text= 
                (
                Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text =
              (
              (Convert.ToDecimal(txtUSDollars.Text)) + (Convert.ToDecimal(txtTotalUSD.Text))
              ).ToString("0.00");

            lblEquation.Text =
                (
                 (lblEquation.Text) + ("+") + (txtUSDollars.Text)
                );
            txtCurrency.Focus();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnKenya.BackgroundImage = picKenyaDim.Image;
            txtRate.Text = ("0.687898");
            txtUSDollars.Text = ("0.00");
            txtTotalUSD.Text = ("0.00");
            lblCurrency.Text = btnAustralia.Text + ":";
            lblEquation.Text = (" ");
            txtCurrency.Text = "0.00";
            txtCurrency.Focus();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
