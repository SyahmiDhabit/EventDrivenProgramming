namespace ProjectKawaiiCafeOrderingSystem
{
    partial class menuForm
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
            System.Windows.Forms.CheckedListBox checkedListBoxDessert;
            this.checkedListBoxDrink = new System.Windows.Forms.CheckedListBox();
            this.ListDessert = new System.Windows.Forms.ListBox();
            this.listDrink = new System.Windows.Forms.ListBox();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            checkedListBoxDessert = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxDessert
            // 
            checkedListBoxDessert.FormattingEnabled = true;
            checkedListBoxDessert.Items.AddRange(new object[] {
            "Chocolate Moist Cake ",
            "Matcha Cake",
            "Tiramisu",
            "Donut Grr Chocolate",
            "Donut Rich Cheese",
            "Cupcake Cheese",
            "Coconut Pudding",
            "Blueberry Dces Cake",
            "Vanilla Strawberi Cake",
            "Egg Tart"});
            checkedListBoxDessert.Location = new System.Drawing.Point(466, 66);
            checkedListBoxDessert.Name = "checkedListBoxDessert";
            checkedListBoxDessert.Size = new System.Drawing.Size(241, 106);
            checkedListBoxDessert.TabIndex = 0;
            // 
            // checkedListBoxDrink
            // 
            this.checkedListBoxDrink.FormattingEnabled = true;
            this.checkedListBoxDrink.Items.AddRange(new object[] {
            "Matcha Latte",
            "Green Tea Kaw Kaw",
            "Thai Tea Kaw Kaw",
            "Australian Chocolate",
            "Ice Spanish Latte",
            "Matcho Latte",
            "Buttercrem`e Latte",
            "Ice Viatnamese Latte"});
            this.checkedListBoxDrink.Location = new System.Drawing.Point(808, 66);
            this.checkedListBoxDrink.Name = "checkedListBoxDrink";
            this.checkedListBoxDrink.Size = new System.Drawing.Size(241, 106);
            this.checkedListBoxDrink.TabIndex = 1;
            // 
            // ListDessert
            // 
            this.ListDessert.FormattingEnabled = true;
            this.ListDessert.ItemHeight = 16;
            this.ListDessert.Location = new System.Drawing.Point(466, 284);
            this.ListDessert.Name = "ListDessert";
            this.ListDessert.Size = new System.Drawing.Size(241, 132);
            this.ListDessert.TabIndex = 2;
            // 
            // listDrink
            // 
            this.listDrink.FormattingEnabled = true;
            this.listDrink.ItemHeight = 16;
            this.listDrink.Location = new System.Drawing.Point(808, 284);
            this.listDrink.Name = "listDrink";
            this.listDrink.Size = new System.Drawing.Size(241, 132);
            this.listDrink.TabIndex = 3;
            // 
            // btnDessert
            // 
            this.btnDessert.Location = new System.Drawing.Point(466, 205);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(120, 55);
            this.btnDessert.TabIndex = 4;
            this.btnDessert.Text = "Get Your Dessert";
            this.btnDessert.UseVisualStyleBackColor = true;
            // 
            // btnDrink
            // 
            this.btnDrink.Location = new System.Drawing.Point(808, 205);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(120, 55);
            this.btnDrink.TabIndex = 5;
            this.btnDrink.Text = "Get Your Drink";
            this.btnDrink.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(1031, 518);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(118, 53);
            this.btnCheckOut.TabIndex = 14;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 598);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.listDrink);
            this.Controls.Add(this.ListDessert);
            this.Controls.Add(this.checkedListBoxDrink);
            this.Controls.Add(checkedListBoxDessert);
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~ MenuForm";
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxDrink;
        private System.Windows.Forms.ListBox ListDessert;
        private System.Windows.Forms.ListBox listDrink;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnCheckOut;
    }
}