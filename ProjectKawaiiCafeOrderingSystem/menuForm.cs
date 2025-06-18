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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ssyah\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True");

        public menuForm()
        {
            InitializeComponent();

        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadMenuData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ssyah\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlDataAdapter foodAdapter = new SqlDataAdapter("SELECT * FROM Menu WHERE menu_type = 'Food'", conn);
                DataTable foodTable = new DataTable();
                foodAdapter.Fill(foodTable);
                FoodDataGridView.DataSource = foodTable;

                SqlDataAdapter drinkAdapter = new SqlDataAdapter("SELECT * FROM Menu WHERE menu_type = 'Drink'", conn);
                DataTable drinkTable = new DataTable();
                drinkAdapter.Fill(drinkTable);
                DrinkDataGridView.DataSource = drinkTable;

                SqlDataAdapter dessertAdapter = new SqlDataAdapter("SELECT * FROM Menu WHERE menu_type = 'Dessert'", conn);
                DataTable dessertTable = new DataTable();
                dessertAdapter.Fill(dessertTable);
                DessertDataGridView.DataSource = dessertTable;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void btnFood_Click(object sender, EventArgs e) { }

        private void btnCheckOut_Click(object sender, EventArgs e) { }

        private void listFood_SelectedIndexChanged(object sender, EventArgs e) { }

        private void checkedListBoxDessert_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnRemoveDessert_Click(object sender, EventArgs e) { }

        private void groupBoxFood_Enter(object sender, EventArgs e) { }

        private void ListDessert_SelectedIndexChanged(object sender, EventArgs e) { }

        private void listDrink_SelectedIndexChanged(object sender, EventArgs e) { }

        private void checkedListBoxFood_SelectedIndexChanged(object sender, EventArgs e) { }

        private void checkedListBoxFood_SelectedIndexChanged_1(object sender, EventArgs e) { }

        private void btnAddFood_Click(object sender, EventArgs e) { }

        private void checkedListBoxDessert_SelectedIndexChanged_1(object sender, EventArgs e) { }

        private void btnAddDessert_Click(object sender, EventArgs e) { }

        private void checkedListBoxDrink_SelectedIndexChanged(object sender, EventArgs e){ }

        private void btnAddDrink_Click(object sender, EventArgs e) { }

        private void btnRemFood_Click(object sender, EventArgs e)
        {
          
        }
        
        private void btnRemDrink_Click(object sender, EventArgs e) { }
       
        private void btnAddDessert_Click_1(object sender, EventArgs e) { }
        
        private void btnAddDrink_Click_1(object sender, EventArgs e) { }
       
        private void labelPriceFood_Click(object sender, EventArgs e)
        {

        }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void menuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnNext_Click(object sender, EventArgs e) { }

        private void labelQtyDessert_Click(object sender, EventArgs e) { }

        private void labelPriceDessert_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void groupBoxDessert_Enter(object sender, EventArgs e) { }

        private void DrinkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void groupBoxDrink_Enter(object sender, EventArgs e) { }

        private void numericUpDownFood_ValueChanged(object sender, EventArgs e) { }
    }
}
