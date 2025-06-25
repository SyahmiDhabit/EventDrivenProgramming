using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ProjectKawaiiCafeOrderingSystem
{

    public partial class receiptForm : Form
    {
        public string CustomerName { get; set; }
        public string PaymentMethod { get; set; }
        public decimal FinalPrice { get; set; }

        public decimal ChangeAmount { get; set; }


        public receiptForm()
        {
            InitializeComponent();
        }

        private void receiptForm_Load(object sender, EventArgs e)
        {
            lblNameValue.Text = CustomerName;
            lblPaymentMethodValue.Text = PaymentMethod;
            lblTotalValue.Text = "RM " + FinalPrice.ToString("F2");
            labelChangeAmount.Text = "RM " + ChangeAmount.ToString("F2");



            listBoxOrderItem.Items.Clear();
            foreach (var item in OrderSession.OrderedItems)
            {
                listBoxOrderItem.Items.Add(item.ToString());
            }
            foreach (var merch in OrderSession.OrderedMerchandise)
            {
                listBoxOrderItem.Items.Add(merch.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm main = new mainForm();
            main.Show();
            this.Close();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnExportPDF_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Receipt As PDF";
                    saveFileDialog.FileName = "KawaiiCafe_Receipt.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        PdfDocument doc = new PdfDocument();
                        doc.Info.Title = "Kawaii Cafe Receipt";
                        PdfPage page = doc.AddPage();
                        XGraphics gfx = XGraphics.FromPdfPage(page);

                        XFont titleFont = new XFont("Arial", 16, XFontStyle.Bold);
                        XFont regularFont = new XFont("Arial", 12, XFontStyle.Regular);
                        XFont boldFont = new XFont("Arial", 12, XFontStyle.Bold);

                        double yPoint = 40;

                        // 🧋 Title
                        gfx.DrawString(lblTitle.Text, titleFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 20), XStringFormats.TopCenter);
                        yPoint += 30;

                        // 🏠 Address Information
                        gfx.DrawString(lblAddress.Text, regularFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 20), XStringFormats.TopCenter);
                        yPoint += 20;
                        gfx.DrawString(lblCityIndex.Text, regularFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 20), XStringFormats.TopCenter);
                        yPoint += 20;
                        gfx.DrawString(lblTelphone.Text, regularFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 20), XStringFormats.TopCenter);
                        yPoint += 30;

                        // 👤 Customer Details
                        gfx.DrawString(lblName.Text + " " + lblNameValue.Text, boldFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 20), XStringFormats.TopCenter);
                        yPoint += 30;

                        // 📦 Ordered Items
                        gfx.DrawString(lblOrderTitle.Text, boldFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 20), XStringFormats.TopCenter);
                        yPoint += 25;

                        foreach (var item in listBoxOrderItem.Items)
                        {
                            gfx.DrawString(item.ToString(), regularFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 20), XStringFormats.TopCenter);
                            yPoint += 20;
                        }

                        yPoint += 20;

                        // 💰 Total, Payment, Change
                        gfx.DrawString(lblTotal.Text + " " + lblTotalValue.Text, boldFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 20), XStringFormats.TopCenter);
                        yPoint += 20;
                        gfx.DrawString(lblPaymentMethod.Text + " " + lblPaymentMethodValue.Text, boldFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 20), XStringFormats.TopCenter);
                        yPoint += 20;
                        gfx.DrawString(labelChangeTitle.Text + " " + labelChangeAmount.Text, boldFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 20), XStringFormats.TopCenter);
                        yPoint += 30;

                        // 🙏 Thank You
                        gfx.DrawString(lblThanks.Text, boldFont, XBrushes.Black, new XRect(0, yPoint, page.Width, 30), XStringFormats.TopCenter);

                        // 💾 Save
                        doc.Save(saveFileDialog.FileName);
                        MessageBox.Show("Receipt exported successfully!", "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
