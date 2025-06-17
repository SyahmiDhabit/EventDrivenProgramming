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
       

        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'menuDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.menuDataSet.Menu);

            LoadMenuData();

        }

        private void LoadMenuData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ssyah\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True"; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Load Food
                SqlDataAdapter foodAdapter = new SqlDataAdapter("SELECT * FROM Menu WHERE menu_type = 'Food'", conn);
                DataTable foodTable = new DataTable();
                foodAdapter.Fill(foodTable);
                FoodDataGridView.DataSource = foodTable;

                // Load Drink
                SqlDataAdapter drinkAdapter = new SqlDataAdapter("SELECT * FROM Menu WHERE menu_type = 'Drink'", conn);
                DataTable drinkTable = new DataTable();
                drinkAdapter.Fill(drinkTable);
                DrinkDataGridView.DataSource = drinkTable;

                // Load Dessert
                SqlDataAdapter dessertAdapter = new SqlDataAdapter("SELECT * FROM Menu WHERE menu_type = 'Dessert'", conn);
                DataTable dessertTable = new DataTable();
                dessertAdapter.Fill(dessertTable);
                DessertDataGridView.DataSource = dessertTable;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void listFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxDessert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveDessert_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBoxFood_Enter(object sender, EventArgs e)
        {

        }

        private void ListDessert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listDrink_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxFood_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBoxDessert_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnAddDessert_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBoxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemFood_Click(object sender, EventArgs e)
        {

        }

        private void btnRemDrink_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDessert_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnAddDrink_Click_1(object sender, EventArgs e)
        {
            

        }

        private void labelPriceFood_Click(object sender, EventArgs e)
        {

        }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.menuDataSet);

        }

        private void menuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = FoodDataGridView.Rows[e.RowIndex];
                string itemName = row.Cells["menu_name"].Value.ToString();
                string price = row.Cells["menu_price"].Value.ToString();
                MessageBox.Show($"Food Selected: {itemName}\nPrice: {price}");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void labelQtyDessert_Click(object sender, EventArgs e)
        {

        }

        private void labelPriceDessert_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DessertDataGridView.Rows[e.RowIndex];
                string itemName = row.Cells["menu_name"].Value.ToString();
                string price = row.Cells["menu_price"].Value.ToString();
                MessageBox.Show($"Dessert Selected: {itemName}\nPrice: {price}");
            }
        }

        private void groupBoxDessert_Enter(object sender, EventArgs e)
        {

        }

        private void DrinkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DrinkDataGridView.Rows[e.RowIndex];
                string itemName = row.Cells["menu_name"].Value.ToString();
                string price = row.Cells["menu_price"].Value.ToString();
                MessageBox.Show($"Drink Selected: {itemName}\nPrice: {price}");
            }
        }

        private void groupBoxDrink_Enter(object sender, EventArgs e)
        {

        }
    }
}
