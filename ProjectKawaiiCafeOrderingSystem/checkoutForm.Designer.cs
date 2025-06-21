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
            this.listItem = new System.Windows.Forms.ListBox();
            this.labelkawaii = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxCardNum = new System.Windows.Forms.TextBox();
            this.labelCardNum = new System.Windows.Forms.Label();
            this.labelCVV = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDisPercen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonDebit = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listItem
            // 
            this.listItem.FormattingEnabled = true;
            this.listItem.ItemHeight = 16;
            this.listItem.Location = new System.Drawing.Point(3, 65);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(444, 340);
            this.listItem.TabIndex = 0;
            this.listItem.SelectedIndexChanged += new System.EventHandler(this.listItem_SelectedIndexChanged);
            // 
            // labelkawaii
            // 
            this.labelkawaii.AutoSize = true;
            this.labelkawaii.BackColor = System.Drawing.Color.White;
            this.labelkawaii.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkawaii.Location = new System.Drawing.Point(-6, 9);
            this.labelkawaii.Name = "labelkawaii";
            this.labelkawaii.Size = new System.Drawing.Size(316, 53);
            this.labelkawaii.TabIndex = 1;
            this.labelkawaii.Text = "Kawaii CheckOut";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(3, 420);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 31);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(635, 324);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 40);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(753, 324);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(93, 40);
            this.buttonPay.TabIndex = 4;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(806, 448);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(113, 38);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Visible = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(635, 276);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(211, 22);
            this.textBoxCVV.TabIndex = 6;
            this.textBoxCVV.TextChanged += new System.EventHandler(this.textBoxCVV_TextChanged);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(635, 228);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(211, 22);
            this.textBoxAmount.TabIndex = 7;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // textBoxCardNum
            // 
            this.textBoxCardNum.Location = new System.Drawing.Point(635, 231);
            this.textBoxCardNum.Name = "textBoxCardNum";
            this.textBoxCardNum.Size = new System.Drawing.Size(211, 22);
            this.textBoxCardNum.TabIndex = 8;
            this.textBoxCardNum.TextChanged += new System.EventHandler(this.textBoxCardNum_TextChanged);
            // 
            // labelCardNum
            // 
            this.labelCardNum.AutoSize = true;
            this.labelCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNum.Location = new System.Drawing.Point(484, 228);
            this.labelCardNum.Name = "labelCardNum";
            this.labelCardNum.Size = new System.Drawing.Size(140, 25);
            this.labelCardNum.TabIndex = 9;
            this.labelCardNum.Text = "Card Number :";
            this.labelCardNum.Click += new System.EventHandler(this.labelCardNum_Click);
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCVV.Location = new System.Drawing.Point(558, 273);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(66, 25);
            this.labelCVV.TabIndex = 10;
            this.labelCVV.Text = "CVV :";
            this.labelCVV.Click += new System.EventHandler(this.labelCVV_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(533, 228);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(91, 25);
            this.labelAmount.TabIndex = 11;
            this.labelAmount.Text = "Amount :";
            this.labelAmount.Click += new System.EventHandler(this.labelAmount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Membership =";
            // 
            // labelDisPercen
            // 
            this.labelDisPercen.AutoSize = true;
            this.labelDisPercen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisPercen.Location = new System.Drawing.Point(634, 65);
            this.labelDisPercen.Name = "labelDisPercen";
            this.labelDisPercen.Size = new System.Drawing.Size(30, 25);
            this.labelDisPercen.TabIndex = 14;
            this.labelDisPercen.Text = "%";
            this.labelDisPercen.Click += new System.EventHandler(this.labelDisPercen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "RM :";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(634, 113);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(61, 25);
            this.labelTotalPrice.TabIndex = 16;
            this.labelTotalPrice.Text = "00.00";
            this.labelTotalPrice.Click += new System.EventHandler(this.labelTotalPrice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Payment Method :";
            // 
            // radioButtonDebit
            // 
            this.radioButtonDebit.AutoSize = true;
            this.radioButtonDebit.Location = new System.Drawing.Point(635, 171);
            this.radioButtonDebit.Name = "radioButtonDebit";
            this.radioButtonDebit.Size = new System.Drawing.Size(60, 20);
            this.radioButtonDebit.TabIndex = 18;
            this.radioButtonDebit.TabStop = true;
            this.radioButtonDebit.Text = "Debit";
            this.radioButtonDebit.UseVisualStyleBackColor = true;
            this.radioButtonDebit.CheckedChanged += new System.EventHandler(this.radioButtonDebit_CheckedChanged);
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(726, 171);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(59, 20);
            this.radioButtonCash.TabIndex = 19;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash\r\n";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            this.radioButtonCash.CheckedChanged += new System.EventHandler(this.radioButtonCash_CheckedChanged);
            // 
            // checkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectKawaiiCafeOrderingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 587);
            this.Controls.Add(this.radioButtonCash);
            this.Controls.Add(this.radioButtonDebit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDisPercen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelCVV);
            this.Controls.Add(this.labelCardNum);
            this.Controls.Add(this.textBoxCardNum);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelkawaii);
            this.Controls.Add(this.listItem);
            this.Name = "checkoutForm";
            this.Text = "checkoutForm";
            this.Load += new System.EventHandler(this.checkoutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listItem;
        private System.Windows.Forms.Label labelkawaii;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxCardNum;
        private System.Windows.Forms.Label labelCardNum;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDisPercen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonDebit;
        private System.Windows.Forms.RadioButton radioButtonCash;
    }
}