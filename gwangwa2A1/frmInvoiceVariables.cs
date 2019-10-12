using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmInvoiceVariables : Form
    {
        public frmInvoiceVariables()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discount = Convert.ToDecimal(txtDiscountPercent.Text)/100;
            decimal discountAmount = discount * subtotal;
            decimal total = subtotal + discountAmount;
            txtDiscountAmount.Text = discountAmount.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = (" ");
            txtDiscountPercent.Text = ("5.00");
            txtDiscountAmount.Text = (" ");
            txtTotal.Text = (" ");
            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
