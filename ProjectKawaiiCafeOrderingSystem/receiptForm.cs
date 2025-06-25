using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectKawaiiCafeOrderingSystem
{
    public partial class receiptForm : Form
    {
        private int orderID;

        public receiptForm(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }

        private void receiptForm_Load(object sender, EventArgs e)
        {
            LoadReceiptData();
        }

        private void LoadReceiptData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ssyah\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True"))
                {
                    connection.Open();

                    string query = @"
                -- Menu Items
                SELECT 
                    m.menu_name AS [Item Name], 
                    om.quantity AS [Quantity], 
                    m.menu_price AS [Unit Price], 
                    (m.menu_price * om.quantity) AS [Total Price]
                FROM [Order_Menu] om
                JOIN [Menu] m ON om.menu_ID = m.menu_ID
                WHERE om.order_ID = @orderID

                UNION ALL

                -- Merchandise Items
                SELECT 
                    merch.merch_name AS [Item Name], 
                    om.quantity AS [Quantity], 
                    merch.merch_price AS [Unit Price], 
                    (merch.merch_price * om.quantity) AS [Total Price]
                FROM [Order_Merchandise] om
                JOIN [Merchandise] merch ON om.merch_ID = merch.merch_ID
                WHERE om.order_ID = @orderID
            ";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@orderID", orderID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading receipt data: " + ex.Message);
            }
        }

      
    }
}
