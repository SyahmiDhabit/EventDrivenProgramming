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

namespace ProjectKawaiiCafeOrderingSystem
{
    public partial class menuForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ssyah\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";
        private Dictionary<string, decimal> foodPrices = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> drinkPrices = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> dessertPrices = new Dictionary<string, decimal>();



        public menuForm()
        {
            InitializeComponent();

        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            LoadFoodList();
            LoadDrinkList();
            LoadDessertList();
        }

        private void LoadFoodList()
        {
            foodPrices.Clear();
            listBoxFood.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT menu_name, menu_price FROM Menu WHERE menu_type = 'Food'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["menu_name"].ToString();
                    decimal price = Convert.ToDecimal(reader["menu_price"]);

                    foodPrices[name] = price;
                    listBoxFood.Items.Add(name);
                }

                reader.Close();
            }
        }

        private void LoadDrinkList()
        {
            drinkPrices.Clear();
            listBoxDrink.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT menu_name, menu_price FROM Menu WHERE menu_type = 'Drink'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["menu_name"].ToString();
                    decimal price = Convert.ToDecimal(reader["menu_price"]);

                    drinkPrices[name] = price;
                    listBoxDrink.Items.Add(name);
                }

                reader.Close();
            }
        }

        private void LoadDessertList()
        {
            dessertPrices.Clear();
            listBoxDessert.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT menu_name, menu_price FROM Menu WHERE menu_type = 'Dessert'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["menu_name"].ToString();
                    decimal price = Convert.ToDecimal(reader["menu_price"]);

                    dessertPrices[name] = price;
                    listBoxDessert.Items.Add(name);
                }

                reader.Close();
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void btnFood_Click(object sender, EventArgs e) 
        {
            string selected = listBoxFood.SelectedItem?.ToString();
            if (selected == null)
            {
                MessageBox.Show("Please select a food item.");
                return;
            }

            int qty = (int)numericUpDownFood.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            decimal price = foodPrices[selected];
            decimal total = qty * price;

            listFood.Items.Add($"{selected} x{qty} - RM {total:F2}");
        }

        private void btnCheckOut_Click(object sender, EventArgs e) { }

        private void listFood_SelectedIndexChanged(object sender, EventArgs e) 
        {
            string selected = listBoxFood.SelectedItem?.ToString();
            if (selected == null)
            {
                MessageBox.Show("Please select a food item.");
                return;
            }

            int qty = (int)numericUpDownFood.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            decimal price = foodPrices[selected];
            decimal total = qty * price;

            listFood.Items.Add($"{selected} x{qty} - RM {total:F2}");
        }

        private void checkedListBoxDessert_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnRemoveDessert_Click(object sender, EventArgs e) 
        {
            if (ListDessert.SelectedIndex >= 0)
            {
                ListDessert.Items.RemoveAt(ListDessert.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a dessert to remove.");
            }
        }

        private void groupBoxFood_Enter(object sender, EventArgs e) { }

        private void ListDessert_SelectedIndexChanged(object sender, EventArgs e) { }

        private void listDrink_SelectedIndexChanged(object sender, EventArgs e) { }

        private void checkedListBoxFood_SelectedIndexChanged(object sender, EventArgs e) { }

        private void checkedListBoxFood_SelectedIndexChanged_1(object sender, EventArgs e) { }

        private void btnAddFood_Click(object sender, EventArgs e) { }

        private void checkedListBoxDessert_SelectedIndexChanged_1(object sender, EventArgs e) { }

        private void btnAddDessert_Click(object sender, EventArgs e) { }

        private void checkedListBoxDrink_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnAddDrink_Click(object sender, EventArgs e) { }

        private void btnRemFood_Click(object sender, EventArgs e)
        {
            if (listFood.SelectedIndex >= 0)
            {
                listFood.Items.RemoveAt(listFood.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void btnRemDrink_Click(object sender, EventArgs e)
        {
            if (listDrink.SelectedIndex >= 0)
            {
                listDrink.Items.RemoveAt(listDrink.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a drink to remove.");
            }
        }

        private void btnAddDessert_Click_1(object sender, EventArgs e) 
        {
            string selected = listBoxDessert.SelectedItem?.ToString();
            if (selected == null)
            {
                MessageBox.Show("Please select a dessert item.");
                return;
            }

            int qty = (int)numericUpDownDessert.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            decimal price = dessertPrices[selected];
            decimal total = qty * price;

            ListDessert.Items.Add($"{selected} x{qty} - RM {total:F2}");
        }

        private void btnAddDrink_Click_1(object sender, EventArgs e) 
        {
            string selected = listBoxDrink.SelectedItem?.ToString();
            if (selected == null)
            {
                MessageBox.Show("Please select a drink item.");
                return;
            }

            int qty = (int)numericUpDownDrink.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            decimal price = drinkPrices[selected];
            decimal total = qty * price;

            listDrink.Items.Add($"{selected} x{qty} - RM {total:F2}");
        }

        private void labelPriceFood_Click(object sender, EventArgs e) { }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e) { }

        private void menuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnNext_Click(object sender, EventArgs e) 
        {
            List<string> selectedMenuItems = new List<string>();

            foreach (string item in listFood.Items)
                selectedMenuItems.Add(item.Split('x')[0].Trim());

            foreach (string item in listDrink.Items)
                selectedMenuItems.Add(item.Split('x')[0].Trim());

            foreach (string item in ListDessert.Items)
                selectedMenuItems.Add(item.Split('x')[0].Trim());

            if (selectedMenuItems.Count == 0)
            {
                MessageBox.Show("Please select at least one item before continuing.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand getMaxIdCmd = new SqlCommand("SELECT ISNULL(MAX(order_ID), 0) + 1 FROM [Order]", conn);
                int newOrderID = (int)getMaxIdCmd.ExecuteScalar();

                foreach (string itemName in selectedMenuItems)
                {
                    SqlCommand getMenuIDCmd = new SqlCommand("SELECT menu_ID FROM Menu WHERE menu_name = @name", conn);
                    getMenuIDCmd.Parameters.AddWithValue("@name", itemName);
                    object result = getMenuIDCmd.ExecuteScalar();

                    if (result != null)
                    {
                        int menuID = Convert.ToInt32(result);

                        SqlCommand insertCmd = new SqlCommand(
                            "INSERT INTO [Order] (order_ID, order_date, cust_ID, menu_ID, merch_ID) VALUES (@order_ID, @order_date, @cust_ID, @menu_ID, @merch_ID)", conn);
                        insertCmd.Parameters.AddWithValue("@order_ID", newOrderID);
                        insertCmd.Parameters.AddWithValue("@order_date", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@cust_ID", 1);
                        insertCmd.Parameters.AddWithValue("@menu_ID", menuID);
                        insertCmd.Parameters.AddWithValue("@merch_ID", 1);

                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void labelQtyDessert_Click(object sender, EventArgs e) { }

        private void labelPriceDessert_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void groupBoxDessert_Enter(object sender, EventArgs e) { }

        private void DrinkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void groupBoxDrink_Enter(object sender, EventArgs e) { }

        private void numericUpDownFood_ValueChanged(object sender, EventArgs e) { }

        private void labelFood_Click(object sender, EventArgs e) { }

        private void labelPrice_Click(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxFood.SelectedIndex;
            if (index >= 0)
            {
                string selected = listBoxFood.SelectedItem.ToString();
                decimal price = foodPrices[selected];
                labelPriceFood.Text = $"RM {price:F2}";

                if (index < imageListFood.Images.Count)
                {
                    pictureBoxFood.Image = imageListFood.Images[index];
                    pictureBoxFood.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBoxFood.Image = null;
                }
            }
        }

            private void pictureBoxFood_Click(object sender, EventArgs e) { }

        private void pictureBoxDrink_Click(object sender, EventArgs e)
        {

        }

        private void listBoxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxDrink.SelectedIndex;
            if (index >= 0)
            {
                string selected = listBoxDrink.SelectedItem.ToString();
                decimal price = drinkPrices[selected];
                labelPriceDrink.Text = $"RM {price:F2}";

                if (index < imageListDrink.Images.Count)
                {
                    pictureBoxDrink.Image = imageListDrink.Images[index];
                    pictureBoxDrink.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBoxDrink.Image = null;
                }
            }
        }

        private void listBoxDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxDessert.SelectedIndex;
            if (index >= 0)
            {
                string selected = listBoxDessert.SelectedItem.ToString();
                decimal price = dessertPrices[selected];
                labelPriceDessert.Text = $"RM {price:F2}";

                if (index < imageListDessert.Images.Count)
                {
                    pictureBoxDessert.Image = imageListDessert.Images[index];
                    pictureBoxDessert.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBoxDessert.Image = null;
                }
            }
        }
    }
}
