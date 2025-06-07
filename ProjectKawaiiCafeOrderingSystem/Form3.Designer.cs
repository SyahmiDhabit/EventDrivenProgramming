namespace ProjectKawaiiCafeOrderingSystem
{
    partial class checkoutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelcheckout = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelMembership = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioDebit = new System.Windows.Forms.RadioButton();
            this.radioQR = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelRM = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelcheckout
            // 
            this.labelcheckout.AutoSize = true;
            this.labelcheckout.BackColor = System.Drawing.Color.Transparent;
            this.labelcheckout.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcheckout.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelcheckout.Location = new System.Drawing.Point(12, 9);
            this.labelcheckout.Name = "labelcheckout";
            this.labelcheckout.Size = new System.Drawing.Size(423, 72);
            this.labelcheckout.TabIndex = 9;
            this.labelcheckout.Text = "Kawaii CheckOut\r\n";
            this.labelcheckout.Click += new System.EventHandler(this.labelcheckout_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 292);
            this.listBox1.TabIndex = 10;
            // 
            // labelMembership
            // 
            this.labelMembership.AutoSize = true;
            this.labelMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembership.Location = new System.Drawing.Point(417, 110);
            this.labelMembership.Name = "labelMembership";
            this.labelMembership.Size = new System.Drawing.Size(200, 32);
            this.labelMembership.TabIndex = 11;
            this.labelMembership.Text = "Membership = ";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(627, 110);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(125, 32);
            this.labelDiscount.TabIndex = 12;
            this.labelDiscount.Text = "Discount";
            this.labelDiscount.Click += new System.EventHandler(this.labelDiscount_Click);
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentage.Location = new System.Drawing.Point(777, 110);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(39, 32);
            this.labelPercentage.TabIndex = 13;
            this.labelPercentage.Text = "%";
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentMethod.Location = new System.Drawing.Point(420, 179);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(171, 25);
            this.labelPaymentMethod.TabIndex = 14;
            this.labelPaymentMethod.Text = "Payment Method :";
            this.labelPaymentMethod.Click += new System.EventHandler(this.labelPaymentMethod_Click);
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Location = new System.Drawing.Point(609, 184);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(59, 20);
            this.radioCash.TabIndex = 15;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // radioDebit
            // 
            this.radioDebit.AutoSize = true;
            this.radioDebit.Location = new System.Drawing.Point(692, 184);
            this.radioDebit.Name = "radioDebit";
            this.radioDebit.Size = new System.Drawing.Size(60, 20);
            this.radioDebit.TabIndex = 16;
            this.radioDebit.TabStop = true;
            this.radioDebit.Text = "Debit";
            this.radioDebit.UseVisualStyleBackColor = true;
            // 
            // radioQR
            // 
            this.radioQR.AutoSize = true;
            this.radioQR.Location = new System.Drawing.Point(783, 184);
            this.radioQR.Name = "radioQR";
            this.radioQR.Size = new System.Drawing.Size(48, 20);
            this.radioQR.TabIndex = 17;
            this.radioQR.TabStop = true;
            this.radioQR.Text = "QR";
            this.radioQR.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(423, 355);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(133, 47);
            this.buttonCalculate.TabIndex = 18;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelRM
            // 
            this.labelRM.AutoSize = true;
            this.labelRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRM.Location = new System.Drawing.Point(589, 364);
            this.labelRM.Name = "labelRM";
            this.labelRM.Size = new System.Drawing.Size(42, 25);
            this.labelRM.TabIndex = 19;
            this.labelRM.Text = "RM";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(668, 364);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(0, 25);
            this.labelTotalPrice.TabIndex = 20;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckout.Location = new System.Drawing.Point(1052, 533);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(118, 53);
            this.buttonCheckout.TabIndex = 21;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.Location = new System.Drawing.Point(12, 533);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(118, 53);
            this.buttonPrevious.TabIndex = 22;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // checkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1182, 598);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelRM);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.radioQR);
            this.Controls.Add(this.radioDebit);
            this.Controls.Add(this.radioCash);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelMembership);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelcheckout);
            this.Name = "checkoutForm";
            this.Text = "~ Check Out";
            this.Load += new System.EventHandler(this.checkoutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcheckout;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelMembership;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.RadioButton radioDebit;
        private System.Windows.Forms.RadioButton radioQR;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelRM;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Button buttonPrevious;
    }
}