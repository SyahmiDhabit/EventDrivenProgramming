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
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SCSM11\Documents\GitHub\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";
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
            LoadMenuItems("Food", foodPrices, listBoxFood);
        }

        private void LoadDrinkList()
        {
            drinkPrices.Clear();
            listBoxDrink.Items.Clear();
            LoadMenuItems("Drink", drinkPrices, listBoxDrink);
        }

        private void LoadDessertList()
        {
            dessertPrices.Clear();
            listBoxDessert.Items.Clear();
            LoadMenuItems("Dessert", dessertPrices, listBoxDessert);
        }

        private void LoadMenuItems(string type, Dictionary<string, decimal> priceDict, ListBox listBox)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT menu_name, menu_price FROM Menu WHERE menu_type = @type";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@type", type);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["menu_name"].ToString();
                    decimal price = Convert.ToDecimal(reader["menu_price"]);
                    priceDict[name] = price;
                    listBox.Items.Add(name);
                }
                reader.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void btnFood_Click(object sender, EventArgs e) 
        {
            AddItem(listBoxFood, numericUpDownFood, foodPrices, listFood);
        }

        private void btnCheckOut_Click(object sender, EventArgs e) { }

        private void listFood_SelectedIndexChanged(object sender, EventArgs e) 
        {
            
        }

        private void checkedListBoxDessert_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnRemoveDessert_Click(object sender, EventArgs e) 
        {
            RemoveItem(ListDessert);
        }

        private void RemoveItem(ListBox orderListBox)
        {
            int index = orderListBox.SelectedIndex;
            if (index >= 0)
            {
                string itemText = orderListBox.Items[index].ToString();
                string name = itemText.Split(new[] { " x" }, StringSplitOptions.None)[0].Trim();

                orderListBox.Items.RemoveAt(index);

                var itemToRemove = OrderSession.OrderedItems
                    .FirstOrDefault(i => i.Name == name);
                if (itemToRemove != null)
                {
                    OrderSession.OrderedItems.Remove(itemToRemove);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void AddItem(ListBox menuListBox, NumericUpDown qtyControl, Dictionary<string, decimal> priceDict, ListBox orderListBox)
        {
            string selected = menuListBox.SelectedItem?.ToString();
            if (selected == null)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            int qty = (int)qtyControl.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            decimal price = priceDict[selected];
            decimal total = qty * price;

            int menuID = GetMenuIDByName(selected);
            if (menuID <= 0)
            {
                MessageBox.Show("Failed to get Menu ID for selected item.");
                return;
            }

            orderListBox.Items.Add($"{selected} x{qty} - RM {total:F2}");

            OrderSession.OrderedItems.Add(new OrderItem
            {
                MenuID = menuID,
                Name = selected,
                Quantity = qty,
                TotalPrice = total
            });
        }

        private int GetMenuIDByName(string menuName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT menu_ID FROM Menu WHERE menu_name = @name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", menuName);

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int menuID))
                {
                    return menuID;
                }
                else
                {
                    return -1; // Return -1 kalau tak jumpa
                }
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
            RemoveItem(listFood);
        }

        private void btnRemDrink_Click(object sender, EventArgs e)
        {
            RemoveItem(listDrink);
        }

        private void btnAddDessert_Click_1(object sender, EventArgs e) 
        {
            AddItem(listBoxDessert, numericUpDownDessert, dessertPrices, ListDessert);
        }

        private void btnAddDrink_Click_1(object sender, EventArgs e) 
        {
            AddItem(listBoxDrink, numericUpDownDrink, drinkPrices, listDrink);
        }

        private void labelPriceFood_Click(object sender, EventArgs e) { }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e) { }

        private void menuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnNext_Click(object sender, EventArgs e) 
        {
            if (OrderSession.OrderedItems.Count == 0)
            {
                MessageBox.Show("Please add at least one item to your order.");
                return;
            }

            // Don't insert into DB yet, only go to merchandise form
            merchandiseForm merchForm = new merchandiseForm(this);
            merchForm.Show();
            this.Hide();
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
                // Tunjuk harga
                string selected = listBoxFood.SelectedItem.ToString();
                decimal price = foodPrices[selected];
                labelPriceFood.Text = $"RM {price:F2}";

                // Tunjuk gambar ikut index
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
