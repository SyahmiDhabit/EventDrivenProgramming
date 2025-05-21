namespace ProjectKawaiiCafeOrderingSystem
{
    partial class receiptForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblTableValue = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.lblFinalValue = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblPaymentValue = new System.Windows.Forms.Label();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lstReceiptItems = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCityIndex = new System.Windows.Forms.Label();
            this.lblTelphone = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lblD2 = new System.Windows.Forms.Label();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.lblD3 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOrdername = new System.Windows.Forms.Label();
            this.lblD4 = new System.Windows.Forms.Label();
            this.gbCustomer.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(363, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kawaii Cafe Ordering";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(126, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Location = new System.Drawing.Point(290, 42);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(36, 16);
            this.lblNameValue.TabIndex = 4;
            this.lblNameValue.Text = "John";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(126, 82);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(67, 16);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Table No:";
            // 
            // lblTableValue
            // 
            this.lblTableValue.AutoSize = true;
            this.lblTableValue.Location = new System.Drawing.Point(273, 82);
            this.lblTableValue.Name = "lblTableValue";
            this.lblTableValue.Size = new System.Drawing.Size(53, 16);
            this.lblTableValue.TabIndex = 6;
            this.lblTableValue.Text = "Table 5";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(210, 18);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(69, 26);
            this.lblOrder.TabIndex = 7;
            this.lblOrder.Text = "Order";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(312, 688);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 32);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(653, 695);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(112, 25);
            this.lblTotalValue.TabIndex = 9;
            this.lblTotalValue.Text = "RM 45.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(315, 738);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(71, 18);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.AutoSize = true;
            this.lblDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountValue.Location = new System.Drawing.Point(698, 738);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(37, 18);
            this.lblDiscountValue.TabIndex = 11;
            this.lblDiscountValue.Text = "10%";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.Location = new System.Drawing.Point(315, 778);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(81, 18);
            this.lblFinalPrice.TabIndex = 12;
            this.lblFinalPrice.Text = "Final Price:";
            // 
            // lblFinalValue
            // 
            this.lblFinalValue.AutoSize = true;
            this.lblFinalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalValue.Location = new System.Drawing.Point(674, 778);
            this.lblFinalValue.Name = "lblFinalValue";
            this.lblFinalValue.Size = new System.Drawing.Size(72, 18);
            this.lblFinalValue.TabIndex = 13;
            this.lblFinalValue.Text = "RM 40.50";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(315, 810);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(124, 18);
            this.lblPayment.TabIndex = 14;
            this.lblPayment.Text = "Payment Method:";
            // 
            // lblPaymentValue
            // 
            this.lblPaymentValue.AutoSize = true;
            this.lblPaymentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentValue.Location = new System.Drawing.Point(693, 810);
            this.lblPaymentValue.Name = "lblPaymentValue";
            this.lblPaymentValue.Size = new System.Drawing.Size(43, 18);
            this.lblPaymentValue.TabIndex = 15;
            this.lblPaymentValue.Text = "Cash";
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(423, 877);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(211, 18);
            this.lblThanks.TabIndex = 16;
            this.lblThanks.Text = "Thank You For Your Order!";
            this.lblThanks.Click += new System.EventHandler(this.lblThanks_Click);
            // 
            // lstReceiptItems
            // 
            this.lstReceiptItems.FormattingEnabled = true;
            this.lstReceiptItems.ItemHeight = 16;
            this.lstReceiptItems.Items.AddRange(new object[] {
            "Chicken Lasagna                                                                  " +
                "1                          15",
            "ButterMilk Chicken Nyummy                                              1         " +
                "                 20",
            "Chocolate Moist Cake                                                         1   " +
                "                       12",
            "Matcha Burnt Cheese Cake                                               1         " +
                "                 18",
            "Tiramisu                                                                         " +
                "           1                          15",
            "Australian Chocolate                                                            1" +
                "                          17",
            "Ice Spanish Latte                                                                " +
                "   1                          18"});
            this.lstReceiptItems.Location = new System.Drawing.Point(34, 112);
            this.lstReceiptItems.Name = "lstReceiptItems";
            this.lstReceiptItems.Size = new System.Drawing.Size(418, 132);
            this.lstReceiptItems.TabIndex = 20;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(474, 920);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 54);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(332, 80);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(382, 16);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "MY Johor Darul Ta\'zim Batu Pahat taman batupahat jalan gharu";
            // 
            // lblCityIndex
            // 
            this.lblCityIndex.AutoSize = true;
            this.lblCityIndex.Location = new System.Drawing.Point(471, 111);
            this.lblCityIndex.Name = "lblCityIndex";
            this.lblCityIndex.Size = new System.Drawing.Size(109, 16);
            this.lblCityIndex.TabIndex = 23;
            this.lblCityIndex.Text = "City Index - 83000";
            // 
            // lblTelphone
            // 
            this.lblTelphone.AutoSize = true;
            this.lblTelphone.Location = new System.Drawing.Point(467, 138);
            this.lblTelphone.Name = "lblTelphone";
            this.lblTelphone.Size = new System.Drawing.Size(113, 16);
            this.lblTelphone.TabIndex = 24;
            this.lblTelphone.Text = "Tel : +06-218 3367";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(251, 154);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(550, 16);
            this.lblD.TabIndex = 25;
            this.lblD.Text = "................................................................................." +
    "................................................................................" +
    "....................";
            this.lblD.Click += new System.EventHandler(this.lblD_Click);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lblTableValue);
            this.gbCustomer.Controls.Add(this.lblTable);
            this.gbCustomer.Controls.Add(this.lblNameValue);
            this.gbCustomer.Controls.Add(this.lblName);
            this.gbCustomer.Location = new System.Drawing.Point(281, 190);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(484, 122);
            this.gbCustomer.TabIndex = 27;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer Details";
            // 
            // lblD2
            // 
            this.lblD2.AutoSize = true;
            this.lblD2.Location = new System.Drawing.Point(251, 325);
            this.lblD2.Name = "lblD2";
            this.lblD2.Size = new System.Drawing.Size(550, 16);
            this.lblD2.TabIndex = 28;
            this.lblD2.Text = "................................................................................." +
    "................................................................................" +
    "....................";
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.lblOrdername);
            this.gbOrder.Controls.Add(this.lblQty);
            this.gbOrder.Controls.Add(this.lblPrice);
            this.gbOrder.Controls.Add(this.lblOrder);
            this.gbOrder.Controls.Add(this.lstReceiptItems);
            this.gbOrder.Location = new System.Drawing.Point(284, 360);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(481, 263);
            this.gbOrder.TabIndex = 29;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order Details";
            // 
            // lblD3
            // 
            this.lblD3.AutoSize = true;
            this.lblD3.Location = new System.Drawing.Point(251, 643);
            this.lblD3.Name = "lblD3";
            this.lblD3.Size = new System.Drawing.Size(550, 16);
            this.lblD3.TabIndex = 30;
            this.lblD3.Text = "................................................................................." +
    "................................................................................" +
    "....................";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(329, 74);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(31, 18);
            this.lblQty.TabIndex = 32;
            this.lblQty.Text = "Qty";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(414, 74);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 18);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Price";
            // 
            // lblOrdername
            // 
            this.lblOrdername.AutoSize = true;
            this.lblOrdername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdername.Location = new System.Drawing.Point(31, 74);
            this.lblOrdername.Name = "lblOrdername";
            this.lblOrdername.Size = new System.Drawing.Size(48, 18);
            this.lblOrdername.TabIndex = 31;
            this.lblOrdername.Text = "Name";
            // 
            // lblD4
            // 
            this.lblD4.AutoSize = true;
            this.lblD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD4.Location = new System.Drawing.Point(370, 859);
            this.lblD4.Name = "lblD4";
            this.lblD4.Size = new System.Drawing.Size(318, 18);
            this.lblD4.TabIndex = 31;
            this.lblD4.Text = "..............................................................";
            // 
            // receiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 1025);
            this.Controls.Add(this.lblD4);
            this.Controls.Add(this.lblD3);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.lblD2);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblTelphone);
            this.Controls.Add(this.lblCityIndex);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.lblPaymentValue);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblFinalValue);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.lblDiscountValue);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbCustomer);
            this.Name = "receiptForm";
            this.Text = "~ Receipt Form";
            this.Load += new System.EventHandler(this.receiptForm_Load);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblTableValue;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label lblFinalValue;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblPaymentValue;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.ListBox lstReceiptItems;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCityIndex;
        private System.Windows.Forms.Label lblTelphone;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label lblD2;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Label lblD3;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblOrdername;
        private System.Windows.Forms.Label lblD4;
    }
}