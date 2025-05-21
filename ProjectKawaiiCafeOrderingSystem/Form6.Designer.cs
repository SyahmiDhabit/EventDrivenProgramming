namespace ProjectKawaiiCafeOrderingSystem
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_ID,
            this.Order_Date,
            this.Cust_Name,
            this.Total_Price});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(135, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Order_ID
            // 
            this.Order_ID.HeaderText = "Order ID";
            this.Order_ID.Name = "Order_ID";
            // 
            // Order_Date
            // 
            this.Order_Date.HeaderText = "Order Date";
            this.Order_Date.Name = "Order_Date";
            // 
            // Cust_Name
            // 
            this.Cust_Name.HeaderText = "Cust Name";
            this.Cust_Name.Name = "Cust_Name";
            // 
            // Total_Price
            // 
            this.Total_Price.HeaderText = "Total Price";
            this.Total_Price.Name = "Total_Price";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
    }
}