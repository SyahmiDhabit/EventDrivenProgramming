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
    public partial class registerForm : Form
    {
<<<<<<< Updated upstream:ProjectKawaiiCafeOrderingSystem/registerForm.cs
        public registerForm()
=======
        private class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
            public int ImageIndex { get; set; }
            public List<string> AvailableColors { get; set; }
        }

        private List<Product> products = new List<Product>();
        private int currentIndex = 0;

        public merchandiseForm()
>>>>>>> Stashed changes:ProjectKawaiiCafeOrderingSystem/Form5.cs
        {
            InitializeComponent();
        }

<<<<<<< Updated upstream:ProjectKawaiiCafeOrderingSystem/registerForm.cs
        private void label3_Click(object sender, EventArgs e)
=======
        private void merchandiseForm_Load(object sender, EventArgs e)
        {
            numericUpDownQty.Maximum = 3;
            numericUpDownQty.Minimum = 0;

            textBoxCustName.MaxLength = 15;
            textBoxCustName.Visible = false;

            // Sample product list — update image index based on imageListMerch
            products.Add(new Product
            {
                Name = "Kawaii Tumblr",
                Price = 29.99m,
                Description = "Cute tumblr with cute Kawaii Cafe mascot",
                ImageIndex = 0,
                AvailableColors = new List<string> { "Blue", "Pink", "Grey" }
            });

            products.Add(new Product
            {
                Name = "Kawaii T-Shirt",
                Price = 49.90m,
                Description = "Exculusive T-Shirt from Kawaii Cafe with cute mascot",
                ImageIndex = 1,
                AvailableColors = new List<string> { "Black", "White", "Beige" }
            });

            products.Add(new Product
            {
                Name = "Kawaii Totebag",
                Price = 19.90m,
                Description = "Stylish Totebag with Exculusive Design from Kawaii Cafe",
                ImageIndex = 2,
                AvailableColors = new List<string> { "Beige", "Black", "Brown" }
            });

            DisplayProduct(currentIndex);
        }

        private void DisplayProduct(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                var p = products[index];
                labelProName.Text = p.Name;
                labelProPrice.Text = "RM " + p.Price.ToString("F2");
                labelDescription.Text = p.Description;

                if (imageListMerch.Images.Count > p.ImageIndex)
                    pictureBoxMerch.Image = imageListMerch.Images[p.ImageIndex];
                else
                    pictureBoxMerch.Image = null;

                comboBoxColor.Items.Clear();
                comboBoxColor.Items.AddRange(p.AvailableColors.ToArray());
                comboBoxColor.SelectedIndex = 0;

                numericUpDownQty.Value = 0;
                checkBoxCustName.Checked = false;
                textBoxCustName.Text = "";
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % products.Count;
            DisplayProduct(currentIndex);
        }

        private void buttonBack_Click(object sender, EventArgs e)
>>>>>>> Stashed changes:ProjectKawaiiCafeOrderingSystem/Form5.cs
        {
            currentIndex = (currentIndex - 1 + products.Count) % products.Count;
            DisplayProduct(currentIndex);
        }

        private void checkBoxCustName_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCustName.Visible = checkBoxCustName.Checked;
        }

        // Kosongkan fungsi lain buat masa ni
        private void labelMerchTittle_Click(object sender, EventArgs e) { }
        private void pictureBoxMerch_Click(object sender, EventArgs e) { }
        private void labelProName_Click(object sender, EventArgs e) { }
        private void labelProPrice_Click(object sender, EventArgs e) { }
        private void labelDescription_Click(object sender, EventArgs e) { }
        private void labelQty_Click(object sender, EventArgs e) { }
        private void numericUpDownQty_ValueChanged(object sender, EventArgs e) { }
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBoxCustName_TextChanged(object sender, EventArgs e) { }
        private void buttonPurchase_Click(object sender, EventArgs e) { }
        private void labelColor_Click(object sender, EventArgs e) { }
    }
}
