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
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ssyah\Source\Repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Load Customer data
                    SqlDataAdapter customerAdapter = new SqlDataAdapter("SELECT * FROM Customer", conn);
                    DataTable customerTable = new DataTable();
                    customerAdapter.Fill(customerTable);
                    customerDataGridView.DataSource = customerTable;

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
            this.tableAdapterManager.UpdateAll(this.customerDataSet);

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
    }
}
