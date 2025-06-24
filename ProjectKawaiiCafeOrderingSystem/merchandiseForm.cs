using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectKawaiiCafeOrderingSystem
{
    public partial class merchandiseForm : Form
    {
        private menuForm _menuForm;

        public merchandiseForm(menuForm menu)
        {
            InitializeComponent();
            _menuForm = menu;
            this.Load += merchandiseForm_Load;
        }

        private class Product
        {
            public int MerchID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
        }

        private readonly List<Product> products = new List<Product>();
        private readonly List<string> descriptions = new List<string>()
        {
            "Kawaii Tumblr - Limited edition pastel tumbler for cold & hot drinks.",
            "Kawaii T-Shirt - Soft cotton shirt with cute character print.",
            "Kawaii Totebag - Eco-friendly canvas bag with kawaii design."
        };
        private readonly List<string> colorOptions = new List<string>() { "Black", "Beige", "Blue" };
        private int currentIndex = 0;

        private void merchandiseForm_Load(object sender, EventArgs e)
        {
            numericUpDownQty.Maximum = 3;
            numericUpDownQty.Minimum = 0;
            textBoxCustName.MaxLength = 15;
            textBoxCustName.Visible = false;

            LoadMerchandiseFromDatabase();

            if (products.Count > 0)
                DisplayProduct(currentIndex);
        }

        private void LoadMerchandiseFromDatabase()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ssyah\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";
            string query = "SELECT merch_ID, merch_name, merch_price FROM Merchandise";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Product p = new Product
                        {
                            MerchID = Convert.ToInt32(reader["merch_ID"]),
                            Name = reader["merch_name"].ToString(),
                            Price = Convert.ToDecimal(reader["merch_price"]),
                            Description = descriptions[products.Count % descriptions.Count]
                        };
                        products.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading merchandise: " + ex.Message);
            }
        }

        private void DisplayProduct(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                var p = products[index];
                labelProName.Text = p.Name;
                labelProPrice.Text = "RM " + p.Price.ToString("F2");
                labelDescription.Text = p.Description;

                if (imageListMerch.Images.Count > index)
                    pictureBoxMerch.Image = imageListMerch.Images[index];
                else
                    pictureBoxMerch.Image = null;

                comboBoxColor.Items.Clear();
                comboBoxColor.Items.AddRange(colorOptions.ToArray());
                comboBoxColor.SelectedIndex = 0;

                numericUpDownQty.Value = 0;
                checkBoxCustName.Checked = false;
                textBoxCustName.Text = "";
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (products.Count == 0) return;
            currentIndex = (currentIndex + 1) % products.Count;
            DisplayProduct(currentIndex);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (products.Count == 0) return;
            currentIndex = (currentIndex - 1 + products.Count) % products.Count;
            DisplayProduct(currentIndex);
        }

        private void checkBoxCustName_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCustName.Visible = checkBoxCustName.Checked;
        }

        private void buttonNextForm_Click(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show("No merchandise available.");
                return;
            }

            int quantity = (int)numericUpDownQty.Value;

            if (quantity > 0)
            {
                var selectedProduct = products[currentIndex];
                string color = comboBoxColor.SelectedItem.ToString();
                string customName = checkBoxCustName.Checked ? textBoxCustName.Text.Trim() : "";

                string itemDescription = $"{selectedProduct.Name} ({color})";
                if (!string.IsNullOrEmpty(customName))
                {
                    itemDescription += $" - {customName}";
                }

                decimal totalPrice = selectedProduct.Price * quantity;

                // Tambah item terus ke OrderSession.OrderedMerchandise
                OrderSession.OrderedMerchandise.Add(new OrderItem
                {
                    MenuID = 0,
                    Name = itemDescription,
                    Price = selectedProduct.Price,
                    Quantity = quantity,
                    TotalPrice = totalPrice,
                    IsMerchandise = true,
                    MerchID = selectedProduct.MerchID
                });

                MessageBox.Show($"{quantity} x {itemDescription} added to your order.", "Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You did not select any merchandise. Proceeding to checkout.",
                    "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Terus ke checkout
            checkoutForm checkout = new checkoutForm(_menuForm);
            this.Hide();
            checkout.Show();
        }

        // Event handlers kosong
        private void labelMerchTittle_Click(object sender, EventArgs e) { }
        private void pictureBoxMerch_Click(object sender, EventArgs e) { }
        private void labelProName_Click(object sender, EventArgs e) { }
        private void labelProPrice_Click(object sender, EventArgs e) { }
        private void labelDescription_Click(object sender, EventArgs e) { }
        private void labelQty_Click(object sender, EventArgs e) { }
        private void numericUpDownQty_ValueChanged(object sender, EventArgs e) { }
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBoxCustName_TextChanged(object sender, EventArgs e) { }
        private void labelColor_Click(object sender, EventArgs e) { }
    }
}
