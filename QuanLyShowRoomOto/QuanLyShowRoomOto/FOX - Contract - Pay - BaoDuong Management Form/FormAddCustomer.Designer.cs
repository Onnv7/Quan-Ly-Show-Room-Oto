
namespace QuanLyShowRoomOto
{
    partial class FormAddCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelAddPosition = new System.Windows.Forms.Label();
            this.labelAddSex = new System.Windows.Forms.Label();
            this.labelAddNBPhone = new System.Windows.Forms.Label();
            this.labelAddIDNumber = new System.Windows.Forms.Label();
            this.labelAddBirthday = new System.Windows.Forms.Label();
            this.labelAddLastName = new System.Windows.Forms.Label();
            this.labelAddStaffCode = new System.Windows.Forms.Label();
            this.txtMaKH = new QuanLyShowRoomOto.TextBoxDesign();
            this.txtFullName = new QuanLyShowRoomOto.TextBoxDesign();
            this.txtPhone = new QuanLyShowRoomOto.TextBoxDesign();
            this.txtCMND = new QuanLyShowRoomOto.TextBoxDesign();
            this.txtJob = new QuanLyShowRoomOto.TextBoxDesign();
            this.txtAddrs = new QuanLyShowRoomOto.TextBoxDesign();
            this.btnAdd = new QuanLyShowRoomOto.ButtonDesign();
            this.buttonDesign1 = new QuanLyShowRoomOto.ButtonDesign();
            this.radioButtonFemale = new QuanLyShowRoomOto.RadioButtonDesign();
            this.radioButtonMale = new QuanLyShowRoomOto.RadioButtonDesign();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(539, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Nghề Nghiệp";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(207, 325);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(172, 20);
            this.dateTimePickerBirthDate.TabIndex = 56;
            this.dateTimePickerBirthDate.ValueChanged += new System.EventHandler(this.dateTimePickerBirthDate_ValueChanged);
            // 
            // labelAddPosition
            // 
            this.labelAddPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddPosition.AutoSize = true;
            this.labelAddPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPosition.ForeColor = System.Drawing.Color.Black;
            this.labelAddPosition.Location = new System.Drawing.Point(539, 325);
            this.labelAddPosition.Name = "labelAddPosition";
            this.labelAddPosition.Size = new System.Drawing.Size(50, 16);
            this.labelAddPosition.TabIndex = 54;
            this.labelAddPosition.Text = "Địa Chỉ";
            // 
            // labelAddSex
            // 
            this.labelAddSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddSex.AutoSize = true;
            this.labelAddSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSex.ForeColor = System.Drawing.Color.Black;
            this.labelAddSex.Location = new System.Drawing.Point(67, 238);
            this.labelAddSex.Name = "labelAddSex";
            this.labelAddSex.Size = new System.Drawing.Size(58, 16);
            this.labelAddSex.TabIndex = 53;
            this.labelAddSex.Text = "Giới tính:";
            // 
            // labelAddNBPhone
            // 
            this.labelAddNBPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddNBPhone.AutoSize = true;
            this.labelAddNBPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddNBPhone.ForeColor = System.Drawing.Color.Black;
            this.labelAddNBPhone.Location = new System.Drawing.Point(539, 64);
            this.labelAddNBPhone.Name = "labelAddNBPhone";
            this.labelAddNBPhone.Size = new System.Drawing.Size(89, 16);
            this.labelAddNBPhone.TabIndex = 52;
            this.labelAddNBPhone.Text = "Số điện thoại:";
            // 
            // labelAddIDNumber
            // 
            this.labelAddIDNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddIDNumber.AutoSize = true;
            this.labelAddIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddIDNumber.ForeColor = System.Drawing.Color.Black;
            this.labelAddIDNumber.Location = new System.Drawing.Point(539, 151);
            this.labelAddIDNumber.Name = "labelAddIDNumber";
            this.labelAddIDNumber.Size = new System.Drawing.Size(92, 16);
            this.labelAddIDNumber.TabIndex = 51;
            this.labelAddIDNumber.Text = "CCCD/CMND:";
            // 
            // labelAddBirthday
            // 
            this.labelAddBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddBirthday.AutoSize = true;
            this.labelAddBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBirthday.ForeColor = System.Drawing.Color.Black;
            this.labelAddBirthday.Location = new System.Drawing.Point(67, 325);
            this.labelAddBirthday.Name = "labelAddBirthday";
            this.labelAddBirthday.Size = new System.Drawing.Size(71, 16);
            this.labelAddBirthday.TabIndex = 50;
            this.labelAddBirthday.Text = "Ngày sinh:";
            // 
            // labelAddLastName
            // 
            this.labelAddLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddLastName.AutoSize = true;
            this.labelAddLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddLastName.ForeColor = System.Drawing.Color.Black;
            this.labelAddLastName.Location = new System.Drawing.Point(67, 151);
            this.labelAddLastName.Name = "labelAddLastName";
            this.labelAddLastName.Size = new System.Drawing.Size(74, 16);
            this.labelAddLastName.TabIndex = 55;
            this.labelAddLastName.Text = "Họ và Tên:";
            // 
            // labelAddStaffCode
            // 
            this.labelAddStaffCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddStaffCode.AutoSize = true;
            this.labelAddStaffCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddStaffCode.ForeColor = System.Drawing.Color.Black;
            this.labelAddStaffCode.Location = new System.Drawing.Point(67, 64);
            this.labelAddStaffCode.Name = "labelAddStaffCode";
            this.labelAddStaffCode.Size = new System.Drawing.Size(102, 16);
            this.labelAddStaffCode.TabIndex = 49;
            this.labelAddStaffCode.Text = "Mã khách hàng:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtMaKH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaKH.BorderSize = 2;
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaKH.Location = new System.Drawing.Point(207, 55);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Multiline = false;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaKH.PasswordChar = false;
            this.txtMaKH.Size = new System.Drawing.Size(261, 36);
            this.txtMaKH.TabIndex = 149;
            this.txtMaKH.Texts = "";
            this.txtMaKH.UnderlinedStyle = false;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtFullName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFullName.BorderSize = 2;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFullName.Location = new System.Drawing.Point(207, 137);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Padding = new System.Windows.Forms.Padding(7);
            this.txtFullName.PasswordChar = false;
            this.txtFullName.Size = new System.Drawing.Size(261, 36);
            this.txtFullName.TabIndex = 150;
            this.txtFullName.Texts = "";
            this.txtFullName.UnderlinedStyle = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPhone.BorderSize = 2;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhone.Location = new System.Drawing.Point(652, 55);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.Size = new System.Drawing.Size(261, 36);
            this.txtPhone.TabIndex = 153;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlinedStyle = false;
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.SystemColors.Window;
            this.txtCMND.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtCMND.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCMND.BorderSize = 2;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.DimGray;
            this.txtCMND.Location = new System.Drawing.Point(652, 137);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Multiline = false;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Padding = new System.Windows.Forms.Padding(7);
            this.txtCMND.PasswordChar = false;
            this.txtCMND.Size = new System.Drawing.Size(261, 36);
            this.txtCMND.TabIndex = 154;
            this.txtCMND.Texts = "";
            this.txtCMND.UnderlinedStyle = false;
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.SystemColors.Window;
            this.txtJob.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtJob.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtJob.BorderSize = 2;
            this.txtJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.ForeColor = System.Drawing.Color.DimGray;
            this.txtJob.Location = new System.Drawing.Point(652, 225);
            this.txtJob.Margin = new System.Windows.Forms.Padding(4);
            this.txtJob.Multiline = false;
            this.txtJob.Name = "txtJob";
            this.txtJob.Padding = new System.Windows.Forms.Padding(7);
            this.txtJob.PasswordChar = false;
            this.txtJob.Size = new System.Drawing.Size(261, 36);
            this.txtJob.TabIndex = 155;
            this.txtJob.Texts = "";
            this.txtJob.UnderlinedStyle = false;
            // 
            // txtAddrs
            // 
            this.txtAddrs.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddrs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtAddrs.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAddrs.BorderSize = 2;
            this.txtAddrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddrs.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddrs.Location = new System.Drawing.Point(652, 316);
            this.txtAddrs.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddrs.Multiline = false;
            this.txtAddrs.Name = "txtAddrs";
            this.txtAddrs.Padding = new System.Windows.Forms.Padding(7);
            this.txtAddrs.PasswordChar = false;
            this.txtAddrs.Size = new System.Drawing.Size(261, 36);
            this.txtAddrs.TabIndex = 156;
            this.txtAddrs.Texts = "";
            this.txtAddrs.UnderlinedStyle = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderRadius = 18;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(499, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 157;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // buttonDesign1
            // 
            this.buttonDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.buttonDesign1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.buttonDesign1.BorderColor = System.Drawing.Color.Black;
            this.buttonDesign1.BorderRadius = 18;
            this.buttonDesign1.BorderSize = 1;
            this.buttonDesign1.FlatAppearance.BorderSize = 0;
            this.buttonDesign1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesign1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesign1.ForeColor = System.Drawing.Color.Black;
            this.buttonDesign1.Location = new System.Drawing.Point(278, 382);
            this.buttonDesign1.Name = "buttonDesign1";
            this.buttonDesign1.Size = new System.Drawing.Size(150, 40);
            this.buttonDesign1.TabIndex = 158;
            this.buttonDesign1.Text = "Hủy";
            this.buttonDesign1.TextColor = System.Drawing.Color.Black;
            this.buttonDesign1.UseVisualStyleBackColor = false;
            this.buttonDesign1.Click += new System.EventHandler(this.buttonDesign1_Click);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(197)))));
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(25, 10);
            this.radioButtonFemale.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButtonFemale.Size = new System.Drawing.Size(84, 21);
            this.radioButtonFemale.TabIndex = 159;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(197)))));
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(176, 10);
            this.radioButtonMale.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButtonMale.Size = new System.Drawing.Size(68, 21);
            this.radioButtonMale.TabIndex = 160;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonFemale);
            this.panel1.Controls.Add(this.radioButtonMale);
            this.panel1.Location = new System.Drawing.Point(207, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 37);
            this.panel1.TabIndex = 161;
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDesign1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddrs);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.labelAddPosition);
            this.Controls.Add(this.labelAddSex);
            this.Controls.Add(this.labelAddNBPhone);
            this.Controls.Add(this.labelAddIDNumber);
            this.Controls.Add(this.labelAddBirthday);
            this.Controls.Add(this.labelAddLastName);
            this.Controls.Add(this.labelAddStaffCode);
            this.Name = "FormAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label labelAddPosition;
        private System.Windows.Forms.Label labelAddSex;
        private System.Windows.Forms.Label labelAddNBPhone;
        private System.Windows.Forms.Label labelAddIDNumber;
        private System.Windows.Forms.Label labelAddBirthday;
        private System.Windows.Forms.Label labelAddLastName;
        private System.Windows.Forms.Label labelAddStaffCode;
        private TextBoxDesign txtMaKH;
        private TextBoxDesign txtFullName;
        private TextBoxDesign txtPhone;
        private TextBoxDesign txtCMND;
        private TextBoxDesign txtJob;
        private TextBoxDesign txtAddrs;
        private ButtonDesign btnAdd;
        private ButtonDesign buttonDesign1;
        private RadioButtonDesign radioButtonFemale;
        private RadioButtonDesign radioButtonMale;
        private System.Windows.Forms.Panel panel1;
    }
}