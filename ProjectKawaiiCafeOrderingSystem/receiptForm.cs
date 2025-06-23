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
    public partial class receiptForm : Form
    {

        public receiptForm(int orderID)
        {
            InitializeComponent();
        }


        private void receiptForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'receiptDataSet.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.receiptDataSet.Receipt);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
