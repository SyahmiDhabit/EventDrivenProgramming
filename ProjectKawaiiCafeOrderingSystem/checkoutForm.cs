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
        public class OrderItem
        {
            public int menuID { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
        }
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

            foreach (var item in OrderSession.OrderedItems)
            {
                listItem.Items.Add(item.ToString());
            }

            labelTotalPrice.Text = "Total: RM " + CalculateTotal().ToString("F2");

            // Hide everything by default
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
            return total;
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
            try
            {
                MessageBox.Show("Customer ID: " + OrderSession.custID);

                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ssyah\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True"))
                {
                    connection.Open();

                    MessageBox.Show("Menu Items Count: " + OrderSession.OrderedItems.Count);
                    MessageBox.Show("Merchandise Count: " + OrderSession.OrderedMerchandise.Count);

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
                    }

                    string insertOrderQuery = "INSERT INTO [Order] (order_date, cust_ID) VALUES (@date, @custID); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(insertOrderQuery, connection);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@custID", OrderSession.custID);

                    int orderID = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show("Order ID generated: " + orderID);

                    foreach (var item in OrderSession.OrderedItems)
                    {
                        string insertOrderMenuQuery = "INSERT INTO Order_Menu (order_ID, menu_ID, quantity) VALUES (@orderID, @menuID, @quantity)";
                        SqlCommand menuCmd = new SqlCommand(insertOrderMenuQuery, connection);
                        menuCmd.Parameters.AddWithValue("@orderID", orderID);
                        menuCmd.Parameters.AddWithValue("@menuID", item.MenuID);
                        menuCmd.Parameters.AddWithValue("@quantity", item.Quantity);
                        menuCmd.ExecuteNonQuery();
                    }

                    foreach (var merch in OrderSession.OrderedMerchandise)
                    {
                        string insertOrderMerchQuery = "INSERT INTO Order_Merchandise (order_ID, merch_ID, quantity) VALUES (@orderID, @merchID, @quantity)";
                        SqlCommand merchCmd = new SqlCommand(insertOrderMerchQuery, connection); // SILAP, patut guna insertOrderMerchQuery
                        merchCmd.Parameters.AddWithValue("@orderID", orderID);
                        merchCmd.Parameters.AddWithValue("@merchID", merch.MerchID);
                        merchCmd.Parameters.AddWithValue("@quantity", merch.Quantity);
                        merchCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment successful and order saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Terus buka ReceiptForm
                    receiptForm receipt = new receiptForm(orderID);
                    receipt.Show();
                    this.Close(); // Tutup checkoutForm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
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
