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
            this.labelProName = new System.Windows.Forms.Label();
            this.labelProPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.pictureBoxMerch = new System.Windows.Forms.PictureBox();
            this.imageListMerch = new System.Windows.Forms.ImageList(this.components);
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.checkBoxCustName = new System.Windows.Forms.CheckBox();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            this.buttonNextForm = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
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
            this.labelMerchTittle.Location = new System.Drawing.Point(12, 9);
            this.labelMerchTittle.Name = "labelMerchTittle";
            this.labelMerchTittle.Size = new System.Drawing.Size(545, 82);
            this.labelMerchTittle.TabIndex = 9;
            this.labelMerchTittle.Text = "Kawaii Merchandise";
            this.labelMerchTittle.Click += new System.EventHandler(this.labelMerchTittle_Click);
            // 
            // labelProName
            // 
            this.labelProName.AutoSize = true;
            this.labelProName.BackColor = System.Drawing.Color.Transparent;
            this.labelProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProName.Location = new System.Drawing.Point(523, 126);
            this.labelProName.Name = "labelProName";
            this.labelProName.Size = new System.Drawing.Size(238, 38);
            this.labelProName.TabIndex = 10;
            this.labelProName.Text = "Product Name";
            this.labelProName.Click += new System.EventHandler(this.labelProName_Click);
            // 
            // labelProPrice
            // 
            this.labelProPrice.AutoSize = true;
            this.labelProPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelProPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProPrice.Location = new System.Drawing.Point(524, 182);
            this.labelProPrice.Name = "labelProPrice";
            this.labelProPrice.Size = new System.Drawing.Size(154, 36);
            this.labelProPrice.TabIndex = 11;
            this.labelProPrice.Text = "RM 00.00";
            this.labelProPrice.Click += new System.EventHandler(this.labelProPrice_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(524, 233);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(398, 29);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Product Description ............................";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.BackColor = System.Drawing.Color.Gainsboro;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQty.Location = new System.Drawing.Point(560, 281);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(151, 36);
            this.labelQty.TabIndex = 13;
            this.labelQty.Text = "Quantity: ";
            this.labelQty.Click += new System.EventHandler(this.labelQty_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.Gainsboro;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(583, 330);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(128, 36);
            this.labelColor.TabIndex = 14;
            this.labelColor.Text = "Colour: ";
            this.labelColor.Click += new System.EventHandler(this.labelColor_Click);
            // 
            // pictureBoxMerch
            // 
            this.pictureBoxMerch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMerch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMerch.Location = new System.Drawing.Point(63, 94);
            this.pictureBoxMerch.Name = "pictureBoxMerch";
            this.pictureBoxMerch.Size = new System.Drawing.Size(437, 400);
            this.pictureBoxMerch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMerch.TabIndex = 15;
            this.pictureBoxMerch.TabStop = false;
            this.pictureBoxMerch.Click += new System.EventHandler(this.pictureBoxMerch_Click);
            // 
            // imageListMerch
            // 
            this.imageListMerch.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMerch.ImageStream")));
            this.imageListMerch.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMerch.Images.SetKeyName(0, "kawaii tumblr.jpg");
            this.imageListMerch.Images.SetKeyName(1, "kawai tshirt hitam.jpg");
            this.imageListMerch.Images.SetKeyName(2, "kawaii totebag.jpg");
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Location = new System.Drawing.Point(734, 287);
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(159, 22);
            this.numericUpDownQty.TabIndex = 16;
            this.numericUpDownQty.ValueChanged += new System.EventHandler(this.numericUpDownQty_ValueChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(734, 337);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(159, 24);
            this.comboBoxColor.TabIndex = 17;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // checkBoxCustName
            // 
            this.checkBoxCustName.AutoSize = true;
            this.checkBoxCustName.BackColor = System.Drawing.Color.Gainsboro;
            this.checkBoxCustName.Location = new System.Drawing.Point(589, 380);
            this.checkBoxCustName.Name = "checkBoxCustName";
            this.checkBoxCustName.Size = new System.Drawing.Size(142, 20);
            this.checkBoxCustName.TabIndex = 18;
            this.checkBoxCustName.Text = "Add Custom Name";
            this.checkBoxCustName.UseVisualStyleBackColor = false;
            this.checkBoxCustName.CheckedChanged += new System.EventHandler(this.checkBoxCustName_CheckedChanged);
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.Location = new System.Drawing.Point(589, 406);
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(304, 22);
            this.textBoxCustName.TabIndex = 19;
            this.textBoxCustName.TextChanged += new System.EventHandler(this.textBoxCustName_TextChanged);
            // 
            // buttonNextForm
            // 
            this.buttonNextForm.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNextForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextForm.Location = new System.Drawing.Point(1029, 520);
            this.buttonNextForm.Name = "buttonNextForm";
            this.buttonNextForm.Size = new System.Drawing.Size(118, 53);
            this.buttonNextForm.TabIndex = 20;
            this.buttonNextForm.Text = "Next";
            this.buttonNextForm.UseVisualStyleBackColor = false;
            this.buttonNextForm.Click += new System.EventHandler(this.buttonNextForm_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(382, 520);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(118, 53);
            this.buttonNext.TabIndex = 21;
            this.buttonNext.Text = "Next\r\nProduct >";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(63, 520);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(118, 53);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "< Previous\r\nProduct";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // merchandiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::ProjectKawaiiCafeOrderingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 598);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonNextForm);
            this.Controls.Add(this.textBoxCustName);
            this.Controls.Add(this.checkBoxCustName);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.numericUpDownQty);
            this.Controls.Add(this.pictureBoxMerch);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelProPrice);
            this.Controls.Add(this.labelProName);
            this.Controls.Add(this.labelMerchTittle);
            this.Name = "merchandiseForm";
            this.Text = "merchandiseForm";
            this.Load += new System.EventHandler(this.merchandiseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMerch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMerchTittle;
        private System.Windows.Forms.Label labelProName;
        private System.Windows.Forms.Label labelProPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.PictureBox pictureBoxMerch;
        private System.Windows.Forms.ImageList imageListMerch;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.CheckBox checkBoxCustName;
        private System.Windows.Forms.TextBox textBoxCustName;
        private System.Windows.Forms.Button buttonNextForm;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
    }
}