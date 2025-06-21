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
        }
        private class Product
        {
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

        public merchandiseForm()
        {
            InitializeComponent();
            this.Load += merchandiseForm_Load;
        }

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
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pirat\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";
            string query = "SELECT merch_name, merch_price FROM Merchandise";

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
            var selectedProduct = products[currentIndex];
            string selectedColor = comboBoxColor.SelectedItem.ToString();
            int quantity = (int)numericUpDownQty.Value;
            string customName = checkBoxCustName.Checked ? textBoxCustName.Text.Trim() : "";
            if (quantity > 0)
            {
                // Save to TempSelection table
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pirat\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";
                string insertQuery = "INSERT INTO TempSelection (merch_name, merch_price, merch_custom, color, quantity) VALUES (@name, @price, @custom, @color, @qty)";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(insertQuery, conn);
                        cmd.Parameters.AddWithValue("@name", selectedProduct.Name);
                        cmd.Parameters.AddWithValue("@price", selectedProduct.Price);
                        cmd.Parameters.AddWithValue("@custom", customName);
                        cmd.Parameters.AddWithValue("@color", selectedColor);
                        cmd.Parameters.AddWithValue("@qty", quantity);
                        cmd.ExecuteNonQuery();
                    }

                    // ✅ Add to OrderSession
                    string displayName = $"{selectedProduct.Name} ({selectedColor})";
                    if (!string.IsNullOrEmpty(customName))
                        displayName += $" - {customName}";

                    OrderSession.OrderedItems.Add(new OrderItem
                    {
                        Name = displayName,
                        Quantity = quantity,
                        TotalPrice = selectedProduct.Price * quantity
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving selection: " + ex.Message);
                    return;
                }
            }

            this.Hide();
            checkoutForm checkout = new checkoutForm(_menuForm);
            checkout.ShowDialog();
        }

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