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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e){ }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string custID = textBoxID.Text.Trim();
            string custName = textBoxName.Text.Trim();
            string custPhone = textBoxPhone.Text.Trim();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPwd.Text.Trim();
 

            // Validation
            if (string.IsNullOrWhiteSpace(custID) || string.IsNullOrWhiteSpace(custName) ||
                string.IsNullOrWhiteSpace(custPhone) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

           

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ssyah\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO Customer (cust_ID, cust_name, cust_phone, cust_username, cust_password, cust_membertype)
                VALUES (@cust_ID, @cust_name, @cust_phone, @cust_username, @cust_password)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cust_ID", custID);
                    cmd.Parameters.AddWithValue("@cust_name", custName);
                    cmd.Parameters.AddWithValue("@cust_phone", custPhone);
                    cmd.Parameters.AddWithValue("@cust_username", username);
                    cmd.Parameters.AddWithValue("@cust_password", password);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Member registered successfully!");

                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        

        private void labelKawaiTittle_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxMembership_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void labelTypeMembership_Click(object sender, EventArgs e){ }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e){ }

        private void textBoxName_TextChanged(object sender, EventArgs e){ }

        private void textBoxPhone_TextChanged(object sender, EventArgs e){ }

        private void textBoxPwd_TextChanged(object sender, EventArgs e){ }

        private void textBoxUsername_TextChanged(object sender, EventArgs e){ }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainform = new mainForm();
            mainform.ShowDialog();
            this.Close();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
