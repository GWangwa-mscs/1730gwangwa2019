using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariableSample
{
    public partial class frmVariablesSample : Form
    {
        public frmVariablesSample()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int hotDogs = Convert.ToInt32(txtHotDogs.Text);
            decimal hotDogPrice = 4.0m;
            decimal hotDogSubtotal = hotDogs * hotDogPrice;
            txtHotDogsSubtotal.Text = hotDogSubtotal.ToString();

            int hamberger = Convert.ToInt32(txtHamburgers.Text);
            decimal hambergerPrice = 5.0m;
            decimal hambergerSubtotal = hamberger * hambergerPrice;
            txtHamburgersSubtotal.Text = hambergerSubtotal.ToString();

            decimal preTaxTotal = hotDogSubtotal + hambergerSubtotal;
            txtPretaxTotal.Text = preTaxTotal.ToString();

            decimal tax = 0.06m;
            decimal Tax = tax * preTaxTotal;
            txtTax.Text = Tax.ToString();

            decimal total = Tax + preTaxTotal;
            txtTotal.Text = total.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = " ";
            txtHamburgersSubtotal.Text = " ";
            txtPretaxTotal.Text = " ";
            txtTax.Text = " ";
            txtTotal.Text = " ";

            txtHotDogs.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
