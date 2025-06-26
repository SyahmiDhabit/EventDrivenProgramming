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

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ssyah\\source\\repos\\EventDrivenProgramming\\ProjectKawaiiCafeOrderingSystem\\Database.mdf;Integrated Security=True");

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
            //// TODO: This line of code loads data into the 'dataSetDatabase.Menu' table. You can move, or remove it, as needed.
            //this.menuTableAdapter.Fill(this.dataSetDatabase.Menu);
            //// TODO: This line of code loads data into the 'dataSetDatabase.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.dataSetDatabase.Customer);

            // ✅ Add "All" to ComboBox
            comboBox1.Items.Add("All");

            try
            {
                using (conn)
                {
                    conn.Open();
                    // Load Menu data
                    SqlDataAdapter menuAdapter = new SqlDataAdapter("SELECT * FROM Menu", conn);
                    DataTable menuTable = new DataTable();
                    menuAdapter.Fill(menuTable);
                    adminDataGridView.DataSource = menuTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin data:\n\n" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            DateTime toDate = dateTimePicker4.Value.Date.AddDays(1).AddSeconds(-1); // include full end date
            string searchText = textBox3.Text.Trim();
            string selectedType = comboBox1.SelectedItem?.ToString() ?? "All";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ssyah\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Start query with date and name filter
                    string query = @"
                SELECT 
                    m.menu_ID,
                    m.menu_name,
                    m.menu_price,
                    m.menu_type,
                    SUM(om.quantity) AS total_sold,
                    SUM(om.quantity * m.menu_price) AS total_income
                FROM Menu m
                JOIN Order_Menu om ON m.menu_ID = om.menu_ID
                JOIN [Order] o ON om.order_ID = o.order_ID
                WHERE o.order_date BETWEEN @fromDate AND @toDate
                  AND m.menu_name LIKE @search";

                    // Add menu type filter if not "All"
                    if (selectedType != "All")
                    {
                        query += " AND m.menu_type = @type";
                    }

                    query += @"
                GROUP BY m.menu_ID, m.menu_name, m.menu_price, m.menu_type
                ORDER BY total_sold DESC;
            ";

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
    }
}
