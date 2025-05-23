﻿namespace ProjectKawaiiCafeOrderingSystem
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
            this.listFoodDesert = new System.Windows.Forms.ListBox();
            this.labelMembership = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioDebit = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelRM = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelCardNum = new System.Windows.Forms.Label();
            this.textBoxCardNum = new System.Windows.Forms.TextBox();
            this.labelCVV = new System.Windows.Forms.Label();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelcheckout
            // 
            this.labelcheckout.AutoSize = true;
            this.labelcheckout.BackColor = System.Drawing.Color.Transparent;
            this.labelcheckout.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcheckout.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelcheckout.Location = new System.Drawing.Point(106, 9);
            this.labelcheckout.Name = "labelcheckout";
            this.labelcheckout.Size = new System.Drawing.Size(423, 72);
            this.labelcheckout.TabIndex = 9;
            this.labelcheckout.Text = "Kawaii CheckOut\r\n";
            this.labelcheckout.Click += new System.EventHandler(this.labelcheckout_Click);
            // 
            // listFoodDesert
            // 
            this.listFoodDesert.FormattingEnabled = true;
            this.listFoodDesert.ItemHeight = 16;
            this.listFoodDesert.Location = new System.Drawing.Point(12, 110);
            this.listFoodDesert.Name = "listFoodDesert";
            this.listFoodDesert.Size = new System.Drawing.Size(517, 388);
            this.listFoodDesert.TabIndex = 10;
            // 
            // labelMembership
            // 
            this.labelMembership.AutoSize = true;
            this.labelMembership.BackColor = System.Drawing.Color.Transparent;
            this.labelMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembership.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMembership.Location = new System.Drawing.Point(552, 111);
            this.labelMembership.Name = "labelMembership";
            this.labelMembership.Size = new System.Drawing.Size(200, 32);
            this.labelMembership.TabIndex = 11;
            this.labelMembership.Text = "Membership = ";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDiscount.Location = new System.Drawing.Point(762, 111);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(125, 32);
            this.labelDiscount.TabIndex = 12;
            this.labelDiscount.Text = "Discount";
            this.labelDiscount.Click += new System.EventHandler(this.labelDiscount_Click);
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.BackColor = System.Drawing.Color.Transparent;
            this.labelPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPercentage.Location = new System.Drawing.Point(912, 111);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(39, 32);
            this.labelPercentage.TabIndex = 13;
            this.labelPercentage.Text = "%";
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.labelPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentMethod.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPaymentMethod.Location = new System.Drawing.Point(553, 231);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(171, 25);
            this.labelPaymentMethod.TabIndex = 14;
            this.labelPaymentMethod.Text = "Payment Method :";
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.BackColor = System.Drawing.Color.Transparent;
            this.radioCash.Location = new System.Drawing.Point(742, 236);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(59, 20);
            this.radioCash.TabIndex = 15;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash";
            this.radioCash.UseVisualStyleBackColor = false;
            // 
            // radioDebit
            // 
            this.radioDebit.AutoSize = true;
            this.radioDebit.BackColor = System.Drawing.Color.Transparent;
            this.radioDebit.Location = new System.Drawing.Point(825, 236);
            this.radioDebit.Name = "radioDebit";
            this.radioDebit.Size = new System.Drawing.Size(60, 20);
            this.radioDebit.TabIndex = 16;
            this.radioDebit.TabStop = true;
            this.radioDebit.Text = "Debit";
            this.radioDebit.UseVisualStyleBackColor = false;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(558, 165);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(133, 47);
            this.buttonCalculate.TabIndex = 18;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // labelRM
            // 
            this.labelRM.AutoSize = true;
            this.labelRM.BackColor = System.Drawing.Color.Transparent;
            this.labelRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRM.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRM.Location = new System.Drawing.Point(714, 173);
            this.labelRM.Name = "labelRM";
            this.labelRM.Size = new System.Drawing.Size(68, 38);
            this.labelRM.TabIndex = 19;
            this.labelRM.Text = "RM";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTotalPrice.Location = new System.Drawing.Point(803, 177);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(86, 32);
            this.labelTotalPrice.TabIndex = 20;
            this.labelTotalPrice.Text = "00.00";
            // 
            // buttonPay
            // 
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.Location = new System.Drawing.Point(904, 443);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(118, 53);
            this.buttonPay.TabIndex = 21;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(25, 532);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(136, 54);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelCardNum
            // 
            this.labelCardNum.AutoSize = true;
            this.labelCardNum.BackColor = System.Drawing.Color.Transparent;
            this.labelCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNum.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCardNum.Location = new System.Drawing.Point(584, 294);
            this.labelCardNum.Name = "labelCardNum";
            this.labelCardNum.Size = new System.Drawing.Size(140, 25);
            this.labelCardNum.TabIndex = 23;
            this.labelCardNum.Text = "Card Number :";
            this.labelCardNum.Visible = false;
            // 
            // textBoxCardNum
            // 
            this.textBoxCardNum.Location = new System.Drawing.Point(742, 294);
            this.textBoxCardNum.Multiline = true;
            this.textBoxCardNum.Name = "textBoxCardNum";
            this.textBoxCardNum.Size = new System.Drawing.Size(280, 25);
            this.textBoxCardNum.TabIndex = 24;
            this.textBoxCardNum.Visible = false;
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.BackColor = System.Drawing.Color.Transparent;
            this.labelCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCVV.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCVV.Location = new System.Drawing.Point(658, 345);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(66, 25);
            this.labelCVV.TabIndex = 25;
            this.labelCVV.Text = "CVV :";
            this.labelCVV.Visible = false;
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(742, 345);
            this.textBoxCVV.Multiline = true;
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(280, 25);
            this.textBoxCVV.TabIndex = 26;
            this.textBoxCVV.Visible = false;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(742, 392);
            this.textBoxAmount.Multiline = true;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(280, 25);
            this.textBoxAmount.TabIndex = 28;
            this.textBoxAmount.Visible = false;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAmount.Location = new System.Drawing.Point(632, 391);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(96, 25);
            this.labelAmount.TabIndex = 29;
            this.labelAmount.Text = "Amount : ";
            this.labelAmount.Visible = false;
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelOrder.Location = new System.Drawing.Point(742, 443);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(133, 53);
            this.buttonCancelOrder.TabIndex = 30;
            this.buttonCancelOrder.Text = "Cancel";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            // 
            // checkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::ProjectKawaiiCafeOrderingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 598);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.labelCVV);
            this.Controls.Add(this.textBoxCardNum);
            this.Controls.Add(this.labelCardNum);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelRM);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.radioDebit);
            this.Controls.Add(this.radioCash);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelMembership);
            this.Controls.Add(this.listFoodDesert);
            this.Controls.Add(this.labelcheckout);
            this.Name = "checkoutForm";
            this.Text = "~ Check Out";
            this.Load += new System.EventHandler(this.checkoutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcheckout;
        private System.Windows.Forms.ListBox listFoodDesert;
        private System.Windows.Forms.Label labelMembership;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.RadioButton radioDebit;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelRM;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelCardNum;
        private System.Windows.Forms.TextBox textBoxCardNum;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonCancelOrder;
    }
}