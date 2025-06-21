using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectKawaiiCafeOrderingSystem
{
    public partial class checkoutForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pirat\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";

        private menuForm _menuForm;

        private decimal finalTotalAfterDiscount = 0;

        public checkoutForm()
        {
            InitializeComponent();
        }
        public checkoutForm(menuForm menu)
        {
            InitializeComponent();
            _menuForm = menu;
        }

        private void checkoutForm_Load(object sender, EventArgs e)
        {
            labelCardNum.Visible = false;
            textBoxCardNum.Visible = false;
            labelCVV.Visible = false;
            textBoxCVV.Visible = false;

            labelAmount.Visible = false;
            textBoxAmount.Visible = false;
            listItem.Items.Clear();
            labelDisPercen.Text = "";
            labelDisPercen.Visible = true;

            decimal total = 0;
            foreach (var item in OrderSession.OrderedItems)
            {
                listItem.Items.Add(item.ToString());
                total += item.TotalPrice;
            }

            // Fetch membership info
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pirat\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";
            string custUsername = OrderSession.CurrentUsername;
            string membershipType = "None";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT cust_membertype FROM Customer WHERE cust_username = @username", conn);
                cmd.Parameters.AddWithValue("@username", custUsername);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    membershipType = result.ToString();
                }
                conn.Close();
            }

            decimal discount = 0;

            switch (membershipType)
            {
                case "Premium":
                    discount = total * 0.20m;
                    labelDisPercen.Text = "20% discount (Premium).";
                    break;
                case "Gold":
                    discount = total * 0.15m;
                    labelDisPercen.Text = "15% discount (Gold).";
                    break;
                case "Silver":
                    discount = total * 0.10m;
                    labelDisPercen.Text = "10% discount (Silver).";
                    break;
                default:
                    labelDisPercen.Text = "No membership discount.";
                    break;
            }

            finalTotalAfterDiscount = total - discount;
            labelTotalPrice.Text = "RM " + finalTotalAfterDiscount.ToString("F2");

        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

        }

        private void labelDisPercen_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonDebit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDebit.Checked)
            {
                // Show debit-related fields
                labelCardNum.Visible = true;
                textBoxCardNum.Visible = true;
                labelCVV.Visible = true;
                textBoxCVV.Visible = true;

                // Hide cash-related fields
                labelAmount.Visible = false;
                textBoxAmount.Visible = false;
            }
        }
        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCash.Checked)
            {
                // Show cash-related fields
                labelAmount.Visible = true;
                textBoxAmount.Visible = true;

                // Hide debit-related fields
                labelCardNum.Visible = false;
                textBoxCardNum.Visible = false;
                labelCVV.Visible = false;
                textBoxCVV.Visible = false;
            }
        }

        private void labelCardNum_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCardNum_TextChanged(object sender, EventArgs e)
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

        private void buttonPay_Click(object sender, EventArgs e)
        {
            decimal total = finalTotalAfterDiscount;

            if (radioButtonDebit.Checked)
            {
                if (!IsCardNumberValid())
                {
                    MessageBox.Show("Card number must be 16 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsCVVValid())
                {
                    MessageBox.Show("CVV must be 3 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (radioButtonCash.Checked)
            {
                if (!IsAmountValid(total))
                {
                    MessageBox.Show($"Cash amount must be at least RM {total:F2}", "Insufficient Cash", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // No payment method selected
                MessageBox.Show("Please select a payment method.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ All validations passed — proceed with "payment"
            MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optional: Clear session
            OrderSession.OrderedItems.Clear();

            // Redirect to mainForm (or thank-you screen)
            this.Close();
            Form main = Application.OpenForms["mainForm"];
            if (main != null)
            {
                main.Show();
            }
            else
            {
                mainForm newMain = new mainForm();
                newMain.Show();
            }

        }
        private bool IsCardNumberValid()
        {
            return textBoxCardNum.Text.Length == 16 && textBoxCardNum.Text.All(char.IsDigit);
        }

        private bool IsCVVValid()
        {
            return textBoxCVV.Text.Length == 3 && textBoxCVV.Text.All(char.IsDigit);
        }

        private bool IsAmountValid(decimal total)
        {
            decimal userAmount;
            if (decimal.TryParse(textBoxAmount.Text, out userAmount))
            {
                // Round both values to 2 decimal places before comparing
                userAmount = Math.Round(userAmount, 2);
                total = Math.Round(total, 2);

                return userAmount >= total;
            }
            return false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();           // Close checkout form
            _menuForm.Show();       // Re-show the original menu form
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
         "Are you sure you want to cancel your order?",
         "Confirm Cancellation",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                OrderSession.OrderedItems.Clear();
                listItem.Items.Clear();
                labelTotalPrice.Text = "RM 0.00";

                this.Close();

                mainForm newMain = new mainForm();
                newMain.Show();
            }
        }


    }
}
