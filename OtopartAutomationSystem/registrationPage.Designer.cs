
namespace OtopartAutomationSystem
{
    partial class registrationPage
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumberplate = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.grppersonalInformation = new System.Windows.Forms.GroupBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.mskPhonenumber = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblphoneNumber = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.grpvehicleInformation = new System.Windows.Forms.GroupBox();
            this.cmbVehicletype = new System.Windows.Forms.ComboBox();
            this.cmbCarpark = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grppersonalInformation.SuspendLayout();
            this.grpvehicleInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(89, 108);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(135, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(89, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNumberplate
            // 
            this.txtNumberplate.Location = new System.Drawing.Point(97, 58);
            this.txtNumberplate.Name = "txtNumberplate";
            this.txtNumberplate.Size = new System.Drawing.Size(132, 20);
            this.txtNumberplate.TabIndex = 6;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(96, 123);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(132, 20);
            this.txtColor.TabIndex = 9;
            // 
            // grppersonalInformation
            // 
            this.grppersonalInformation.Controls.Add(this.mskTc);
            this.grppersonalInformation.Controls.Add(this.mskPhonenumber);
            this.grppersonalInformation.Controls.Add(this.lblEmail);
            this.grppersonalInformation.Controls.Add(this.lblphoneNumber);
            this.grppersonalInformation.Controls.Add(this.lblSurname);
            this.grppersonalInformation.Controls.Add(this.lblName);
            this.grppersonalInformation.Controls.Add(this.lblTc);
            this.grppersonalInformation.Controls.Add(this.txtName);
            this.grppersonalInformation.Controls.Add(this.txtSurname);
            this.grppersonalInformation.Controls.Add(this.txtEmail);
            this.grppersonalInformation.Location = new System.Drawing.Point(12, 41);
            this.grppersonalInformation.Name = "grppersonalInformation";
            this.grppersonalInformation.Size = new System.Drawing.Size(261, 226);
            this.grppersonalInformation.TabIndex = 10;
            this.grppersonalInformation.TabStop = false;
            this.grppersonalInformation.Text = "Kişi Bilgileri";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(89, 41);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(135, 20);
            this.mskTc.TabIndex = 1;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // mskPhonenumber
            // 
            this.mskPhonenumber.Location = new System.Drawing.Point(89, 138);
            this.mskPhonenumber.Mask = "(999) 000-0000";
            this.mskPhonenumber.Name = "mskPhonenumber";
            this.mskPhonenumber.Size = new System.Drawing.Size(135, 20);
            this.mskPhonenumber.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(38, 171);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblphoneNumber
            // 
            this.lblphoneNumber.AutoSize = true;
            this.lblphoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblphoneNumber.Location = new System.Drawing.Point(31, 138);
            this.lblphoneNumber.Name = "lblphoneNumber";
            this.lblphoneNumber.Size = new System.Drawing.Size(43, 13);
            this.lblphoneNumber.TabIndex = 15;
            this.lblphoneNumber.Text = "Telefon";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(37, 108);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(37, 13);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Soyad";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(54, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(20, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Ad";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.ForeColor = System.Drawing.Color.Black;
            this.lblTc.Location = new System.Drawing.Point(53, 48);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(21, 13);
            this.lblTc.TabIndex = 12;
            this.lblTc.Text = "TC";
            // 
            // grpvehicleInformation
            // 
            this.grpvehicleInformation.Controls.Add(this.cmbVehicletype);
            this.grpvehicleInformation.Controls.Add(this.cmbCarpark);
            this.grpvehicleInformation.Controls.Add(this.label1);
            this.grpvehicleInformation.Controls.Add(this.txtNumberplate);
            this.grpvehicleInformation.Controls.Add(this.label2);
            this.grpvehicleInformation.Controls.Add(this.label4);
            this.grpvehicleInformation.Controls.Add(this.label5);
            this.grpvehicleInformation.Controls.Add(this.txtColor);
            this.grpvehicleInformation.Location = new System.Drawing.Point(312, 41);
            this.grpvehicleInformation.Name = "grpvehicleInformation";
            this.grpvehicleInformation.Size = new System.Drawing.Size(264, 226);
            this.grpvehicleInformation.TabIndex = 11;
            this.grpvehicleInformation.TabStop = false;
            this.grpvehicleInformation.Text = "Araç Bilgileri";
            // 
            // cmbVehicletype
            // 
            this.cmbVehicletype.FormattingEnabled = true;
            this.cmbVehicletype.Location = new System.Drawing.Point(97, 88);
            this.cmbVehicletype.Name = "cmbVehicletype";
            this.cmbVehicletype.Size = new System.Drawing.Size(132, 21);
            this.cmbVehicletype.TabIndex = 22;
            // 
            // cmbCarpark
            // 
            this.cmbCarpark.FormattingEnabled = true;
            this.cmbCarpark.Location = new System.Drawing.Point(96, 155);
            this.cmbCarpark.Name = "cmbCarpark";
            this.cmbCarpark.Size = new System.Drawing.Size(132, 21);
            this.cmbCarpark.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Park Yeri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Araç Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(51, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Plaka";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(187, 273);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 33);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Kayıt";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(312, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // registrationPage
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(588, 339);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpvehicleInformation);
            this.Controls.Add(this.grppersonalInformation);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "registrationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt Sayfası";
            this.Load += new System.EventHandler(this.registrationPage_Load);
            this.grppersonalInformation.ResumeLayout(false);
            this.grppersonalInformation.PerformLayout();
            this.grpvehicleInformation.ResumeLayout(false);
            this.grpvehicleInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumberplate;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.GroupBox grppersonalInformation;
        private System.Windows.Forms.GroupBox grpvehicleInformation;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblphoneNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.ComboBox cmbCarpark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox mskPhonenumber;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbVehicletype;
    }
}