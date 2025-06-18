namespace ProjectKawaiiCafeOrderingSystem
{
    partial class checkoutForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelcheckout = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelSummary = new System.Windows.Forms.Label(); // ADD THIS
            this.labelcardnum = new System.Windows.Forms.Label();
            this.textBoxCardNum = new System.Windows.Forms.TextBox();
            this.labelCVV = new System.Windows.Forms.Label();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioDebit = new System.Windows.Forms.RadioButton();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelcheckout
            this.labelcheckout.AutoSize = true;
            this.labelcheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelcheckout.Location = new System.Drawing.Point(30, 20);
            this.labelcheckout.Name = "labelcheckout";
            this.labelcheckout.Size = new System.Drawing.Size(200, 31);
            this.labelcheckout.Text = "Checkout Page";

            // listBox1
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(30, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 180);

            // labelSummary (ADDED)
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSummary.Location = new System.Drawing.Point(30, 270);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(0, 20);
            this.labelSummary.Text = "";

            // radioCash
            this.radioCash.AutoSize = true;
            this.radioCash.Location = new System.Drawing.Point(30, 310);
            this.radioCash.Name = "radioCash";
            this.radioCash.Text = "Cash";

            // radioDebit
            this.radioDebit.AutoSize = true;
            this.radioDebit.Location = new System.Drawing.Point(100, 310);
            this.radioDebit.Name = "radioDebit";
            this.radioDebit.Text = "Debit";

            // labelcardnum
            this.labelcardnum.AutoSize = true;
            this.labelcardnum.Location = new System.Drawing.Point(30, 350);
            this.labelcardnum.Name = "labelcardnum";
            this.labelcardnum.Text = "Card Number:";

            // textBoxCardNum
            this.textBoxCardNum.Location = new System.Drawing.Point(150, 350);
            this.textBoxCardNum.Name = "textBoxCardNum";
            this.textBoxCardNum.Size = new System.Drawing.Size(200, 22);

            // labelCVV
            this.labelCVV.AutoSize = true;
            this.labelCVV.Location = new System.Drawing.Point(30, 380);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Text = "CVV:";

            // textBoxCVV
            this.textBoxCVV.Location = new System.Drawing.Point(150, 380);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(60, 22);

            // labelAmount
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(30, 410);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Text = "Amount:";

            // textBoxAmount
            this.textBoxAmount.Location = new System.Drawing.Point(150, 410);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 22);

            // buttonCheckout
            this.buttonCheckout.Location = new System.Drawing.Point(300, 450);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Text = "Pay Now";
            this.buttonCheckout.Size = new System.Drawing.Size(100, 40);

            // checkoutForm
            this.ClientSize = new System.Drawing.Size(500, 520);
            this.Controls.Add(this.labelcheckout);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelSummary); // ADD THIS
            this.Controls.Add(this.radioCash);
            this.Controls.Add(this.radioDebit);
            this.Controls.Add(this.labelcardnum);
            this.Controls.Add(this.textBoxCardNum);
            this.Controls.Add(this.labelCVV);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonCheckout);
            this.Name = "checkoutForm";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelcheckout;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelSummary; // ADD THIS
        private System.Windows.Forms.Label labelcardnum;
        private System.Windows.Forms.TextBox textBoxCardNum;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.RadioButton radioDebit;
        private System.Windows.Forms.Button buttonCheckout;
    }
}
