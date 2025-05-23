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
            System.Windows.Forms.CheckedListBox checkedListBoxFood;
            this.checkedListBoxDrink = new System.Windows.Forms.CheckedListBox();
            this.ListDessert = new System.Windows.Forms.ListBox();
            this.listDrink = new System.Windows.Forms.ListBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.groupBoxFood = new System.Windows.Forms.GroupBox();
            this.labelPriceFood = new System.Windows.Forms.Label();
            this.labelRMMenu = new System.Windows.Forms.Label();
            this.labelQtyMenu = new System.Windows.Forms.Label();
            this.numericUpDownFood = new System.Windows.Forms.NumericUpDown();
            this.btnRemFood = new System.Windows.Forms.Button();
            this.listFood = new System.Windows.Forms.ListBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.groupBoxDessert = new System.Windows.Forms.GroupBox();
            this.labelPriceDessert = new System.Windows.Forms.Label();
            this.labelRMDessert = new System.Windows.Forms.Label();
            this.labelQtyDessert = new System.Windows.Forms.Label();
            this.numericUpDownDessert = new System.Windows.Forms.NumericUpDown();
            this.btnRemDessert = new System.Windows.Forms.Button();
            this.btnAddDessert = new System.Windows.Forms.Button();
            this.groupBoxDrink = new System.Windows.Forms.GroupBox();
            this.labelPriceDrink = new System.Windows.Forms.Label();
            this.labelRMDrink = new System.Windows.Forms.Label();
            this.labelQtyDrink = new System.Windows.Forms.Label();
            this.btnRemDrink = new System.Windows.Forms.Button();
            this.numericUpDownDrink = new System.Windows.Forms.NumericUpDown();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            checkedListBoxDessert = new System.Windows.Forms.CheckedListBox();
            checkedListBoxFood = new System.Windows.Forms.CheckedListBox();
            this.groupBoxFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFood)).BeginInit();
            this.groupBoxDessert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDessert)).BeginInit();
            this.groupBoxDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxDessert
            // 
            checkedListBoxDessert.FormattingEnabled = true;
            checkedListBoxDessert.Items.AddRange(new object[] {
            "Chocolate Moist Cake ",
            "Matcha Burnt Cheese Cake",
            "Tiramisu",
            "Donut Chocolate",
            "Donut Rich Cheese",
            "Cupcake Cheese",
            "Coconut Pudding",
            "Blueberry Cake",
            "Vanilla Cake",
            "Egg Tart"});
            checkedListBoxDessert.Location = new System.Drawing.Point(23, 31);
            checkedListBoxDessert.Name = "checkedListBoxDessert";
            checkedListBoxDessert.Size = new System.Drawing.Size(241, 106);
            checkedListBoxDessert.TabIndex = 0;
            checkedListBoxDessert.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxDessert_SelectedIndexChanged);
            // 
            // checkedListBoxFood
            // 
            checkedListBoxFood.FormattingEnabled = true;
            checkedListBoxFood.Items.AddRange(new object[] {
            "Chicken Lasagna",
            "Spaghetti Carbonara",
            "Chicken Chop",
            "Tomyam Seafood",
            "Buttermilk Chicken",
            "Spaghettti Aglio Olio",
            "Fish & Chips"});
            checkedListBoxFood.Location = new System.Drawing.Point(23, 32);
            checkedListBoxFood.Name = "checkedListBoxFood";
            checkedListBoxFood.Size = new System.Drawing.Size(241, 106);
            checkedListBoxFood.TabIndex = 22;
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
            "Ice Viatnamese Latte",
            "Ice Mocha",
            "Hazelnut Coffe Ice"});
            this.checkedListBoxDrink.Location = new System.Drawing.Point(23, 31);
            this.checkedListBoxDrink.Name = "checkedListBoxDrink";
            this.checkedListBoxDrink.Size = new System.Drawing.Size(241, 106);
            this.checkedListBoxDrink.TabIndex = 1;
            // 
            // ListDessert
            // 
            this.ListDessert.FormattingEnabled = true;
            this.ListDessert.ItemHeight = 16;
            this.ListDessert.Location = new System.Drawing.Point(444, 368);
            this.ListDessert.Name = "ListDessert";
            this.ListDessert.Size = new System.Drawing.Size(355, 244);
            this.ListDessert.TabIndex = 2;
            // 
            // listDrink
            // 
            this.listDrink.FormattingEnabled = true;
            this.listDrink.ItemHeight = 16;
            this.listDrink.Location = new System.Drawing.Point(444, 636);
            this.listDrink.Name = "listDrink";
            this.listDrink.Size = new System.Drawing.Size(355, 244);
            this.listDrink.TabIndex = 3;
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.LightGray;
            this.btnAddFood.Location = new System.Drawing.Point(226, 190);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(108, 42);
            this.btnAddFood.TabIndex = 20;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // groupBoxFood
            // 
            this.groupBoxFood.AutoSize = true;
            this.groupBoxFood.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxFood.Controls.Add(this.labelPriceFood);
            this.groupBoxFood.Controls.Add(this.labelRMMenu);
            this.groupBoxFood.Controls.Add(this.labelQtyMenu);
            this.groupBoxFood.Controls.Add(this.numericUpDownFood);
            this.groupBoxFood.Controls.Add(checkedListBoxFood);
            this.groupBoxFood.Controls.Add(this.btnRemFood);
            this.groupBoxFood.Controls.Add(this.btnAddFood);
            this.groupBoxFood.Location = new System.Drawing.Point(71, 86);
            this.groupBoxFood.Name = "groupBoxFood";
            this.groupBoxFood.Size = new System.Drawing.Size(355, 253);
            this.groupBoxFood.TabIndex = 21;
            this.groupBoxFood.TabStop = false;
            this.groupBoxFood.Text = "Food Menu";
            this.groupBoxFood.Enter += new System.EventHandler(this.groupBoxFood_Enter);
            // 
            // labelPriceFood
            // 
            this.labelPriceFood.AutoSize = true;
            this.labelPriceFood.Location = new System.Drawing.Point(254, 157);
            this.labelPriceFood.Name = "labelPriceFood";
            this.labelPriceFood.Size = new System.Drawing.Size(38, 16);
            this.labelPriceFood.TabIndex = 31;
            this.labelPriceFood.Text = "00:00";
            // 
            // labelRMMenu
            // 
            this.labelRMMenu.AutoSize = true;
            this.labelRMMenu.Location = new System.Drawing.Point(227, 157);
            this.labelRMMenu.Name = "labelRMMenu";
            this.labelRMMenu.Size = new System.Drawing.Size(34, 16);
            this.labelRMMenu.TabIndex = 30;
            this.labelRMMenu.Text = "RM: ";
            // 
            // labelQtyMenu
            // 
            this.labelQtyMenu.AutoSize = true;
            this.labelQtyMenu.Location = new System.Drawing.Point(20, 153);
            this.labelQtyMenu.Name = "labelQtyMenu";
            this.labelQtyMenu.Size = new System.Drawing.Size(58, 16);
            this.labelQtyMenu.TabIndex = 24;
            this.labelQtyMenu.Text = "Quantity:";
            // 
            // numericUpDownFood
            // 
            this.numericUpDownFood.Location = new System.Drawing.Point(86, 151);
            this.numericUpDownFood.Name = "numericUpDownFood";
            this.numericUpDownFood.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFood.TabIndex = 23;
            // 
            // btnRemFood
            // 
            this.btnRemFood.BackColor = System.Drawing.Color.LightGray;
            this.btnRemFood.Location = new System.Drawing.Point(23, 190);
            this.btnRemFood.Name = "btnRemFood";
            this.btnRemFood.Size = new System.Drawing.Size(108, 42);
            this.btnRemFood.TabIndex = 21;
            this.btnRemFood.Text = "Remove Food";
            this.btnRemFood.UseVisualStyleBackColor = false;
            // 
            // listFood
            // 
            this.listFood.FormattingEnabled = true;
            this.listFood.ItemHeight = 16;
            this.listFood.Location = new System.Drawing.Point(444, 95);
            this.listFood.Name = "listFood";
            this.listFood.Size = new System.Drawing.Size(355, 244);
            this.listFood.TabIndex = 22;
            this.listFood.SelectedIndexChanged += new System.EventHandler(this.listFood_SelectedIndexChanged);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.Transparent;
            this.labelMenu.Font = new System.Drawing.Font("Monotype Corsiva", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Transparent;
            this.labelMenu.Location = new System.Drawing.Point(201, -8);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(453, 82);
            this.labelMenu.TabIndex = 23;
            this.labelMenu.Text = "Enjoy Our Menu";
            // 
            // groupBoxDessert
            // 
            this.groupBoxDessert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxDessert.Controls.Add(this.labelPriceDessert);
            this.groupBoxDessert.Controls.Add(this.labelRMDessert);
            this.groupBoxDessert.Controls.Add(this.labelQtyDessert);
            this.groupBoxDessert.Controls.Add(this.numericUpDownDessert);
            this.groupBoxDessert.Controls.Add(this.btnRemDessert);
            this.groupBoxDessert.Controls.Add(this.btnAddDessert);
            this.groupBoxDessert.Controls.Add(checkedListBoxDessert);
            this.groupBoxDessert.Location = new System.Drawing.Point(71, 358);
            this.groupBoxDessert.Name = "groupBoxDessert";
            this.groupBoxDessert.Size = new System.Drawing.Size(355, 250);
            this.groupBoxDessert.TabIndex = 24;
            this.groupBoxDessert.TabStop = false;
            this.groupBoxDessert.Text = "Menu Dessert";
            // 
            // labelPriceDessert
            // 
            this.labelPriceDessert.AutoSize = true;
            this.labelPriceDessert.Location = new System.Drawing.Point(254, 157);
            this.labelPriceDessert.Name = "labelPriceDessert";
            this.labelPriceDessert.Size = new System.Drawing.Size(38, 16);
            this.labelPriceDessert.TabIndex = 30;
            this.labelPriceDessert.Text = "00:00";
            // 
            // labelRMDessert
            // 
            this.labelRMDessert.AutoSize = true;
            this.labelRMDessert.Location = new System.Drawing.Point(228, 157);
            this.labelRMDessert.Name = "labelRMDessert";
            this.labelRMDessert.Size = new System.Drawing.Size(34, 16);
            this.labelRMDessert.TabIndex = 29;
            this.labelRMDessert.Text = "RM: ";
            // 
            // labelQtyDessert
            // 
            this.labelQtyDessert.AutoSize = true;
            this.labelQtyDessert.Location = new System.Drawing.Point(20, 155);
            this.labelQtyDessert.Name = "labelQtyDessert";
            this.labelQtyDessert.Size = new System.Drawing.Size(58, 16);
            this.labelQtyDessert.TabIndex = 26;
            this.labelQtyDessert.Text = "Quantity:";
            // 
            // numericUpDownDessert
            // 
            this.numericUpDownDessert.Location = new System.Drawing.Point(86, 153);
            this.numericUpDownDessert.Name = "numericUpDownDessert";
            this.numericUpDownDessert.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDessert.TabIndex = 25;
            // 
            // btnRemDessert
            // 
            this.btnRemDessert.BackColor = System.Drawing.Color.LightGray;
            this.btnRemDessert.Location = new System.Drawing.Point(20, 190);
            this.btnRemDessert.Name = "btnRemDessert";
            this.btnRemDessert.Size = new System.Drawing.Size(108, 42);
            this.btnRemDessert.TabIndex = 21;
            this.btnRemDessert.Text = "Remove Dessert";
            this.btnRemDessert.UseVisualStyleBackColor = false;
            this.btnRemDessert.Click += new System.EventHandler(this.btnRemoveDessert_Click);
            // 
            // btnAddDessert
            // 
            this.btnAddDessert.BackColor = System.Drawing.Color.LightGray;
            this.btnAddDessert.Location = new System.Drawing.Point(222, 190);
            this.btnAddDessert.Name = "btnAddDessert";
            this.btnAddDessert.Size = new System.Drawing.Size(108, 42);
            this.btnAddDessert.TabIndex = 20;
            this.btnAddDessert.Text = "Add Dessert";
            this.btnAddDessert.UseVisualStyleBackColor = false;
            // 
            // groupBoxDrink
            // 
            this.groupBoxDrink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxDrink.Controls.Add(this.labelPriceDrink);
            this.groupBoxDrink.Controls.Add(this.labelRMDrink);
            this.groupBoxDrink.Controls.Add(this.labelQtyDrink);
            this.groupBoxDrink.Controls.Add(this.btnRemDrink);
            this.groupBoxDrink.Controls.Add(this.numericUpDownDrink);
            this.groupBoxDrink.Controls.Add(this.btnAddDrink);
            this.groupBoxDrink.Controls.Add(this.checkedListBoxDrink);
            this.groupBoxDrink.Location = new System.Drawing.Point(71, 630);
            this.groupBoxDrink.Name = "groupBoxDrink";
            this.groupBoxDrink.Size = new System.Drawing.Size(355, 250);
            this.groupBoxDrink.TabIndex = 25;
            this.groupBoxDrink.TabStop = false;
            this.groupBoxDrink.Text = "Drink Menu";
            // 
            // labelPriceDrink
            // 
            this.labelPriceDrink.AutoSize = true;
            this.labelPriceDrink.Location = new System.Drawing.Point(254, 156);
            this.labelPriceDrink.Name = "labelPriceDrink";
            this.labelPriceDrink.Size = new System.Drawing.Size(38, 16);
            this.labelPriceDrink.TabIndex = 29;
            this.labelPriceDrink.Text = "00:00";
            // 
            // labelRMDrink
            // 
            this.labelRMDrink.AutoSize = true;
            this.labelRMDrink.Location = new System.Drawing.Point(227, 156);
            this.labelRMDrink.Name = "labelRMDrink";
            this.labelRMDrink.Size = new System.Drawing.Size(34, 16);
            this.labelRMDrink.TabIndex = 28;
            this.labelRMDrink.Text = "RM: ";
            // 
            // labelQtyDrink
            // 
            this.labelQtyDrink.AutoSize = true;
            this.labelQtyDrink.Location = new System.Drawing.Point(20, 156);
            this.labelQtyDrink.Name = "labelQtyDrink";
            this.labelQtyDrink.Size = new System.Drawing.Size(58, 16);
            this.labelQtyDrink.TabIndex = 27;
            this.labelQtyDrink.Text = "Quantity:";
            // 
            // btnRemDrink
            // 
            this.btnRemDrink.BackColor = System.Drawing.Color.LightGray;
            this.btnRemDrink.Location = new System.Drawing.Point(20, 190);
            this.btnRemDrink.Name = "btnRemDrink";
            this.btnRemDrink.Size = new System.Drawing.Size(108, 42);
            this.btnRemDrink.TabIndex = 21;
            this.btnRemDrink.Text = "Remove Drink\r\n";
            this.btnRemDrink.UseVisualStyleBackColor = false;
            // 
            // numericUpDownDrink
            // 
            this.numericUpDownDrink.Location = new System.Drawing.Point(86, 154);
            this.numericUpDownDrink.Name = "numericUpDownDrink";
            this.numericUpDownDrink.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDrink.TabIndex = 26;
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.BackColor = System.Drawing.Color.LightGray;
            this.btnAddDrink.Location = new System.Drawing.Point(222, 190);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(108, 42);
            this.btnAddDrink.TabIndex = 20;
            this.btnAddDrink.Text = "Add Drink";
            this.btnAddDrink.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(708, 903);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 53);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::ProjectKawaiiCafeOrderingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 1055);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBoxDrink);
            this.Controls.Add(this.groupBoxDessert);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.listFood);
            this.Controls.Add(this.groupBoxFood);
            this.Controls.Add(this.listDrink);
            this.Controls.Add(this.ListDessert);
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~ MenuForm";
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.groupBoxFood.ResumeLayout(false);
            this.groupBoxFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFood)).EndInit();
            this.groupBoxDessert.ResumeLayout(false);
            this.groupBoxDessert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDessert)).EndInit();
            this.groupBoxDrink.ResumeLayout(false);
            this.groupBoxDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxDrink;
        private System.Windows.Forms.ListBox ListDessert;
        private System.Windows.Forms.ListBox listDrink;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.GroupBox groupBoxFood;
        private System.Windows.Forms.ListBox listFood;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button btnRemFood;
        private System.Windows.Forms.GroupBox groupBoxDessert;
        private System.Windows.Forms.Button btnRemDessert;
        private System.Windows.Forms.Button btnAddDessert;
        private System.Windows.Forms.GroupBox groupBoxDrink;
        private System.Windows.Forms.Button btnRemDrink;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.Label labelQtyMenu;
        private System.Windows.Forms.NumericUpDown numericUpDownFood;
        private System.Windows.Forms.Label labelQtyDessert;
        private System.Windows.Forms.NumericUpDown numericUpDownDessert;
        private System.Windows.Forms.Label labelQtyDrink;
        private System.Windows.Forms.NumericUpDown numericUpDownDrink;
        private System.Windows.Forms.Label labelRMDrink;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelRMMenu;
        private System.Windows.Forms.Label labelRMDessert;
        private System.Windows.Forms.Label labelPriceDessert;
        private System.Windows.Forms.Label labelPriceDrink;
        private System.Windows.Forms.Label labelPriceFood;
    }
}