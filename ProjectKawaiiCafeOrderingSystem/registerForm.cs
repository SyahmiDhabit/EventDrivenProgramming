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

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SCSM11\Documents\GitHub\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if customer ID exists
                    string checkIDQuery = "SELECT COUNT(*) FROM Customer WHERE cust_ID = @custID";
                    using (SqlCommand checkIDCmd = new SqlCommand(checkIDQuery, conn))
                    {
                        checkIDCmd.Parameters.AddWithValue("@custID", custID);
                        int idCount = (int)checkIDCmd.ExecuteScalar();

                        if (idCount > 0)
                        {
                            MessageBox.Show("Customer ID already exists. Please enter a different ID.");
                            return;
                        }
                    }

                    // Check if username exists
                    string checkUsernameQuery = "SELECT COUNT(*) FROM Customer WHERE cust_username = @username";
                    using (SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, conn))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("@username", username);
                        int usernameCount = (int)checkUsernameCmd.ExecuteScalar();

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.");
                            return;
                        }
                    }

                    // Insert new customer
                    string insertQuery = @"
                INSERT INTO Customer (cust_ID, cust_name, cust_phone, cust_username, cust_password)
                VALUES (@cust_ID, @cust_name, @cust_phone, @cust_username, @cust_password)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@cust_ID", custID);
                        cmd.Parameters.AddWithValue("@cust_name", custName);
                        cmd.Parameters.AddWithValue("@cust_phone", custPhone);
                        cmd.Parameters.AddWithValue("@cust_username", username);
                        cmd.Parameters.AddWithValue("@cust_password", password);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Member registered successfully!");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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
