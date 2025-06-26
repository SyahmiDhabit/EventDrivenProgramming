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
    public partial class adminForm : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ryuji Goda\\OneDrive\\Documents\\GitHub\\EventDrivenProgramming\\ProjectKawaiiCafeOrderingSystem\\Database.mdf\";Integrated Security=True");

        public adminForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDatabase.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.dataSetDatabase.Menu);
            //// TODO: This line of code loads data into the 'dataSetDatabase.Menu' table. You can move, or remove it, as needed.
            //this.menuTableAdapter.Fill(this.dataSetDatabase.Menu);
            //// TODO: This line of code loads data into the 'dataSetDatabase.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.dataSetDatabase.Customer);

            // ✅ Add "All" to ComboBox
            comboBox1.Items.Add("All");

            try
            {
                conn.Open();
                SqlDataAdapter menuAdapter = new SqlDataAdapter("SELECT * FROM Menu", conn);
                DataTable menuTable = new DataTable();
                menuAdapter.Fill(menuTable);
                adminDataGridView.DataSource = menuTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin data:\n\n" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close(); // <-- Just close, don't dispose
            }

        }


        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
        }

        private void customerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker3.Value.Date;
            DateTime toDate = dateTimePicker4.Value.Date.AddDays(1).AddSeconds(-1);
            string searchText = textBox3.Text.Trim();

            // Check: only allow letters and spaces in search
            if (!System.Text.RegularExpressions.Regex.IsMatch(searchText, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("Search text can only contain letters and spaces. Numbers and special characters are not allowed.", "Invalid Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedType = comboBox1.SelectedItem?.ToString() ?? "All";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ryuji Goda\OneDrive\Documents\GitHub\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    m.menu_ID,
                    m.menu_name,
                    m.menu_price,
                    m.menu_type,
                    ISNULL(SUM(CASE 
                        WHEN o.order_date BETWEEN @fromDate AND @toDate THEN om.quantity 
                        ELSE 0 END), 0) AS total_sold,
                    ISNULL(SUM(CASE 
                        WHEN o.order_date BETWEEN @fromDate AND @toDate THEN om.quantity * m.menu_price 
                        ELSE 0 END), 0) AS total_income
                FROM Menu m
                LEFT JOIN Order_Menu om ON m.menu_ID = om.menu_ID
                LEFT JOIN [Order] o ON om.order_ID = o.order_ID
                WHERE (o.order_date BETWEEN @fromDate AND @toDate OR o.order_date IS NULL)
                  AND m.menu_name LIKE @search";

                    if (selectedType != "All")
                    {
                        query += " AND m.menu_type = @type";
                    }

                    query += @"
                GROUP BY m.menu_ID, m.menu_name, m.menu_price, m.menu_type
                ORDER BY total_sold DESC;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fromDate", fromDate);
                        cmd.Parameters.AddWithValue("@toDate", toDate);
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        if (selectedType != "All")
                        {
                            cmd.Parameters.AddWithValue("@type", selectedType);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        adminDataGridView.DataSource = null;
                        adminDataGridView.AutoGenerateColumns = true;
                        adminDataGridView.DataSource = table;

                        // Highlighting logic
                        HighlightRows(table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading summary: " + ex.Message);
                }
            }
        }


        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string menuName = menu_nameTextBox.Text;

            // Allow only letters and spaces (no numbers or symbols)
            if (!System.Text.RegularExpressions.Regex.IsMatch(menuName, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Menu name can only contain letters and spaces. No numbers or special characters are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string menuType = menu_typeTextBox.Text.Trim();

            // Check if menu_type is valid
            if (menuType != "Food" && menuType != "Drink" && menuType != "Dessert")
            {
                MessageBox.Show("Menu type must be one of the following: Food, Drink, or Dessert.", "Invalid Menu Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Menu (menu_ID, menu_type, menu_name, menu_price) VALUES (@menu_ID, @menu_type, @menu_name, @menu_price)", conn);
                cmd.Parameters.AddWithValue("@menu_ID", menu_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@menu_type", menu_typeTextBox.Text);
                cmd.Parameters.AddWithValue("@menu_name", menuName);
                cmd.Parameters.AddWithValue("@menu_price", menu_priceTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Menu added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding menu:\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            menu_IDTextBox.Clear();
            menu_typeTextBox.Clear();
            menu_nameTextBox.Clear();
            menu_priceTextBox.Clear();
        }


        private void menu_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void menu_typeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string menuName = menu_nameTextBox.Text;

            // Validate: only letters and spaces allowed
            if (!System.Text.RegularExpressions.Regex.IsMatch(menuName, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Menu name can only contain letters and spaces. No numbers or special characters are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string menuType = menu_typeTextBox.Text.Trim();

            // Check if menu_type is valid
            if (menuType != "Food" && menuType != "Drink" && menuType != "Dessert")
            {
                MessageBox.Show("Menu type must be one of the following: Food, Drink, or Dessert.", "Invalid Menu Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE menu SET menu_type = @menu_type, menu_name = @menu_name, menu_price = @menu_price WHERE menu_ID = @menu_ID", conn);
                cmd.Parameters.AddWithValue("@menu_ID", menu_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@menu_type", menu_typeTextBox.Text);
                cmd.Parameters.AddWithValue("@menu_name", menuName);
                cmd.Parameters.AddWithValue("@menu_price", menu_priceTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Menu updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating menu:\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            menu_IDTextBox.Clear();
            menu_typeTextBox.Clear();
            menu_nameTextBox.Clear();
            menu_priceTextBox.Clear();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM menu WHERE menu_ID = @menu_ID", conn);
                cmd.Parameters.AddWithValue("@menu_ID", menu_IDTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Menu deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting menu:\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            menu_IDTextBox.Clear();
            menu_typeTextBox.Clear();
            menu_nameTextBox.Clear();
            menu_priceTextBox.Clear();
        }

        private void HighlightRows(DataTable table)
        {
            int totalSoldColumnIndex = adminDataGridView.Columns["total_sold"].Index;

            int maxTotalSold = 0;

            foreach (DataRow row in table.Rows)
            {
                int totalSold = Convert.ToInt32(row["total_sold"]);
                if (totalSold > maxTotalSold)
                    maxTotalSold = totalSold;
            }

            foreach (DataGridViewRow gridRow in adminDataGridView.Rows)
            {
                int totalSold = Convert.ToInt32(gridRow.Cells["total_sold"].Value);

                if (totalSold == maxTotalSold && maxTotalSold > 0)
                {
                    // Most sold - green highlight
                    gridRow.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (totalSold == 0)
                {
                    // Never sold - red highlight
                    gridRow.DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }
    }
}
