namespace ProjectKawaiiCafeOrderingSystem
{
    partial class mainForm
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNoHP = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.CheckBoxMembership = new System.Windows.Forms.CheckBox();
            this.labelKawaiTittle = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.comboBoxMembership = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxMain.Image = global::ProjectKawaiiCafeOrderingSystem.Properties.Resources.CafeMainImage;
            this.pictureBoxMain.Location = new System.Drawing.Point(81, 108);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(372, 401);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(565, 125);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(538, 202);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(105, 25);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address :";
            // 
            // lblNoHp
            // 
            this.lblNoHp.AutoSize = true;
            this.lblNoHp.BackColor = System.Drawing.Color.Transparent;
            this.lblNoHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoHp.Location = new System.Drawing.Point(558, 162);
            this.lblNoHp.Name = "lblNoHp";
            this.lblNoHp.Size = new System.Drawing.Size(87, 25);
            this.lblNoHp.TabIndex = 3;
            this.lblNoHp.Text = "No HP :";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxName.Location = new System.Drawing.Point(662, 125);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(235, 25);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxNoHP
            // 
            this.textBoxNoHP.Location = new System.Drawing.Point(662, 162);
            this.textBoxNoHP.Multiline = true;
            this.textBoxNoHP.Name = "textBoxNoHP";
            this.textBoxNoHP.Size = new System.Drawing.Size(235, 25);
            this.textBoxNoHP.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(662, 203);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(235, 121);
            this.textBoxAddress.TabIndex = 6;
            // 
            // CheckBoxMembership
            // 
            this.CheckBoxMembership.AutoSize = true;
            this.CheckBoxMembership.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxMembership.ForeColor = System.Drawing.Color.Transparent;
            this.CheckBoxMembership.Location = new System.Drawing.Point(662, 342);
            this.CheckBoxMembership.Name = "CheckBoxMembership";
            this.CheckBoxMembership.Size = new System.Drawing.Size(124, 22);
            this.CheckBoxMembership.TabIndex = 7;
            this.CheckBoxMembership.Text = "Membership ?";
            this.CheckBoxMembership.UseVisualStyleBackColor = false;
            // 
            // labelKawaiTittle
            // 
            this.labelKawaiTittle.AutoSize = true;
            this.labelKawaiTittle.BackColor = System.Drawing.Color.Transparent;
            this.labelKawaiTittle.Font = new System.Drawing.Font("Monotype Corsiva", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKawaiTittle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelKawaiTittle.Location = new System.Drawing.Point(12, 23);
            this.labelKawaiTittle.Name = "labelKawaiTittle";
            this.labelKawaiTittle.Size = new System.Drawing.Size(576, 82);
            this.labelKawaiTittle.TabIndex = 8;
            this.labelKawaiTittle.Text = "Kawaii Cafe Ordering";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Gainsboro;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(571, 419);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 25);
            this.lblType.TabIndex = 11;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(1031, 518);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 53);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // comboBoxMembership
            // 
            this.comboBoxMembership.FormattingEnabled = true;
            this.comboBoxMembership.Items.AddRange(new object[] {
            "Silver",
            "Gold",
            "Premium"});
            this.comboBoxMembership.Location = new System.Drawing.Point(662, 382);
            this.comboBoxMembership.Name = "comboBoxMembership";
            this.comboBoxMembership.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMembership.TabIndex = 14;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(565, 381);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(74, 25);
            this.labelType.TabIndex = 15;
            this.labelType.Text = "Type :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(593, 419);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(46, 25);
            this.labelID.TabIndex = 16;
            this.labelID.Text = "ID :";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxID.Location = new System.Drawing.Point(662, 419);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(235, 25);
            this.textBoxID.TabIndex = 17;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::ProjectKawaiiCafeOrderingSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 598);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxMembership);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.labelKawaiTittle);
            this.Controls.Add(this.CheckBoxMembership);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxNoHP);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblNoHp);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~ Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNoHP;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.CheckBox CheckBoxMembership;
        private System.Windows.Forms.Label labelKawaiTittle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox comboBoxMembership;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
    }
}

