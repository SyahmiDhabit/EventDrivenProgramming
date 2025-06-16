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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.checkedListBoxDrink = new System.Windows.Forms.CheckedListBox();
            this.ListDessert = new System.Windows.Forms.ListBox();
            this.listDrink = new System.Windows.Forms.ListBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.groupBoxFood = new System.Windows.Forms.GroupBox();
            this.checkedListBoxFood = new System.Windows.Forms.CheckedListBox();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.labelPriceFood = new System.Windows.Forms.Label();
            this.labelQtyMenu = new System.Windows.Forms.Label();
            this.numericUpDownFood = new System.Windows.Forms.NumericUpDown();
            this.btnRemFood = new System.Windows.Forms.Button();
            this.listFood = new System.Windows.Forms.ListBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.groupBoxDessert = new System.Windows.Forms.GroupBox();
            this.checkedListBoxDessert = new System.Windows.Forms.CheckedListBox();
            this.pictureBoxDessert = new System.Windows.Forms.PictureBox();
            this.labelPriceDessert = new System.Windows.Forms.Label();
            this.labelQtyDessert = new System.Windows.Forms.Label();
            this.numericUpDownDessert = new System.Windows.Forms.NumericUpDown();
            this.btnRemDessert = new System.Windows.Forms.Button();
            this.btnAddDessert = new System.Windows.Forms.Button();
            this.groupBoxDrink = new System.Windows.Forms.GroupBox();
            this.pictureBoxDrink = new System.Windows.Forms.PictureBox();
            this.labelPriceDrink = new System.Windows.Forms.Label();
            this.labelQtyDrink = new System.Windows.Forms.Label();
            this.btnRemDrink = new System.Windows.Forms.Button();
            this.numericUpDownDrink = new System.Windows.Forms.NumericUpDown();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.imageListFood = new System.Windows.Forms.ImageList(this.components);
            this.imageListDessert = new System.Windows.Forms.ImageList(this.components);
            this.imageListDrink = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFood)).BeginInit();
            this.groupBoxDessert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDessert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDessert)).BeginInit();
            this.groupBoxDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxDrink
            // 
            this.checkedListBoxDrink.FormattingEnabled = true;
            this.checkedListBoxDrink.Location = new System.Drawing.Point(23, 31);
            this.checkedListBoxDrink.Name = "checkedListBoxDrink";
            this.checkedListBoxDrink.Size = new System.Drawing.Size(241, 106);
            this.checkedListBoxDrink.TabIndex = 1;
            this.checkedListBoxDrink.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxDrink_SelectedIndexChanged);
            // 
            // ListDessert
            // 
            this.ListDessert.FormattingEnabled = true;
            this.ListDessert.ItemHeight = 16;
            this.ListDessert.Location = new System.Drawing.Point(644, 367);
            this.ListDessert.Name = "ListDessert";
            this.ListDessert.Size = new System.Drawing.Size(355, 244);
            this.ListDessert.TabIndex = 2;
            this.ListDessert.SelectedIndexChanged += new System.EventHandler(this.ListDessert_SelectedIndexChanged);
            // 
            // listDrink
            // 
            this.listDrink.FormattingEnabled = true;
            this.listDrink.ItemHeight = 16;
            this.listDrink.Location = new System.Drawing.Point(644, 630);
            this.listDrink.Name = "listDrink";
            this.listDrink.Size = new System.Drawing.Size(355, 244);
            this.listDrink.TabIndex = 3;
            this.listDrink.SelectedIndexChanged += new System.EventHandler(this.listDrink_SelectedIndexChanged);
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
            this.groupBoxFood.Controls.Add(this.checkedListBoxFood);
            this.groupBoxFood.Controls.Add(this.pictureBoxFood);
            this.groupBoxFood.Controls.Add(this.labelPriceFood);
            this.groupBoxFood.Controls.Add(this.labelQtyMenu);
            this.groupBoxFood.Controls.Add(this.numericUpDownFood);
            this.groupBoxFood.Controls.Add(this.btnRemFood);
            this.groupBoxFood.Controls.Add(this.btnAddFood);
            this.groupBoxFood.Location = new System.Drawing.Point(71, 86);
            this.groupBoxFood.Name = "groupBoxFood";
            this.groupBoxFood.Size = new System.Drawing.Size(551, 253);
            this.groupBoxFood.TabIndex = 21;
            this.groupBoxFood.TabStop = false;
            this.groupBoxFood.Text = "Food Menu";
            this.groupBoxFood.Enter += new System.EventHandler(this.groupBoxFood_Enter);
            // 
            // checkedListBoxFood
            // 
            this.checkedListBoxFood.FormattingEnabled = true;
            this.checkedListBoxFood.Location = new System.Drawing.Point(23, 30);
            this.checkedListBoxFood.Name = "checkedListBoxFood";
            this.checkedListBoxFood.Size = new System.Drawing.Size(241, 106);
            this.checkedListBoxFood.TabIndex = 32;
            this.checkedListBoxFood.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxFood_SelectedIndexChanged_1);
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFood.Location = new System.Drawing.Point(356, 9);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFood.TabIndex = 27;
            this.pictureBoxFood.TabStop = false;
            // 
            // labelPriceFood
            // 
            this.labelPriceFood.AutoSize = true;
            this.labelPriceFood.Location = new System.Drawing.Point(254, 157);
            this.labelPriceFood.Name = "labelPriceFood";
            this.labelPriceFood.Size = new System.Drawing.Size(38, 16);
            this.labelPriceFood.TabIndex = 31;
            this.labelPriceFood.Text = "00:00";
            this.labelPriceFood.Click += new System.EventHandler(this.labelPriceFood_Click);
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
            this.btnRemFood.Click += new System.EventHandler(this.btnRemFood_Click);
            // 
            // listFood
            // 
            this.listFood.FormattingEnabled = true;
            this.listFood.ItemHeight = 16;
            this.listFood.Location = new System.Drawing.Point(644, 95);
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
            this.labelMenu.Location = new System.Drawing.Point(355, -14);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(453, 82);
            this.labelMenu.TabIndex = 23;
            this.labelMenu.Text = "Enjoy Our Menu";
            // 
            // groupBoxDessert
            // 
            this.groupBoxDessert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxDessert.Controls.Add(this.checkedListBoxDessert);
            this.groupBoxDessert.Controls.Add(this.pictureBoxDessert);
            this.groupBoxDessert.Controls.Add(this.labelPriceDessert);
            this.groupBoxDessert.Controls.Add(this.labelQtyDessert);
            this.groupBoxDessert.Controls.Add(this.numericUpDownDessert);
            this.groupBoxDessert.Controls.Add(this.btnRemDessert);
            this.groupBoxDessert.Controls.Add(this.btnAddDessert);
            this.groupBoxDessert.Location = new System.Drawing.Point(71, 358);
            this.groupBoxDessert.Name = "groupBoxDessert";
            this.groupBoxDessert.Size = new System.Drawing.Size(551, 250);
            this.groupBoxDessert.TabIndex = 24;
            this.groupBoxDessert.TabStop = false;
            this.groupBoxDessert.Text = "Menu Dessert";
            // 
            // checkedListBoxDessert
            // 
            this.checkedListBoxDessert.FormattingEnabled = true;
            this.checkedListBoxDessert.Location = new System.Drawing.Point(23, 32);
            this.checkedListBoxDessert.Name = "checkedListBoxDessert";
            this.checkedListBoxDessert.Size = new System.Drawing.Size(241, 106);
            this.checkedListBoxDessert.TabIndex = 31;
            this.checkedListBoxDessert.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxDessert_SelectedIndexChanged_1);
            // 
            // pictureBoxDessert
            // 
            this.pictureBoxDessert.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxDessert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDessert.Location = new System.Drawing.Point(356, 9);
            this.pictureBoxDessert.Name = "pictureBoxDessert";
            this.pictureBoxDessert.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxDessert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDessert.TabIndex = 28;
            this.pictureBoxDessert.TabStop = false;
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
            this.btnAddDessert.Click += new System.EventHandler(this.btnAddDessert_Click_1);
            // 
            // groupBoxDrink
            // 
            this.groupBoxDrink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxDrink.Controls.Add(this.pictureBoxDrink);
            this.groupBoxDrink.Controls.Add(this.labelPriceDrink);
            this.groupBoxDrink.Controls.Add(this.labelQtyDrink);
            this.groupBoxDrink.Controls.Add(this.btnRemDrink);
            this.groupBoxDrink.Controls.Add(this.numericUpDownDrink);
            this.groupBoxDrink.Controls.Add(this.btnAddDrink);
            this.groupBoxDrink.Controls.Add(this.checkedListBoxDrink);
            this.groupBoxDrink.Location = new System.Drawing.Point(71, 630);
            this.groupBoxDrink.Name = "groupBoxDrink";
            this.groupBoxDrink.Size = new System.Drawing.Size(551, 250);
            this.groupBoxDrink.TabIndex = 25;
            this.groupBoxDrink.TabStop = false;
            this.groupBoxDrink.Text = "Drink Menu";
            // 
            // pictureBoxDrink
            // 
            this.pictureBoxDrink.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDrink.Location = new System.Drawing.Point(356, 10);
            this.pictureBoxDrink.Name = "pictureBoxDrink";
            this.pictureBoxDrink.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDrink.TabIndex = 29;
            this.pictureBoxDrink.TabStop = false;
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
            this.btnRemDrink.Click += new System.EventHandler(this.btnRemDrink_Click);
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
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(881, 916);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 53);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // imageListFood
            // 
            this.imageListFood.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFood.ImageStream")));
            this.imageListFood.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFood.Images.SetKeyName(0, "Chicken Lasagna.png");
            this.imageListFood.Images.SetKeyName(1, "Spaghetti Carbonara.png");
            this.imageListFood.Images.SetKeyName(2, "Chicken Chop.png");
            this.imageListFood.Images.SetKeyName(3, "Tomyam Seafood.png");
            this.imageListFood.Images.SetKeyName(4, "Buttermilk Chicken.png");
            this.imageListFood.Images.SetKeyName(5, "Spaghetti Aglio Olio.png");
            this.imageListFood.Images.SetKeyName(6, "Fish & Chips.png");
            // 
            // imageListDessert
            // 
            this.imageListDessert.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDessert.ImageStream")));
            this.imageListDessert.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDessert.Images.SetKeyName(0, "Chocolate Moist Cake.png");
            this.imageListDessert.Images.SetKeyName(1, "Matcha Burn Cheese Cake.png");
            this.imageListDessert.Images.SetKeyName(2, "Tiramisu.png");
            this.imageListDessert.Images.SetKeyName(3, "Chocolate Donut.png");
            this.imageListDessert.Images.SetKeyName(4, "Cheese Cupcake.png");
            this.imageListDessert.Images.SetKeyName(5, "Blueberry Cupcake.png");
            this.imageListDessert.Images.SetKeyName(6, "Vanilla Cake.png");
            this.imageListDessert.Images.SetKeyName(7, "Eggtart.png");
            // 
            // imageListDrink
            // 
            this.imageListDrink.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDrink.ImageStream")));
            this.imageListDrink.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDrink.Images.SetKeyName(0, "Matcha.jpg");
            this.imageListDrink.Images.SetKeyName(1, "Greentea.jpg");
            this.imageListDrink.Images.SetKeyName(2, "Thai Tea.jpg");
            this.imageListDrink.Images.SetKeyName(3, "Australian Chocolate.jpg");
            this.imageListDrink.Images.SetKeyName(4, "Ice Spanish Latte.jpg");
            this.imageListDrink.Images.SetKeyName(5, "Buttercreme.jpg");
            this.imageListDrink.Images.SetKeyName(6, "Ice Viatnamese Latte.jpg");
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::ProjectKawaiiCafeOrderingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 1055);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFood)).EndInit();
            this.groupBoxDessert.ResumeLayout(false);
            this.groupBoxDessert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDessert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDessert)).EndInit();
            this.groupBoxDrink.ResumeLayout(false);
            this.groupBoxDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrink)).EndInit();
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
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelPriceDessert;
        private System.Windows.Forms.Label labelPriceDrink;
        private System.Windows.Forms.Label labelPriceFood;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.PictureBox pictureBoxDessert;
        private System.Windows.Forms.PictureBox pictureBoxDrink;
        private System.Windows.Forms.ImageList imageListFood;
        private System.Windows.Forms.ImageList imageListDessert;
        private System.Windows.Forms.ImageList imageListDrink;
        private System.Windows.Forms.CheckedListBox checkedListBoxFood;
        private System.Windows.Forms.CheckedListBox checkedListBoxDessert;
    }
}