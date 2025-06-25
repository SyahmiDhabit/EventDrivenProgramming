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
            this.listBoxOrderItem = new System.Windows.Forms.ListBox();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptDataSet = new ProjectKawaiiCafeOrderingSystem.ReceiptDataSet();
            this.lblD2 = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblTelphone = new System.Windows.Forms.Label();
            this.lblCityIndex = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblPaymentMethodValue = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.receiptTableAdapter = new ProjectKawaiiCafeOrderingSystem.ReceiptDataSetTableAdapters.ReceiptTableAdapter();
            this.tableAdapterManager = new ProjectKawaiiCafeOrderingSystem.ReceiptDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelChangeAmount = new System.Windows.Forms.Label();
            this.labelChangeTitle = new System.Windows.Forms.Label();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataSet)).BeginInit();
            this.gbCustomer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblD4
            // 
            this.lblD4.AutoSize = true;
            this.lblD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD4.Location = new System.Drawing.Point(272, 787);
            this.lblD4.Name = "lblD4";
            this.lblD4.Size = new System.Drawing.Size(318, 18);
            this.lblD4.TabIndex = 91;
            this.lblD4.Text = "..............................................................";
            // 
            // lblD3
            // 
            this.lblD3.AutoSize = true;
            this.lblD3.Location = new System.Drawing.Point(148, 608);
            this.lblD3.Name = "lblD3";
            this.lblD3.Size = new System.Drawing.Size(550, 16);
            this.lblD3.TabIndex = 90;
            this.lblD3.Text = "................................................................................." +
    "................................................................................" +
    "....................";
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.listBoxOrderItem);
            this.gbOrder.Controls.Add(this.lblOrderTitle);
            this.gbOrder.Location = new System.Drawing.Point(94, 360);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(659, 235);
            this.gbOrder.TabIndex = 89;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order Details";
            // 
            // listBoxOrderItem
            // 
            this.listBoxOrderItem.FormattingEnabled = true;
            this.listBoxOrderItem.ItemHeight = 16;
            this.listBoxOrderItem.Location = new System.Drawing.Point(34, 69);
            this.listBoxOrderItem.Name = "listBoxOrderItem";
            this.listBoxOrderItem.Size = new System.Drawing.Size(597, 132);
            this.listBoxOrderItem.TabIndex = 8;
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTitle.Location = new System.Drawing.Point(298, 27);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(69, 26);
            this.lblOrderTitle.TabIndex = 7;
            this.lblOrderTitle.Text = "Order";
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
            // lblD2
            // 
            this.lblD2.AutoSize = true;
            this.lblD2.Location = new System.Drawing.Point(125, 313);
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
            this.lblD.Location = new System.Drawing.Point(125, 156);
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
            this.lblTelphone.Location = new System.Drawing.Point(352, 140);
            this.lblTelphone.Name = "lblTelphone";
            this.lblTelphone.Size = new System.Drawing.Size(113, 16);
            this.lblTelphone.TabIndex = 85;
            this.lblTelphone.Text = "Tel : +06-218 3367";
            // 
            // lblCityIndex
            // 
            this.lblCityIndex.AutoSize = true;
            this.lblCityIndex.Location = new System.Drawing.Point(352, 113);
            this.lblCityIndex.Name = "lblCityIndex";
            this.lblCityIndex.Size = new System.Drawing.Size(109, 16);
            this.lblCityIndex.TabIndex = 84;
            this.lblCityIndex.Text = "City Index - 83000";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(224, 82);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(382, 16);
            this.lblAddress.TabIndex = 83;
            this.lblAddress.Text = "MY Johor Darul Ta\'zim Batu Pahat taman batupahat jalan gharu";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(296, 861);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 54);
            this.btnClose.TabIndex = 82;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(326, 816);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(211, 18);
            this.lblThanks.TabIndex = 81;
            this.lblThanks.Text = "Thank You For Your Order!";
            // 
            // lblPaymentMethodValue
            // 
            this.lblPaymentMethodValue.AutoSize = true;
            this.lblPaymentMethodValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethodValue.Location = new System.Drawing.Point(585, 699);
            this.lblPaymentMethodValue.Name = "lblPaymentMethodValue";
            this.lblPaymentMethodValue.Size = new System.Drawing.Size(43, 18);
            this.lblPaymentMethodValue.TabIndex = 80;
            this.lblPaymentMethodValue.Text = "Cash";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(184, 699);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(124, 18);
            this.lblPaymentMethod.TabIndex = 79;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(550, 650);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(112, 25);
            this.lblTotalValue.TabIndex = 74;
            this.lblTotalValue.Text = "RM 45.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(205, 645);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 32);
            this.lblTotal.TabIndex = 73;
            this.lblTotal.Text = "Total:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(256, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 50);
            this.lblTitle.TabIndex = 72;
            this.lblTitle.Text = "Kawaii Cafe Ordering";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lblNameValue);
            this.gbCustomer.Controls.Add(this.lblName);
            this.gbCustomer.Location = new System.Drawing.Point(155, 192);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(489, 101);
            this.gbCustomer.TabIndex = 87;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer Details";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Location = new System.Drawing.Point(291, 47);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(36, 16);
            this.lblNameValue.TabIndex = 4;
            this.lblNameValue.Text = "John";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(98, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(449, 861);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(111, 54);
            this.btnExportPDF.TabIndex = 92;
            this.btnExportPDF.Text = "Export to PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelChangeAmount);
            this.panel1.Controls.Add(this.labelChangeTitle);
            this.panel1.Controls.Add(this.lblD4);
            this.panel1.Controls.Add(this.lblD3);
            this.panel1.Controls.Add(this.btnExportPDF);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblThanks);
            this.panel1.Controls.Add(this.lblPaymentMethod);
            this.panel1.Controls.Add(this.lblPaymentMethodValue);
            this.panel1.Controls.Add(this.lblTotalValue);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.gbOrder);
            this.panel1.Controls.Add(this.lblD2);
            this.panel1.Controls.Add(this.lblD);
            this.panel1.Controls.Add(this.lblTelphone);
            this.panel1.Controls.Add(this.lblCityIndex);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.gbCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 953);
            this.panel1.TabIndex = 93;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelChangeAmount
            // 
            this.labelChangeAmount.AutoSize = true;
            this.labelChangeAmount.Location = new System.Drawing.Point(585, 746);
            this.labelChangeAmount.Name = "labelChangeAmount";
            this.labelChangeAmount.Size = new System.Drawing.Size(55, 16);
            this.labelChangeAmount.TabIndex = 94;
            this.labelChangeAmount.Text = "RM 0.00";
            // 
            // labelChangeTitle
            // 
            this.labelChangeTitle.AutoSize = true;
            this.labelChangeTitle.Location = new System.Drawing.Point(208, 746);
            this.labelChangeTitle.Name = "labelChangeTitle";
            this.labelChangeTitle.Size = new System.Drawing.Size(57, 16);
            this.labelChangeTitle.TabIndex = 93;
            this.labelChangeTitle.Text = "Change:";
            // 
            // receiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(836, 953);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "receiptForm";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.receiptForm_Load);
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataSet)).EndInit();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExportPDF;
        private ReceiptDataSet receiptDataSet;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private ReceiptDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private ReceiptDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxOrderItem;
        private System.Windows.Forms.Label labelChangeAmount;
        private System.Windows.Forms.Label labelChangeTitle;
    }
}