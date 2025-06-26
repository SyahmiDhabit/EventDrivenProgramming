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
            "Limited edition pastel tumbler for cold & hot drinks.",
            "Soft cotton shirt with cute character print.",
            "Eco-friendly canvas bag with kawaii design."
        };
        private readonly List<string> colorOptions = new List<string>() { "Black", "Beige", "Blue" };
        private int currentIndex = 0;

        private void merchandiseForm_Load(object sender, EventArgs e)
        {
            numericUpDownQty.Maximum = 3;
            numericUpDownQty.Minimum = 0;
            textBoxCustName.MaxLength = 15;
            textBoxCustName.Visible = false;

            if (products.Count == 0)
                LoadMerchandiseFromDatabase();

            if (products.Count > 0)
                DisplayProduct(currentIndex);

            // ✅ Repopulate listBoxMerchandise from OrderedMerchandise
            listBoxMerchandise.Items.Clear();
            foreach (var item in OrderSession.OrderedMerchandise)
            {
                if (item.IsMerchandise)
                {
                    string itemDescription = $"{item.Quantity} x {item.Name}";
                    listBoxMerchandise.Items.Add(itemDescription);
                }
            }
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

                // ✅ Fix image indexing:
                if (imageListMerch.Images.Count >= products.Count)
                {
                    pictureBoxMerch.Image = imageListMerch.Images[index];
                }
                else if (imageListMerch.Images.Count >= 3)
                {
                    pictureBoxMerch.Image = imageListMerch.Images[index % 3];
                }
                else
                {
                    pictureBoxMerch.Image = null;
                }

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

            // Clear semua ordered merchandise sebelum proses semula
            OrderSession.OrderedMerchandise.RemoveAll(item => item.IsMerchandise);

            if (listBoxMerchandise.Items.Count == 0)
            {
                MessageBox.Show("You did not select any merchandise. Proceeding to checkout.",
                    "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var item in listBoxMerchandise.Items)
                {
                    string itemText = item.ToString();

                    try
                    {
                        int xIndex = itemText.IndexOf('x');
                        string qtyPart = itemText.Substring(0, xIndex).Trim();
                        int quantity = int.Parse(qtyPart);

                        string rest = itemText.Substring(xIndex + 1).Trim();

                        int colorStart = rest.IndexOf('(');
                        int colorEnd = rest.IndexOf(')');

                        string name = rest.Substring(0, colorStart).Trim();
                        string color = rest.Substring(colorStart + 1, colorEnd - colorStart - 1).Trim();

                        string customName = "";
                        int dashIndex = rest.IndexOf('-', colorEnd);
                        if (dashIndex != -1)
                        {
                            customName = rest.Substring(dashIndex + 1).Trim();
                        }

                        Product selectedProduct = products.Find(p => p.Name == name);

                        if (selectedProduct != null)
                        {
                            string itemDescription = $"{selectedProduct.Name} ({color})";
                            if (!string.IsNullOrEmpty(customName))
                            {
                                itemDescription += $" - {customName}";
                            }

                            decimal totalPrice = selectedProduct.Price * quantity;

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
                        }
                    }
                    catch
                    {
                        MessageBox.Show($"Failed to process item: {itemText}");
                    }
                }
            }

            // Proceed to checkout
            checkoutForm checkout = new checkoutForm(_menuForm);
            this.Hide();
            checkout.ShowDialog();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show("No merchandise available.");
                return;
            }

            int quantity = (int)numericUpDownQty.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Please select a quantity greater than 0.");
                return;
            }

            var selectedProduct = products[currentIndex];
            string color = comboBoxColor.SelectedItem.ToString();
            string customName = checkBoxCustName.Checked ? textBoxCustName.Text.Trim() : "";

            string itemDescription = $"{quantity} x {selectedProduct.Name} ({color})";
            if (!string.IsNullOrEmpty(customName))
            {
                itemDescription += $" - {customName}";
            }

            listBoxMerchandise.Items.Add(itemDescription);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxMerchandise.SelectedIndex != -1)
            {
                listBoxMerchandise.Items.RemoveAt(listBoxMerchandise.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void listBoxMerchandise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
