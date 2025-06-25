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
    public partial class menuForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\SCSM11\\Documents\\GitHub\\EventDrivenProgramming\\ProjectKawaiiCafeOrderingSystem\\Database.mdf\";Integrated Security=True");
        private Dictionary<string, decimal> foodPrices = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> drinkPrices = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> dessertPrices = new Dictionary<string, decimal>();
        public int custId;
        public int orderId;
        public menuForm(int custId)
        {
            this.custId = custId;
            InitializeComponent();

        }

        private bool orderCreated = false;

        private void menuForm_Load(object sender, EventArgs e)
        {
            if (orderCreated) return;
            orderCreated = true;

            DateTime orderDateTime = DateTime.Now;
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand(
                "INSERT INTO [dbo].[Order] (order_date, cust_ID) VALUES (@orderDateTime, @custId);SELECT SCOPE_IDENTITY();", conn);
            sqlCommand.Parameters.AddWithValue("@orderDateTime", orderDateTime);
            sqlCommand.Parameters.AddWithValue("@custId", custId);

            this.orderId = Convert.ToInt32(sqlCommand.ExecuteScalar());
            conn.Close();

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
            conn.Close();
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
            orderListBox.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Order_Menu JOIN Menu ON Order_Menu.menu_ID = Menu.menu_ID WHERE Order_Menu.order_ID = @order_ID AND Menu.menu_type = 'Food'");
            conn.Close();
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

            orderListBox.Items.Add($"{selected} x{qty} - RM {total:F2}");

            OrderSession.OrderedItems.Add(new OrderItem
            {
                Name = selected,
                Quantity = qty,
                TotalPrice = total
            });


            int menuId = 0; // initialized value 

            conn.Open();
            // menu_ID query form 
            

            SqlCommand menuIdQuery = new SqlCommand(
            "SELECT menu_ID FROM Menu WHERE RTRIM(LTRIM(menu_name)) = @selected", conn);
            menuIdQuery.Parameters.AddWithValue("@selected", selected.Trim());

            menuIdQuery.Connection = conn;

            // query result
            object result = menuIdQuery.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out menuId))
            {
                MessageBox.Show($"Inserting menu_ID={menuId}, order_ID={orderId}, qty={qty}");
                if (menuId > 0)
                {
                    // insert to database
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Order_Menu] (order_ID, menu_ID, quantity) VALUES(@order_id, @menu_id, @qty)", conn);
                    cmd.Parameters.AddWithValue("@order_id", orderId);
                    cmd.Parameters.AddWithValue("@menu_id", menuId);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show($"Menu ID not found. Result was: {result}");
            }

            MessageBox.Show($"Selected = '{selected}'");


            conn.Close();
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
