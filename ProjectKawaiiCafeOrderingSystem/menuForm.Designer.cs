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
            this.ListDessert = new System.Windows.Forms.ListBox();
            this.listDrink = new System.Windows.Forms.ListBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.groupBoxFood = new System.Windows.Forms.GroupBox();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.labelPriceFood = new System.Windows.Forms.Label();
            this.labelQtyMenu = new System.Windows.Forms.Label();
            this.numericUpDownFood = new System.Windows.Forms.NumericUpDown();
            this.btnRemFood = new System.Windows.Forms.Button();
            this.listFood = new System.Windows.Forms.ListBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.groupBoxDessert = new System.Windows.Forms.GroupBox();
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
            this.FoodDataGridView = new System.Windows.Forms.DataGridView();
            this.DrinkDataGridView = new System.Windows.Forms.DataGridView();
            this.DessertDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuDataSet = new ProjectKawaiiCafeOrderingSystem.MenuDataSet();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuTableAdapter = new ProjectKawaiiCafeOrderingSystem.MenuDataSetTableAdapters.MenuTableAdapter();
            this.tableAdapterManager = new ProjectKawaiiCafeOrderingSystem.MenuDataSetTableAdapters.TableAdapterManager();
            this.groupBoxFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFood)).BeginInit();
            this.groupBoxDessert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDessert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDessert)).BeginInit();
            this.groupBoxDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DessertDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ListDessert
            // 
            this.ListDessert.FormattingEnabled = true;
            this.ListDessert.ItemHeight = 16;
            this.ListDessert.Location = new System.Drawing.Point(1168, 21);
            this.ListDessert.Name = "ListDessert";
            this.ListDessert.Size = new System.Drawing.Size(355, 244);
            this.ListDessert.TabIndex = 2;
            this.ListDessert.SelectedIndexChanged += new System.EventHandler(this.ListDessert_SelectedIndexChanged);
            // 
            // listDrink
            // 
            this.listDrink.FormattingEnabled = true;
            this.listDrink.ItemHeight = 16;
            this.listDrink.Location = new System.Drawing.Point(1168, 21);
            this.listDrink.Name = "listDrink";
            this.listDrink.Size = new System.Drawing.Size(355, 244);
            this.listDrink.TabIndex = 3;
            this.listDrink.SelectedIndexChanged += new System.EventHandler(this.listDrink_SelectedIndexChanged);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.LightGray;
            this.btnAddFood.Location = new System.Drawing.Point(997, 180);
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
            this.groupBoxFood.Controls.Add(this.FoodDataGridView);
            this.groupBoxFood.Controls.Add(this.pictureBoxFood);
            this.groupBoxFood.Controls.Add(this.labelPriceFood);
            this.groupBoxFood.Controls.Add(this.labelQtyMenu);
            this.groupBoxFood.Controls.Add(this.listFood);
            this.groupBoxFood.Controls.Add(this.numericUpDownFood);
            this.groupBoxFood.Controls.Add(this.btnRemFood);
            this.groupBoxFood.Controls.Add(this.btnAddFood);
            this.groupBoxFood.Location = new System.Drawing.Point(50, 51);
            this.groupBoxFood.Name = "groupBoxFood";
            this.groupBoxFood.Size = new System.Drawing.Size(1554, 291);
            this.groupBoxFood.TabIndex = 21;
            this.groupBoxFood.TabStop = false;
            this.groupBoxFood.Text = "Food Menu";
            this.groupBoxFood.Enter += new System.EventHandler(this.groupBoxFood_Enter);
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFood.Location = new System.Drawing.Point(691, 43);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFood.TabIndex = 27;
            this.pictureBoxFood.TabStop = false;
            // 
            // labelPriceFood
            // 
            this.labelPriceFood.AutoSize = true;
            this.labelPriceFood.Location = new System.Drawing.Point(887, 127);
            this.labelPriceFood.Name = "labelPriceFood";
            this.labelPriceFood.Size = new System.Drawing.Size(38, 16);
            this.labelPriceFood.TabIndex = 31;
            this.labelPriceFood.Text = "00:00";
            this.labelPriceFood.Click += new System.EventHandler(this.labelPriceFood_Click);
            // 
            // labelQtyMenu
            // 
            this.labelQtyMenu.AutoSize = true;
            this.labelQtyMenu.Location = new System.Drawing.Point(888, 154);
            this.labelQtyMenu.Name = "labelQtyMenu";
            this.labelQtyMenu.Size = new System.Drawing.Size(58, 16);
            this.labelQtyMenu.TabIndex = 24;
            this.labelQtyMenu.Text = "Quantity:";
            // 
            // numericUpDownFood
            // 
            this.numericUpDownFood.Location = new System.Drawing.Point(954, 152);
            this.numericUpDownFood.Name = "numericUpDownFood";
            this.numericUpDownFood.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFood.TabIndex = 23;
            // 
            // btnRemFood
            // 
            this.btnRemFood.BackColor = System.Drawing.Color.LightGray;
            this.btnRemFood.Location = new System.Drawing.Point(883, 180);
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
            this.listFood.Location = new System.Drawing.Point(1168, 18);
            this.listFood.Name = "listFood";
            this.listFood.Size = new System.Drawing.Size(355, 244);
            this.listFood.TabIndex = 22;
            this.listFood.SelectedIndexChanged += new System.EventHandler(this.listFood_SelectedIndexChanged);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.Transparent;
            this.labelMenu.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Transparent;
            this.labelMenu.Location = new System.Drawing.Point(51, -8);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(320, 56);
            this.labelMenu.TabIndex = 23;
            this.labelMenu.Text = "Enjoy Our Menu";
            // 
            // groupBoxDessert
            // 
            this.groupBoxDessert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxDessert.Controls.Add(this.DessertDataGridView);
            this.groupBoxDessert.Controls.Add(this.pictureBoxDessert);
            this.groupBoxDessert.Controls.Add(this.labelPriceDessert);
            this.groupBoxDessert.Controls.Add(this.labelQtyDessert);
            this.groupBoxDessert.Controls.Add(this.numericUpDownDessert);
            this.groupBoxDessert.Controls.Add(this.btnRemDessert);
            this.groupBoxDessert.Controls.Add(this.btnAddDessert);
            this.groupBoxDessert.Controls.Add(this.ListDessert);
            this.groupBoxDessert.Location = new System.Drawing.Point(50, 670);
            this.groupBoxDessert.Name = "groupBoxDessert";
            this.groupBoxDessert.Size = new System.Drawing.Size(1554, 291);
            this.groupBoxDessert.TabIndex = 24;
            this.groupBoxDessert.TabStop = false;
            this.groupBoxDessert.Text = "Menu Dessert";
            this.groupBoxDessert.Enter += new System.EventHandler(this.groupBoxDessert_Enter);
            // 
            // pictureBoxDessert
            // 
            this.pictureBoxDessert.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxDessert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDessert.Location = new System.Drawing.Point(691, 48);
            this.pictureBoxDessert.Name = "pictureBoxDessert";
            this.pictureBoxDessert.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxDessert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDessert.TabIndex = 28;
            this.pictureBoxDessert.TabStop = false;
            // 
            // labelPriceDessert
            // 
            this.labelPriceDessert.AutoSize = true;
            this.labelPriceDessert.Location = new System.Drawing.Point(892, 120);
            this.labelPriceDessert.Name = "labelPriceDessert";
            this.labelPriceDessert.Size = new System.Drawing.Size(38, 16);
            this.labelPriceDessert.TabIndex = 30;
            this.labelPriceDessert.Text = "00:00";
            this.labelPriceDessert.Click += new System.EventHandler(this.labelPriceDessert_Click);
            // 
            // labelQtyDessert
            // 
            this.labelQtyDessert.AutoSize = true;
            this.labelQtyDessert.Location = new System.Drawing.Point(890, 151);
            this.labelQtyDessert.Name = "labelQtyDessert";
            this.labelQtyDessert.Size = new System.Drawing.Size(58, 16);
            this.labelQtyDessert.TabIndex = 26;
            this.labelQtyDessert.Text = "Quantity:";
            this.labelQtyDessert.Click += new System.EventHandler(this.labelQtyDessert_Click);
            // 
            // numericUpDownDessert
            // 
            this.numericUpDownDessert.Location = new System.Drawing.Point(954, 149);
            this.numericUpDownDessert.Name = "numericUpDownDessert";
            this.numericUpDownDessert.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDessert.TabIndex = 25;
            // 
            // btnRemDessert
            // 
            this.btnRemDessert.BackColor = System.Drawing.Color.LightGray;
            this.btnRemDessert.Location = new System.Drawing.Point(882, 186);
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
            this.btnAddDessert.Location = new System.Drawing.Point(997, 186);
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
            this.groupBoxDrink.Controls.Add(this.DrinkDataGridView);
            this.groupBoxDrink.Controls.Add(this.pictureBoxDrink);
            this.groupBoxDrink.Controls.Add(this.labelPriceDrink);
            this.groupBoxDrink.Controls.Add(this.labelQtyDrink);
            this.groupBoxDrink.Controls.Add(this.btnRemDrink);
            this.groupBoxDrink.Controls.Add(this.numericUpDownDrink);
            this.groupBoxDrink.Controls.Add(this.listDrink);
            this.groupBoxDrink.Controls.Add(this.btnAddDrink);
            this.groupBoxDrink.Location = new System.Drawing.Point(50, 359);
            this.groupBoxDrink.Name = "groupBoxDrink";
            this.groupBoxDrink.Size = new System.Drawing.Size(1554, 291);
            this.groupBoxDrink.TabIndex = 25;
            this.groupBoxDrink.TabStop = false;
            this.groupBoxDrink.Text = "Drink Menu";
            this.groupBoxDrink.Enter += new System.EventHandler(this.groupBoxDrink_Enter);
            // 
            // pictureBoxDrink
            // 
            this.pictureBoxDrink.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDrink.Location = new System.Drawing.Point(691, 47);
            this.pictureBoxDrink.Name = "pictureBoxDrink";
            this.pictureBoxDrink.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDrink.TabIndex = 29;
            this.pictureBoxDrink.TabStop = false;
            // 
            // labelPriceDrink
            // 
            this.labelPriceDrink.AutoSize = true;
            this.labelPriceDrink.Location = new System.Drawing.Point(887, 122);
            this.labelPriceDrink.Name = "labelPriceDrink";
            this.labelPriceDrink.Size = new System.Drawing.Size(38, 16);
            this.labelPriceDrink.TabIndex = 29;
            this.labelPriceDrink.Text = "00:00";
            // 
            // labelQtyDrink
            // 
            this.labelQtyDrink.AutoSize = true;
            this.labelQtyDrink.Location = new System.Drawing.Point(887, 155);
            this.labelQtyDrink.Name = "labelQtyDrink";
            this.labelQtyDrink.Size = new System.Drawing.Size(58, 16);
            this.labelQtyDrink.TabIndex = 27;
            this.labelQtyDrink.Text = "Quantity:";
            // 
            // btnRemDrink
            // 
            this.btnRemDrink.BackColor = System.Drawing.Color.LightGray;
            this.btnRemDrink.Location = new System.Drawing.Point(883, 185);
            this.btnRemDrink.Name = "btnRemDrink";
            this.btnRemDrink.Size = new System.Drawing.Size(108, 42);
            this.btnRemDrink.TabIndex = 21;
            this.btnRemDrink.Text = "Remove Drink\r\n";
            this.btnRemDrink.UseVisualStyleBackColor = false;
            this.btnRemDrink.Click += new System.EventHandler(this.btnRemDrink_Click);
            // 
            // numericUpDownDrink
            // 
            this.numericUpDownDrink.Location = new System.Drawing.Point(954, 149);
            this.numericUpDownDrink.Name = "numericUpDownDrink";
            this.numericUpDownDrink.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDrink.TabIndex = 26;
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.BackColor = System.Drawing.Color.LightGray;
            this.btnAddDrink.Location = new System.Drawing.Point(997, 185);
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
            this.btnNext.Location = new System.Drawing.Point(1658, 898);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 63);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            // FoodDataGridView
            // 
            this.FoodDataGridView.AutoGenerateColumns = false;
            this.FoodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.FoodDataGridView.DataSource = this.menuBindingSource;
            this.FoodDataGridView.Location = new System.Drawing.Point(52, 42);
            this.FoodDataGridView.Name = "FoodDataGridView";
            this.FoodDataGridView.RowHeadersWidth = 51;
            this.FoodDataGridView.RowTemplate.Height = 24;
            this.FoodDataGridView.Size = new System.Drawing.Size(606, 220);
            this.FoodDataGridView.TabIndex = 27;
            this.FoodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuDataGridView_CellContentClick);
            // 
            // DrinkDataGridView
            // 
            this.DrinkDataGridView.AutoGenerateColumns = false;
            this.DrinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrinkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DrinkDataGridView.DataSource = this.menuBindingSource;
            this.DrinkDataGridView.Location = new System.Drawing.Point(52, 45);
            this.DrinkDataGridView.Name = "DrinkDataGridView";
            this.DrinkDataGridView.RowHeadersWidth = 51;
            this.DrinkDataGridView.RowTemplate.Height = 24;
            this.DrinkDataGridView.Size = new System.Drawing.Size(606, 220);
            this.DrinkDataGridView.TabIndex = 30;
            this.DrinkDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrinkDataGridView_CellContentClick);
            // 
            // DessertDataGridView
            // 
            this.DessertDataGridView.AutoGenerateColumns = false;
            this.DessertDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DessertDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.DessertDataGridView.DataSource = this.menuBindingSource;
            this.DessertDataGridView.Location = new System.Drawing.Point(52, 48);
            this.DessertDataGridView.Name = "DessertDataGridView";
            this.DessertDataGridView.RowHeadersWidth = 51;
            this.DessertDataGridView.RowTemplate.Height = 24;
            this.DessertDataGridView.Size = new System.Drawing.Size(606, 220);
            this.DessertDataGridView.TabIndex = 31;
            this.DessertDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "menu_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "menu_ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "menu_type";
            this.dataGridViewTextBoxColumn6.HeaderText = "menu_type";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "menu_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "menu_name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "menu_price";
            this.dataGridViewTextBoxColumn8.HeaderText = "menu_price";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.menuDataSet;
            // 
            // menuDataSet
            // 
            this.menuDataSet.DataSetName = "MenuDataSet";
            this.menuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "menu_ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "menu_ID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "menu_type";
            this.dataGridViewTextBoxColumn10.HeaderText = "menu_type";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "menu_name";
            this.dataGridViewTextBoxColumn11.HeaderText = "menu_name";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "menu_price";
            this.dataGridViewTextBoxColumn12.HeaderText = "menu_price";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "menu_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "menu_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "menu_type";
            this.dataGridViewTextBoxColumn2.HeaderText = "menu_type";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "menu_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "menu_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "menu_price";
            this.dataGridViewTextBoxColumn4.HeaderText = "menu_price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MenuTableAdapter = this.menuTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjectKawaiiCafeOrderingSystem.MenuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1829, 1055);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBoxDrink);
            this.Controls.Add(this.groupBoxDessert);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.groupBoxFood);
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
            ((System.ComponentModel.ISupportInitialize)(this.FoodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DessertDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private MenuDataSet menuDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private MenuDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private MenuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView FoodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView DrinkDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView DessertDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}