namespace ProjectKawaiiCafeOrderingSystem
{
    partial class registerForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMembership = new System.Windows.Forms.CheckBox();
            this.labelTypeMembership = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labelKawaiTittle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(283, 148);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name : ";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPwd.Location = new System.Drawing.Point(249, 265);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(114, 25);
            this.labelPwd.TabIndex = 1;
            this.labelPwd.Text = "Password : ";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(279, 185);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(85, 25);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username : ";
            // 
            // checkBoxMembership
            // 
            this.checkBoxMembership.AutoSize = true;
            this.checkBoxMembership.Location = new System.Drawing.Point(369, 320);
            this.checkBoxMembership.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMembership.Name = "checkBoxMembership";
            this.checkBoxMembership.Size = new System.Drawing.Size(117, 20);
            this.checkBoxMembership.TabIndex = 6;
            this.checkBoxMembership.Text = "Membership ? ";
            this.checkBoxMembership.UseVisualStyleBackColor = true;
            this.checkBoxMembership.CheckedChanged += new System.EventHandler(this.checkBoxMembership_CheckedChanged);
            // 
            // labelTypeMembership
            // 
            this.labelTypeMembership.AutoSize = true;
            this.labelTypeMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeMembership.Location = new System.Drawing.Point(283, 346);
            this.labelTypeMembership.Name = "labelTypeMembership";
            this.labelTypeMembership.Size = new System.Drawing.Size(73, 25);
            this.labelTypeMembership.TabIndex = 7;
            this.labelTypeMembership.Text = "Type : ";
            this.labelTypeMembership.Click += new System.EventHandler(this.labelTypeMembership_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(369, 153);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(257, 22);
            this.textBoxName.TabIndex = 9;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(369, 190);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(257, 22);
            this.textBoxPhone.TabIndex = 10;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(369, 230);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(257, 22);
            this.textBoxUsername.TabIndex = 12;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(369, 268);
            this.textBoxPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(257, 22);
            this.textBoxPwd.TabIndex = 13;
            this.textBoxPwd.UseSystemPasswordChar = true;
            this.textBoxPwd.TextChanged += new System.EventHandler(this.textBoxPwd_TextChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Silver",
            "Gold",
            "Premium"});
            this.comboBoxType.Location = new System.Drawing.Point(369, 346);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(257, 24);
            this.comboBoxType.TabIndex = 14;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(728, 431);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(140, 57);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // labelKawaiTittle
            // 
            this.labelKawaiTittle.AutoSize = true;
            this.labelKawaiTittle.BackColor = System.Drawing.Color.Transparent;
            this.labelKawaiTittle.Font = new System.Drawing.Font("Monotype Corsiva", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKawaiTittle.ForeColor = System.Drawing.Color.DimGray;
            this.labelKawaiTittle.Location = new System.Drawing.Point(190, 9);
            this.labelKawaiTittle.Name = "labelKawaiTittle";
            this.labelKawaiTittle.Size = new System.Drawing.Size(576, 82);
            this.labelKawaiTittle.TabIndex = 16;
            this.labelKawaiTittle.Text = "Kawaii Cafe Ordering";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(316, 111);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 25);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID : ";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(369, 115);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(257, 22);
            this.textBoxID.TabIndex = 18;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(92, 431);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 57);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.labelKawaiTittle);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTypeMembership);
            this.Controls.Add(this.checkBoxMembership);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "registerForm";
            this.Text = "~ Customer Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMembership;
        private System.Windows.Forms.Label labelTypeMembership;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labelKawaiTittle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button btnBack;
    }
}