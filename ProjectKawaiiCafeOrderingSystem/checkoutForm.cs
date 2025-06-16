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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            labelcardnum.Visible = false;
            textBoxCardNum.Visible = false;
            labelCVV.Visible = false;
            textBoxCVV.Visible = false;
            labelAmount.Visible = false;
            textBoxAmount.Visible = false;
=======

>>>>>>> Stashed changes
=======

>>>>>>> Stashed changes
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            if (radioDebit.Checked)
            {
                string cardNumber = textBoxCardNum.Text.Trim();
                string cvv = textBoxCVV.Text.Trim();

                if (cardNumber.Length != 16 || !cardNumber.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter a valid 16-digit card number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cvv.Length != 3 || !cvv.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter a valid 3-digit CVV.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Proceed with checkout (valid debit input)
                MessageBox.Show("Payment Successful via Debit Card!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioCash.Checked)
            {
                string amountText = textBoxAmount.Text.Trim();

                if (string.IsNullOrWhiteSpace(amountText) || !decimal.TryParse(amountText, out _))
                {
                    MessageBox.Show("Please enter a valid cash amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Proceed with checkout (valid cash input)
                MessageBox.Show("Payment Successful via Cash!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a payment method.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
=======

>>>>>>> Stashed changes
=======

>>>>>>> Stashed changes
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            
=======

>>>>>>> Stashed changes
=======

>>>>>>> Stashed changes
        }

        private void labelPaymentMethod_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCardNum_TextChanged(object sender, EventArgs e)
        {

        }
<<<<<<< Updated upstream
<<<<<<< Updated upstream

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
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
