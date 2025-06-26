namespace ProjectKawaiiCafeOrderingSystem
{
    partial class adminForm
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
            System.Windows.Forms.Label menu_IDLabel;
            System.Windows.Forms.Label menu_typeLabel;
            System.Windows.Forms.Label menu_nameLabel;
            System.Windows.Forms.Label menu_priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.adminDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataSetDatabase = new ProjectKawaiiCafeOrderingSystem.DataSetDatabase();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new ProjectKawaiiCafeOrderingSystem.DataSetDatabaseTableAdapters.MenuTableAdapter();
            this.tableAdapterManager = new ProjectKawaiiCafeOrderingSystem.DataSetDatabaseTableAdapters.TableAdapterManager();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_IDTextBox = new System.Windows.Forms.TextBox();
            this.menu_typeTextBox = new System.Windows.Forms.TextBox();
            this.menu_nameTextBox = new System.Windows.Forms.TextBox();
            this.menu_priceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            menu_IDLabel = new System.Windows.Forms.Label();
            menu_typeLabel = new System.Windows.Forms.Label();
            menu_nameLabel = new System.Windows.Forms.Label();
            menu_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_IDLabel
            // 
            menu_IDLabel.AutoSize = true;
            menu_IDLabel.Location = new System.Drawing.Point(63, 110);
            menu_IDLabel.Name = "menu_IDLabel";
            menu_IDLabel.Size = new System.Drawing.Size(50, 13);
            menu_IDLabel.TabIndex = 22;
            menu_IDLabel.Text = "menu ID:";
            // 
            // menu_typeLabel
            // 
            menu_typeLabel.AutoSize = true;
            menu_typeLabel.Location = new System.Drawing.Point(63, 136);
            menu_typeLabel.Name = "menu_typeLabel";
            menu_typeLabel.Size = new System.Drawing.Size(59, 13);
            menu_typeLabel.TabIndex = 24;
            menu_typeLabel.Text = "menu type:";
            // 
            // menu_nameLabel
            // 
            menu_nameLabel.AutoSize = true;
            menu_nameLabel.Location = new System.Drawing.Point(63, 162);
            menu_nameLabel.Name = "menu_nameLabel";
            menu_nameLabel.Size = new System.Drawing.Size(65, 13);
            menu_nameLabel.TabIndex = 26;
            menu_nameLabel.Text = "menu name:";
            // 
            // menu_priceLabel
            // 
            menu_priceLabel.AutoSize = true;
            menu_priceLabel.Location = new System.Drawing.Point(63, 188);
            menu_priceLabel.Name = "menu_priceLabel";
            menu_priceLabel.Size = new System.Drawing.Size(62, 13);
            menu_priceLabel.TabIndex = 28;
            menu_priceLabel.Text = "menu price:";
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.adminDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.adminDataGridView.Location = new System.Drawing.Point(568, 231);
            this.adminDataGridView.Name = "adminDataGridView";
            this.adminDataGridView.RowHeadersWidth = 51;
            this.adminDataGridView.Size = new System.Drawing.Size(635, 473);
            this.adminDataGridView.TabIndex = 1;
            this.adminDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(565, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Menu Name :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(668, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(611, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Type :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Food",
            "Dessert",
            "Drink"});
            this.comboBox1.Location = new System.Drawing.Point(668, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1090, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 58);
            this.button2.TabIndex = 16;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(593, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "ADMIN";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(873, 131);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 18;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(873, 168);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(817, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "From :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(833, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "To :";
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(1263, 27);
            this.customerBindingNavigator.TabIndex = 22;
            this.customerBindingNavigator.Text = "bindingNavigator1";
            this.customerBindingNavigator.RefreshItems += new System.EventHandler(this.customerBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.customerBindingNavigatorSaveItem.Text = "Save Data";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // dataSetDatabase
            // 
            this.dataSetDatabase.DataSetName = "DataSetDatabase";
            this.dataSetDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.dataSetDatabase;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.MenuTableAdapter = this.menuTableAdapter;
            this.tableAdapterManager.MerchandiseTableAdapter = null;
            this.tableAdapterManager.Order_MenuTableAdapter = null;
            this.tableAdapterManager.Order_MerchandiseTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectKawaiiCafeOrderingSystem.DataSetDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.AutoGenerateColumns = false;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.menuDataGridView.DataSource = this.menuBindingSource;
            this.menuDataGridView.Location = new System.Drawing.Point(62, 231);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.Size = new System.Drawing.Size(441, 473);
            this.menuDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "menu_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "menu_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "menu_type";
            this.dataGridViewTextBoxColumn6.HeaderText = "menu_type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "menu_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "menu_name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "menu_price";
            this.dataGridViewTextBoxColumn8.HeaderText = "menu_price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // menu_IDTextBox
            // 
            this.menu_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "menu_ID", true));
            this.menu_IDTextBox.Location = new System.Drawing.Point(134, 107);
            this.menu_IDTextBox.Name = "menu_IDTextBox";
            this.menu_IDTextBox.Size = new System.Drawing.Size(150, 20);
            this.menu_IDTextBox.TabIndex = 23;
            this.menu_IDTextBox.TextChanged += new System.EventHandler(this.menu_IDTextBox_TextChanged);
            // 
            // menu_typeTextBox
            // 
            this.menu_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "menu_type", true));
            this.menu_typeTextBox.Location = new System.Drawing.Point(134, 133);
            this.menu_typeTextBox.Name = "menu_typeTextBox";
            this.menu_typeTextBox.Size = new System.Drawing.Size(150, 20);
            this.menu_typeTextBox.TabIndex = 25;
            this.menu_typeTextBox.TextChanged += new System.EventHandler(this.menu_typeTextBox_TextChanged);
            // 
            // menu_nameTextBox
            // 
            this.menu_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "menu_name", true));
            this.menu_nameTextBox.Location = new System.Drawing.Point(134, 159);
            this.menu_nameTextBox.Name = "menu_nameTextBox";
            this.menu_nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.menu_nameTextBox.TabIndex = 27;
            // 
            // menu_priceTextBox
            // 
            this.menu_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "menu_price", true));
            this.menu_priceTextBox.Location = new System.Drawing.Point(134, 185);
            this.menu_priceTextBox.Name = "menu_priceTextBox";
            this.menu_priceTextBox.Size = new System.Drawing.Size(150, 20);
            this.menu_priceTextBox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(428, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Location = new System.Drawing.Point(428, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 31;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(428, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 32;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectKawaiiCafeOrderingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 724);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(menu_IDLabel);
            this.Controls.Add(this.menu_IDTextBox);
            this.Controls.Add(menu_typeLabel);
            this.Controls.Add(this.menu_typeTextBox);
            this.Controls.Add(menu_nameLabel);
            this.Controls.Add(this.menu_nameTextBox);
            this.Controls.Add(menu_priceLabel);
            this.Controls.Add(this.menu_priceTextBox);
            this.Controls.Add(this.menuDataGridView);
            this.Controls.Add(this.customerBindingNavigator);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adminDataGridView);
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~ Admin";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView adminDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataSetDatabase dataSetDatabase;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private DataSetDatabaseTableAdapters.MenuTableAdapter menuTableAdapter;
        private DataSetDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox menu_IDTextBox;
        private System.Windows.Forms.TextBox menu_typeTextBox;
        private System.Windows.Forms.TextBox menu_nameTextBox;
        private System.Windows.Forms.TextBox menu_priceTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}