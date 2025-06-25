using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProjectKawaiiCafeOrderingSystem
{
    public partial class checkoutForm : Form
    {

        private menuForm _menuForm;

        public checkoutForm()
        {
            InitializeComponent();
        }

        public checkoutForm(menuForm menu)
        {
            InitializeComponent();
            _menuForm = menu;
            this.Load += checkoutForm_Load;
        }

        private void checkoutForm_Load(object sender, EventArgs e)
        {
            listItem.Items.Clear();

            // ✅ List Menu Items
            foreach (var item in OrderSession.OrderedItems)
            {
                listItem.Items.Add($"Menu: {item.Name} x{item.Quantity} - RM {item.TotalPrice:F2}");
            }

            // ➕ ADDED: List Merchandise Items
            foreach (var item in OrderSession.OrderedMerchandise)
            {
                listItem.Items.Add($"Merch: {item.Name} x{item.Quantity} - RM {item.TotalPrice:F2}");
            }

            labelTotalPrice.Text = "Total: RM " + CalculateTotal().ToString("F2");

            labelCardNum.Visible = false;
            textBoxCardNum.Visible = false;
            labelCVV.Visible = false;
            textBoxCVV.Visible = false;
            labelAmount.Visible = false;
            textBoxAmount.Visible = false;
        }

        private decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (var item in OrderSession.OrderedItems)
            {
                total += item.TotalPrice;
            }


            // ➕ ADDED: Calculate total for merchandise
            foreach (var merch in OrderSession.OrderedMerchandise)
            {
                total += merch.TotalPrice;
            }


            foreach (var item in OrderSession.OrderedMerchandise)
            {
                total += item.TotalPrice;
            }

            return total;
        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e) { }
        private void buttonCalculate_Click(object sender, EventArgs e) { }
        private void labelDisPercen_Click(object sender, EventArgs e) { }
        private void labelTotalPrice_Click(object sender, EventArgs e) { }

        private void radioButtonDebit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDebit.Checked)
            {
                labelCardNum.Visible = true;
                textBoxCardNum.Visible = true;
                labelCVV.Visible = true;
                textBoxCVV.Visible = true;
                labelAmount.Visible = false;
                textBoxAmount.Visible = false;

                textBoxCardNum.Enabled = true;
                textBoxCVV.Enabled = true;
            }
        }

        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCash.Checked)
            {
                labelCardNum.Visible = false;
                textBoxCardNum.Visible = false;
                labelCVV.Visible = false;
                textBoxCVV.Visible = false;
                textBoxCardNum.Text = "";
                textBoxCVV.Text = "";

                labelAmount.Visible = true;
                textBoxAmount.Visible = true;
            }

        }

        private void labelCardNum_Click(object sender, EventArgs e) { }
        private void textBoxCardNum_TextChanged(object sender, EventArgs e) { }
        private void labelCVV_Click(object sender, EventArgs e) { }
        private void textBoxCVV_TextChanged(object sender, EventArgs e) { }
        private void labelAmount_Click(object sender, EventArgs e) { }
        private void textBoxAmount_TextChanged(object sender, EventArgs e) { }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            decimal totalAmount = CalculateTotal();
            decimal cashAmount = 0;
            decimal changeAmount = 0;

            if (radioButtonCash.Checked)
            {
                decimal.TryParse(textBoxAmount.Text, out cashAmount);
                changeAmount = cashAmount - totalAmount;
            }
            try
            {

                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SCSM11\Documents\GitHub\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True"))

                {
                    connection.Open();

                    if (OrderSession.OrderedItems.Count == 0 && OrderSession.OrderedMerchandise.Count == 0)
                    {
                        MessageBox.Show("No items selected to order.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (radioButtonDebit.Checked)
                    {
                        if (string.IsNullOrWhiteSpace(textBoxCardNum.Text) || string.IsNullOrWhiteSpace(textBoxCVV.Text))
                        {
                            MessageBox.Show("Please enter card number and CVV.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (textBoxCardNum.Text.Length != 16 || !textBoxCardNum.Text.All(char.IsDigit))
                        {
                            MessageBox.Show("Please enter a valid 16-digit debit card number.", "Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (textBoxCVV.Text.Length != 3 || !textBoxCVV.Text.All(char.IsDigit))
                        {
                            MessageBox.Show("Please enter a valid 3-digit CVV.", "Invalid CVV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    if (radioButtonCash.Checked)
                    {
                        if (string.IsNullOrWhiteSpace(textBoxAmount.Text))
                        {
                            MessageBox.Show("Please enter cash amount.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!decimal.TryParse(textBoxAmount.Text, out cashAmount))
                        {
                            MessageBox.Show("Please enter a valid cash amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (cashAmount <= totalAmount)
                        {
                            MessageBox.Show("Cash amount must be greater than total amount (RM " + totalAmount.ToString("F2") + ").", "Insufficient Cash", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Existing SQL logic below - untouched
                    string insertOrderQuery = "INSERT INTO [Order] (order_date, cust_ID) VALUES (@date, @custID); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(insertOrderQuery, connection);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@custID", OrderSession.custID);

                    int orderID = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (var item in OrderSession.OrderedItems)
                    {
                        if (item.MenuID <= 0)
                        {
                            MessageBox.Show($"Item skipped: {item.Name}, MenuID: {item.MenuID}");
                            continue;
                        }

                        string insertOrderMenuQuery = "INSERT INTO Order_Menu (order_ID, menu_ID, quantity) VALUES (@orderID, @menuID, @quantity)";
                        SqlCommand menuCmd = new SqlCommand(insertOrderMenuQuery, connection);
                        menuCmd.Parameters.AddWithValue("@orderID", orderID);
                        menuCmd.Parameters.AddWithValue("@menuID", item.MenuID);
                        menuCmd.Parameters.AddWithValue("@quantity", item.Quantity);
                        menuCmd.ExecuteNonQuery();
                    }

                    foreach (var merch in OrderSession.OrderedMerchandise)
                    {
                        if (merch.MerchID <= 0)
                        {
                            continue;
                        }

                        string insertOrderMerchQuery = "INSERT INTO Order_Merchandise (order_ID, merch_ID, quantity) VALUES (@orderID, @merchID, @quantity)";
                        SqlCommand merchCmd = new SqlCommand(insertOrderMerchQuery, connection);
                        merchCmd.Parameters.AddWithValue("@orderID", orderID);
                        merchCmd.Parameters.AddWithValue("@merchID", merch.MerchID);
                        merchCmd.Parameters.AddWithValue("@quantity", merch.Quantity);
                        merchCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment successful and order saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    receiptForm receipt = new receiptForm();
                    receipt.CustomerName = OrderSession.username;
                    receipt.PaymentMethod = radioButtonDebit.Checked ? "Debit Card" : "Cash";
                    receipt.FinalPrice = totalAmount;
                    receipt.ChangeAmount = changeAmount;
                    receipt.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            OrderSession.OrderedMerchandise.Clear(); // Clear merchandise sahaja
            this.Hide();
            _menuForm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel the order?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                mainForm main = new mainForm();
                OrderSession.Clear();
                this.Hide();
                main.Show();
            }
        }
    }
}
