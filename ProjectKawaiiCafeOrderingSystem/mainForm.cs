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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPwd.Text.Trim();

            // Check if either field is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ryuji Goda\OneDrive\Documents\GitHub\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT cust_ID FROM Customer WHERE cust_username = @cust_username AND cust_password = @cust_password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cust_username", username);
                    cmd.Parameters.AddWithValue("@cust_password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int custID = Convert.ToInt32(reader["cust_ID"]);
                        OrderSession.custID = custID;  

                        MessageBox.Show("Welcome! Login successful.", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        menuForm menuform = new menuForm(custID);
                        this.Hide();
                        menuform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during login:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
        }

        private void CheckBoxMembership_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxNoHP_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPwd.Text.Trim();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ryuji Goda\OneDrive\Documents\GitHub\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Admin WHERE admin_username = @admin_username AND admin_password = @admin_password";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@admin_username", username);
                    cmd.Parameters.AddWithValue("@admin_password", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                        MessageBox.Show("You are logged in as admin.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        adminForm adminPage = new adminForm();
                        this.Hide();
                        adminPage.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login error: " + ex.Message);
                }
            }
        }

        private void btnRegisteration_Click(object sender, EventArgs e)
        {
            this.Hide();               // Don't close this form
            registerForm register = new registerForm();
            register.ShowDialog();
            this.Show();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelKawaiTittle_Click(object sender, EventArgs e)
        {
        }
    }
}
