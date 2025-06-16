using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please Insert Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNoHP.Text))
            {
                MessageBox.Show("Please Insert Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNoHP.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Please Insert Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAddress.Focus();
                return;
            }

            if (CheckBoxMembership.Checked)
            {
                if (string.IsNullOrWhiteSpace(comboBoxMembership.Text))
                {
                    MessageBox.Show("Please select a membership type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxMembership.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxID.Text))
                {
                    MessageBox.Show("Please Insert Membership ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxID.Focus();
                    return;
                }
            }

            // Pass data to menuForm
            menuForm menuform = new menuForm();

            // Optionally: Pass values if menuForm has public properties

            this.Hide();
            menuform.ShowDialog();
            this.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            comboBoxMembership.Visible = false;
            labelType.Visible = false;
            labelID.Visible = false;
            textBoxID.Visible = false;
        }

        private void CheckBoxMembership_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = CheckBoxMembership.Checked;
            comboBoxMembership.Visible = isChecked;
            labelType.Visible = isChecked;
            labelID.Visible = isChecked;
            textBoxID.Visible = isChecked;
        }
    }
}
