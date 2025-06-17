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
            comboBoxType.Visible = false;
            labelTypeMembership.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e){ }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string custID = textBoxID.Text.Trim();
            string custName = textBoxName.Text.Trim();
            string custPhone = textBoxPhone.Text.Trim();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPwd.Text.Trim();
            string membership = checkBoxMembership.Checked ? comboBoxType.SelectedItem?.ToString() : "None";

            // Validation
            if (string.IsNullOrWhiteSpace(custID) || string.IsNullOrWhiteSpace(custName) ||
                string.IsNullOrWhiteSpace(custPhone) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (checkBoxMembership.Checked && string.IsNullOrEmpty(membership))
            {
                MessageBox.Show("Please select a membership type.");
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ssyah\source\repos\EventDrivenProgramming\ProjectKawaiiCafeOrderingSystem\Database.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO Customer (cust_ID, cust_name, cust_phone, cust_username, cust_password, cust_membertype)
                VALUES (@cust_ID, @cust_name, @cust_phone, @cust_username, @cust_password, @cust_membership)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cust_ID", custID);
                    cmd.Parameters.AddWithValue("@cust_name", custName);
                    cmd.Parameters.AddWithValue("@cust_phone", custPhone);
                    cmd.Parameters.AddWithValue("@cust_username", username);
                    cmd.Parameters.AddWithValue("@cust_password", password);
                    cmd.Parameters.AddWithValue("@cust_membership", membership);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Member registered successfully!");

                        // Apply discount message based on membership
                        string discountMessage = "";
                        switch (membership)
                        {
                            case "Premium":
                                discountMessage = "You are eligible for a 20% discount!";
                                break;
                            case "Gold":
                                discountMessage = "You are eligible for a 15% discount!";
                                break;
                            case "Silver":
                                discountMessage = "You are eligible for a 10% discount!";
                                break;
                            default:
                                discountMessage = "No discount applied.";
                                break;
                        }

                        MessageBox.Show(discountMessage);

                        // Clear form fields
                        textBoxID.Clear();
                        textBoxName.Clear();
                        textBoxPhone.Clear();
                        textBoxUsername.Clear();
                        textBoxPwd.Clear();
                        checkBoxMembership.Checked = false;
                        comboBoxType.SelectedIndex = -1;
                        comboBoxType.Visible = false;
                        labelTypeMembership.Visible = false;

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
            if (checkBoxMembership.Checked)
            {
                comboBoxType.Visible = true; // Show combo box when checked
                labelTypeMembership.Visible = true;
            }
            else
            {
                comboBoxType.Visible = false; // Hide combo box when unchecked
                labelTypeMembership.Visible = false;
            }
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
    }
}
