using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKawaiiCafeOrderingSystem
{
    public partial class checkoutForm : Form
    {
        public checkoutForm()
        {
            InitializeComponent();
        }

        private void labelcheckout_Click(object sender, EventArgs e)
        {

        }

        private void labelDiscount_Click(object sender, EventArgs e)
        {

        }

        private void checkoutForm_Load(object sender, EventArgs e)
        {
            labelcardnum.Visible = false;
            textBoxCardNum.Visible = false;
            labelCVV.Visible = false;
            textBoxCVV.Visible = false;
            labelAmount.Visible = false;
            textBoxAmount.Visible = false;
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

        }

        private void labelPaymentMethod_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCardNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioCash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCash.Checked)
            {
                // Show amount fields
                labelAmount.Visible = true;
                textBoxAmount.Visible = true;

                // Hide card fields
                labelcardnum.Visible = false;
                textBoxCardNum.Visible = false;
                labelCVV.Visible = false;
                textBoxCVV.Visible = false;
            }
        }

        private void radioDebit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDebit.Checked)
            {
                // Show card fields
                labelcardnum.Visible = true;
                textBoxCardNum.Visible = true;
                labelCVV.Visible = true;
                textBoxCVV.Visible = true;

                // Hide amount fields
                labelAmount.Visible = false;
                textBoxAmount.Visible = false;
            }
        }

        private void labelcardnum_Click(object sender, EventArgs e)
        {

        }

        private void labelCVV_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAmount_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
