namespace ProjectKawaiiCafeOrderingSystem
{
    partial class merchandiseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(merchandiseForm));
            this.labelMerchTittle = new System.Windows.Forms.Label();
            this.pictureBoxMerch = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.imageListMerch = new System.Windows.Forms.ImageList(this.components);
            this.labelProName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelProPrice = new System.Windows.Forms.Label();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.checkBoxCustName = new System.Windows.Forms.CheckBox();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMerch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMerchTittle
            // 
            this.labelMerchTittle.AutoSize = true;
            this.labelMerchTittle.BackColor = System.Drawing.Color.Transparent;
            this.labelMerchTittle.Font = new System.Drawing.Font("Monotype Corsiva", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMerchTittle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMerchTittle.Location = new System.Drawing.Point(21, 18);
            this.labelMerchTittle.Name = "labelMerchTittle";
            this.labelMerchTittle.Size = new System.Drawing.Size(545, 82);
            this.labelMerchTittle.TabIndex = 9;
            this.labelMerchTittle.Text = "Kawaii Merchandise";
            this.labelMerchTittle.Click += new System.EventHandler(this.labelMerchTittle_Click);
            // 
            // pictureBoxMerch
            // 
            this.pictureBoxMerch.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxMerch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMerch.Location = new System.Drawing.Point(49, 116);
            this.pictureBoxMerch.Name = "pictureBoxMerch";
            this.pictureBoxMerch.Size = new System.Drawing.Size(444, 361);
            this.pictureBoxMerch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMerch.TabIndex = 10;
            this.pictureBoxMerch.TabStop = false;
            this.pictureBoxMerch.Click += new System.EventHandler(this.pictureBoxMerch_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.LightGray;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(351, 502);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(142, 61);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.Text = "Next \r\nProduct >";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LightGray;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(49, 502);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(142, 61);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "< Previous \r\nProduct";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(689, 374);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(167, 24);
            this.comboBoxColor.TabIndex = 13;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.Gainsboro;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(585, 373);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(89, 25);
            this.labelColor.TabIndex = 14;
            this.labelColor.Text = "Colour :";
            this.labelColor.Click += new System.EventHandler(this.labelColor_Click);
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.BackColor = System.Drawing.Color.Gainsboro;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQty.Location = new System.Drawing.Point(566, 331);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(106, 25);
            this.labelQty.TabIndex = 15;
            this.labelQty.Text = "Quantity :";
            this.labelQty.Click += new System.EventHandler(this.labelQty_Click);
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Location = new System.Drawing.Point(689, 334);
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(165, 22);
            this.numericUpDownQty.TabIndex = 16;
            this.numericUpDownQty.ValueChanged += new System.EventHandler(this.numericUpDownQty_ValueChanged);
            // 
            // imageListMerch
            // 
            this.imageListMerch.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMerch.ImageStream")));
            this.imageListMerch.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMerch.Images.SetKeyName(0, "kawaii tumblr.jpg");
            this.imageListMerch.Images.SetKeyName(1, "kawai tshirt hitam.jpg");
            this.imageListMerch.Images.SetKeyName(2, "kawaii totebag.jpg");
            // 
            // labelProName
            // 
            this.labelProName.AutoSize = true;
            this.labelProName.BackColor = System.Drawing.Color.Transparent;
            this.labelProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProName.Location = new System.Drawing.Point(545, 124);
            this.labelProName.Name = "labelProName";
            this.labelProName.Size = new System.Drawing.Size(206, 32);
            this.labelProName.TabIndex = 17;
            this.labelProName.Text = "Product Name";
            this.labelProName.Click += new System.EventHandler(this.labelProName_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(556, 224);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(432, 68);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Product Description...............................\r\n............................." +
    ".........................................\r\n....................................." +
    ".................................\r\n";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // labelProPrice
            // 
            this.labelProPrice.AutoSize = true;
            this.labelProPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelProPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProPrice.Location = new System.Drawing.Point(551, 176);
            this.labelProPrice.Name = "labelProPrice";
            this.labelProPrice.Size = new System.Drawing.Size(122, 29);
            this.labelProPrice.TabIndex = 19;
            this.labelProPrice.Text = "RM 00.00";
            this.labelProPrice.Click += new System.EventHandler(this.labelProPrice_Click);
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.BackColor = System.Drawing.Color.LightGray;
            this.buttonPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchase.Location = new System.Drawing.Point(1028, 520);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(118, 53);
            this.buttonPurchase.TabIndex = 20;
            this.buttonPurchase.Text = "Next";
            this.buttonPurchase.UseVisualStyleBackColor = false;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // checkBoxCustName
            // 
            this.checkBoxCustName.AutoSize = true;
            this.checkBoxCustName.Location = new System.Drawing.Point(596, 415);
            this.checkBoxCustName.Name = "checkBoxCustName";
            this.checkBoxCustName.Size = new System.Drawing.Size(142, 20);
            this.checkBoxCustName.TabIndex = 21;
            this.checkBoxCustName.Text = "Add Custom Name";
            this.checkBoxCustName.UseVisualStyleBackColor = true;
            this.checkBoxCustName.CheckedChanged += new System.EventHandler(this.checkBoxCustName_CheckedChanged);
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.Location = new System.Drawing.Point(596, 441);
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(260, 22);
            this.textBoxCustName.TabIndex = 22;
            this.textBoxCustName.TextChanged += new System.EventHandler(this.textBoxCustName_TextChanged);
            // 
            // merchandiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::ProjectKawaiiCafeOrderingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 598);
            this.Controls.Add(this.textBoxCustName);
            this.Controls.Add(this.checkBoxCustName);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.labelProPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelProName);
            this.Controls.Add(this.numericUpDownQty);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBoxMerch);
            this.Controls.Add(this.labelMerchTittle);
            this.Name = "merchandiseForm";
            this.Text = "~ Merchandise";
            this.Load += new System.EventHandler(this.merchandiseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMerch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMerchTittle;
        private System.Windows.Forms.PictureBox pictureBoxMerch;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.ImageList imageListMerch;
        private System.Windows.Forms.Label labelProName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelProPrice;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.CheckBox checkBoxCustName;
        private System.Windows.Forms.TextBox textBoxCustName;
    }
}