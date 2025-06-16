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
            this.components = new System.ComponentModel.Container();
            this.lblD4 = new System.Windows.Forms.Label();
            this.lblD3 = new System.Windows.Forms.Label();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.lblD2 = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblTelphone = new System.Windows.Forms.Label();
            this.lblCityIndex = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblPaymentMethodValue = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblFinalValue = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lblMembershipValue = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceRMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptDataSet = new ProjectKawaiiCafeOrderingSystem.ReceiptDataSet();
            this.receiptTableAdapter = new ProjectKawaiiCafeOrderingSystem.ReceiptDataSetTableAdapters.ReceiptTableAdapter();
            this.tableAdapterManager = new ProjectKawaiiCafeOrderingSystem.ReceiptDataSetTableAdapters.TableAdapterManager();
            this.gbOrder.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblD4
            // 
            this.lblD4.AutoSize = true;
            this.lblD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD4.Location = new System.Drawing.Point(262, 876);
            this.lblD4.Name = "lblD4";
            this.lblD4.Size = new System.Drawing.Size(318, 18);
            this.lblD4.TabIndex = 91;
            this.lblD4.Text = "..............................................................";
            // 
            // lblD3
            // 
            this.lblD3.AutoSize = true;
            this.lblD3.Location = new System.Drawing.Point(143, 660);
            this.lblD3.Name = "lblD3";
            this.lblD3.Size = new System.Drawing.Size(550, 16);
            this.lblD3.TabIndex = 90;
            this.lblD3.Text = "................................................................................." +
    "................................................................................" +
    "....................";
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.dataGridView1);
            this.gbOrder.Controls.Add(this.lblOrderTitle);
            this.gbOrder.Location = new System.Drawing.Point(93, 377);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(653, 280);
            this.gbOrder.TabIndex = 89;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order Details";
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTitle.Location = new System.Drawing.Point(288, 33);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(69, 26);
            this.lblOrderTitle.TabIndex = 7;
            this.lblOrderTitle.Text = "Order";
            // 
            // lblD2
            // 
            this.lblD2.AutoSize = true;
            this.lblD2.Location = new System.Drawing.Point(143, 342);
            this.lblD2.Name = "lblD2";
            this.lblD2.Size = new System.Drawing.Size(550, 16);
            this.lblD2.TabIndex = 88;
            this.lblD2.Text = "................................................................................." +
    "................................................................................" +
    "....................";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(143, 171);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(550, 16);
            this.lblD.TabIndex = 86;
            this.lblD.Text = "................................................................................." +
    "................................................................................" +
    "....................";
            // 
            // lblTelphone
            // 
            this.lblTelphone.AutoSize = true;
            this.lblTelphone.Location = new System.Drawing.Point(359, 155);
            this.lblTelphone.Name = "lblTelphone";
            this.lblTelphone.Size = new System.Drawing.Size(113, 16);
            this.lblTelphone.TabIndex = 85;
            this.lblTelphone.Text = "Tel : +06-218 3367";
            // 
            // lblCityIndex
            // 
            this.lblCityIndex.AutoSize = true;
            this.lblCityIndex.Location = new System.Drawing.Point(363, 128);
            this.lblCityIndex.Name = "lblCityIndex";
            this.lblCityIndex.Size = new System.Drawing.Size(109, 16);
            this.lblCityIndex.TabIndex = 84;
            this.lblCityIndex.Text = "City Index - 83000";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(224, 97);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(382, 16);
            this.lblAddress.TabIndex = 83;
            this.lblAddress.Text = "MY Johor Darul Ta\'zim Batu Pahat taman batupahat jalan gharu";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(273, 936);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 54);
            this.btnClose.TabIndex = 82;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(315, 894);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(211, 18);
            this.lblThanks.TabIndex = 81;
            this.lblThanks.Text = "Thank You For Your Order!";
            // 
            // lblPaymentMethodValue
            // 
            this.lblPaymentMethodValue.AutoSize = true;
            this.lblPaymentMethodValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethodValue.Location = new System.Drawing.Point(585, 827);
            this.lblPaymentMethodValue.Name = "lblPaymentMethodValue";
            this.lblPaymentMethodValue.Size = new System.Drawing.Size(43, 18);
            this.lblPaymentMethodValue.TabIndex = 80;
            this.lblPaymentMethodValue.Text = "Cash";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(207, 827);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(124, 18);
            this.lblPaymentMethod.TabIndex = 79;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblFinalValue
            // 
            this.lblFinalValue.AutoSize = true;
            this.lblFinalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalValue.Location = new System.Drawing.Point(566, 795);
            this.lblFinalValue.Name = "lblFinalValue";
            this.lblFinalValue.Size = new System.Drawing.Size(72, 18);
            this.lblFinalValue.TabIndex = 78;
            this.lblFinalValue.Text = "RM 40.50";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.Location = new System.Drawing.Point(207, 795);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(81, 18);
            this.lblFinalPrice.TabIndex = 77;
            this.lblFinalPrice.Text = "Final Price:";
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.AutoSize = true;
            this.lblDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountValue.Location = new System.Drawing.Point(590, 755);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(37, 18);
            this.lblDiscountValue.TabIndex = 76;
            this.lblDiscountValue.Text = "10%";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(207, 755);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(71, 18);
            this.lblDiscount.TabIndex = 75;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(545, 712);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(112, 25);
            this.lblTotalValue.TabIndex = 74;
            this.lblTotalValue.Text = "RM 45.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(204, 705);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 32);
            this.lblTotal.TabIndex = 73;
            this.lblTotal.Text = "Total:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(255, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 50);
            this.lblTitle.TabIndex = 72;
            this.lblTitle.Text = "Kawaii Cafe Ordering";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lblMembershipValue);
            this.gbCustomer.Controls.Add(this.lblMembership);
            this.gbCustomer.Controls.Add(this.lblNameValue);
            this.gbCustomer.Controls.Add(this.lblName);
            this.gbCustomer.Location = new System.Drawing.Point(173, 207);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(484, 122);
            this.gbCustomer.TabIndex = 87;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer Details";
            // 
            // lblMembershipValue
            // 
            this.lblMembershipValue.AutoSize = true;
            this.lblMembershipValue.Location = new System.Drawing.Point(273, 82);
            this.lblMembershipValue.Name = "lblMembershipValue";
            this.lblMembershipValue.Size = new System.Drawing.Size(63, 16);
            this.lblMembershipValue.TabIndex = 6;
            this.lblMembershipValue.Text = "12345678";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Location = new System.Drawing.Point(126, 82);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(85, 16);
            this.lblMembership.TabIndex = 5;
            this.lblMembership.Text = "Membership:";
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(126, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(425, 936);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(111, 54);
            this.btnExportPDF.TabIndex = 92;
            this.btnExportPDF.Text = "Export to PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceRMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receiptBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 150);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceRMDataGridViewTextBoxColumn
            // 
            this.priceRMDataGridViewTextBoxColumn.DataPropertyName = "Price(RM)";
            this.priceRMDataGridViewTextBoxColumn.HeaderText = "Price(RM)";
            this.priceRMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceRMDataGridViewTextBoxColumn.Name = "priceRMDataGridViewTextBoxColumn";
            this.priceRMDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.receiptDataSet;
            // 
            // receiptDataSet
            // 
            this.receiptDataSet.DataSetName = "ReceiptDataSet";
            this.receiptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ReceiptTableAdapter = this.receiptTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjectKawaiiCafeOrderingSystem.ReceiptDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // receiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 938);
            this.Controls.Add(this.btnExportPDF);
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
            this.Controls.Add(this.lblPaymentMethodValue);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblFinalValue);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.lblDiscountValue);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "receiptForm";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.receiptForm_Load);
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblD4;
        private System.Windows.Forms.Label lblD3;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Label lblD2;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblTelphone;
        private System.Windows.Forms.Label lblCityIndex;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblPaymentMethodValue;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblFinalValue;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label lblMembershipValue;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReceiptDataSet receiptDataSet;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private ReceiptDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private ReceiptDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceRMDataGridViewTextBoxColumn;
    }
}