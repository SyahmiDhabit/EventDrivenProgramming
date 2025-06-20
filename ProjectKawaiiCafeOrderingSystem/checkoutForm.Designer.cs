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
            this.labelSummary = new System.Windows.Forms.Label();
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
            // 
            // labelcheckout
            // 
            this.labelcheckout.AutoSize = true;
            this.labelcheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelcheckout.Location = new System.Drawing.Point(30, 20);
            this.labelcheckout.Name = "labelcheckout";
            this.labelcheckout.Size = new System.Drawing.Size(200, 31);
            this.labelcheckout.TabIndex = 0;
            this.labelcheckout.Text = "Checkout Page";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(30, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 180);
            this.listBox1.TabIndex = 1;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSummary.Location = new System.Drawing.Point(30, 270);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(0, 20);
            this.labelSummary.TabIndex = 2;
            // 
            // labelcardnum
            // 
            this.labelcardnum.AutoSize = true;
            this.labelcardnum.Location = new System.Drawing.Point(30, 350);
            this.labelcardnum.Name = "labelcardnum";
            this.labelcardnum.Size = new System.Drawing.Size(90, 16);
            this.labelcardnum.TabIndex = 5;
            this.labelcardnum.Text = "Card Number:";
            // 
            // textBoxCardNum
            // 
            this.textBoxCardNum.Location = new System.Drawing.Point(150, 350);
            this.textBoxCardNum.Name = "textBoxCardNum";
            this.textBoxCardNum.Size = new System.Drawing.Size(200, 22);
            this.textBoxCardNum.TabIndex = 6;
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.Location = new System.Drawing.Point(30, 380);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(37, 16);
            this.labelCVV.TabIndex = 7;
            this.labelCVV.Text = "CVV:";
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(150, 380);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(60, 22);
            this.textBoxCVV.TabIndex = 8;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(30, 410);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(55, 16);
            this.labelAmount.TabIndex = 9;
            this.labelAmount.Text = "Amount:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(150, 410);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmount.TabIndex = 10;
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Location = new System.Drawing.Point(30, 310);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(59, 20);
            this.radioCash.TabIndex = 3;
            this.radioCash.Text = "Cash";
            // 
            // radioDebit
            // 
            this.radioDebit.AutoSize = true;
            this.radioDebit.Location = new System.Drawing.Point(100, 310);
            this.radioDebit.Name = "radioDebit";
            this.radioDebit.Size = new System.Drawing.Size(60, 20);
            this.radioDebit.TabIndex = 4;
            this.radioDebit.Text = "Debit";
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(300, 450);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(100, 40);
            this.buttonCheckout.TabIndex = 11;
            this.buttonCheckout.Text = "Pay Now";
            // 
            // checkoutForm
            // 
            this.ClientSize = new System.Drawing.Size(832, 520);
            this.Controls.Add(this.labelcheckout);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelSummary);
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
