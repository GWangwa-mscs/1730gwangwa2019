using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gwangwa1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = 
                (
                4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");
            /* 
            if you put an m after a number you automatically convert it to decimal
            eg (4.om)the price of one hotdog instead of (( Convert.ToDecimal (4.00.Text))
            */
            txtHamburgersSubtotal.Text =
               (
               5.0m * Convert.ToDecimal(txtHamburgers.Text)
               ).ToString("0.00");

            txtPretaxTotal.Text =
                (
               (Convert.ToDecimal(txtHamburgersSubtotal.Text)) + (Convert.ToDecimal(txtHotDogsSubtotal.Text))
                ).ToString("0.00");
            //for the tax just multiply the pretax total with the Minnesota sales tax which is 6.875%
            txtTax.Text =(
                (Convert.ToDecimal(txtPretaxTotal.Text)) * (0.06875m)
                ).ToString("0.00");

            txtTotal.Text =
                (
               (Convert.ToDecimal(txtPretaxTotal.Text)) + (Convert.ToDecimal(txtTax.Text))
                ).ToString("0.00");
            btnClear.Focus();

        }
        /*
        the focus comand simply moves the hot key to the next step 
        so from calculate to clear and then to txtHotDogs.Text
        */

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text            = "0";
            txtHamburgers.Text         = "0";
            txtHotDogsSubtotal.Text    = " ";
            txtHamburgersSubtotal.Text = " ";
            txtPretaxTotal.Text        = " ";
            txtTax.Text                = " ";
            txtTotal.Text              = " ";

            txtHotDogs.Focus();
        }
    }
}
