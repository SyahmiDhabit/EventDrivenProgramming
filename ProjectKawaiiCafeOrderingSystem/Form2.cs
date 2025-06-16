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
    public partial class menuForm : Form
    {
        Dictionary<string, decimal> foodPrices = new Dictionary<string, decimal>()
        {
            {"Chicken Lasagna", 15},
            {"Spaghetti Carbonara", 13},
            {"Chicken Chop", 14},
            {"Tomyam Seafood", 12},
            {"Buttermilk Chicken", 13},
            {"Spaghetti Agio Olio", 11},
            {"Fish & Chips", 15}
        };

        Dictionary<string, decimal> dessertPrices = new Dictionary<string, decimal>()
        {
            {"Chocolate Moist Cake", 8},
            {"Matcha Burn Cheese Cake", 9},
            {"Tiramisu", 8},
            {"Chocolate Donut", 4},
            {"Cheese Cupcake", 5},
            {"Blueberry Cupcake", 5},
            {"Vanilla Cake", 6},
            {"Eggtart", 3}
        };

        Dictionary<string, decimal> drinkPrices = new Dictionary<string, decimal>()
        {
            {"Matcha Latte", 7},
            {"Green Tea Kaw Kaw", 6},
            {"Thai Tea Kaw Kaw", 6},
            {"Australian Chocolate", 7},
            {"Ice Spanish Latte", 8},
            {"Buttercrem`e Latte", 9},
            {"Ice Viatnamese Latte", 9}
        };

        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            checkedListBoxFood.Items.AddRange(foodPrices.Keys.ToArray());
            checkedListBoxDessert.Items.AddRange(dessertPrices.Keys.ToArray());
            checkedListBoxDrink.Items.AddRange(drinkPrices.Keys.ToArray());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxFood.CheckedItems)
            {
                listFood.Items.Add(item);

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void listFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxDessert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveDessert_Click(object sender, EventArgs e)
        {
            if (ListDessert.SelectedIndex != -1)
            {
                ListDessert.Items.RemoveAt(ListDessert.SelectedIndex);
            }
        }

        private void groupBoxFood_Enter(object sender, EventArgs e)
        {

        }

        private void ListDessert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listDrink_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxFood_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = checkedListBoxFood.SelectedIndex;
            if (index >= 0 && index < imageListFood.Images.Count)
            {
                pictureBoxFood.Image = imageListFood.Images[index];
                labelPriceFood.Text = "RM " + foodPrices[checkedListBoxFood.SelectedItem.ToString()].ToString("0.00");
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBoxDessert_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = checkedListBoxDessert.SelectedIndex;
            if (index >= 0 && index < imageListDessert.Images.Count)
            {
                pictureBoxDessert.Image = imageListDessert.Images[index];
                labelPriceDessert.Text = "RM " + dessertPrices[checkedListBoxDessert.SelectedItem.ToString()].ToString("0.00");
            }
        }

        private void btnAddDessert_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBoxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBoxDrink.SelectedIndex;
            if (index >= 0 && index < imageListDrink.Images.Count)
            {
                pictureBoxDrink.Image = imageListDrink.Images[index];
                labelPriceDrink.Text = "RM " + drinkPrices[checkedListBoxDrink.SelectedItem.ToString()].ToString("0.00");
            }
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemFood_Click(object sender, EventArgs e)
        {
            if (listFood.SelectedIndex != -1)
            {
                listFood.Items.RemoveAt(listFood.SelectedIndex);
            }
        }

        private void btnRemDrink_Click(object sender, EventArgs e)
        {
            if (listDrink.SelectedIndex != -1)
            {
                listDrink.Items.RemoveAt(listDrink.SelectedIndex);
            }
        }

        private void btnAddDessert_Click_1(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxDessert.CheckedItems)
            {
                ListDessert.Items.Add(item);
            }
        }

        private void btnAddDrink_Click_1(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxDrink.CheckedItems)
            {
                listDrink.Items.Add(item);
            }

        }

        private void labelPriceFood_Click(object sender, EventArgs e)
        {

        }
    }
}
