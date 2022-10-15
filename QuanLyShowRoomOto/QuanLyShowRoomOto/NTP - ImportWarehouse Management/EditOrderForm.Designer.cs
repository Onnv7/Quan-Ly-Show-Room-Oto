
namespace QuanLyShowRoomOto
{
    partial class EditOrderForm
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
            this.btnCancel = new QuanLyShowRoomOto.ButtonDesign();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radiobtnDaXN = new QuanLyShowRoomOto.RadioButtonDesign();
            this.radiobtnChuaXN = new QuanLyShowRoomOto.RadioButtonDesign();
            this.dateTimePickerNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.lbNgNhan = new System.Windows.Forms.Label();
            this.lbXN = new System.Windows.Forms.Label();
            this.lbMaDon = new System.Windows.Forms.Label();
            this.btnEdit = new QuanLyShowRoomOto.ButtonDesign();
            this.txtMaDon = new QuanLyShowRoomOto.TextBoxDesign();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 18;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(357, 277);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 43);
            this.btnCancel.TabIndex = 93;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radiobtnDaXN);
            this.panel1.Controls.Add(this.radiobtnChuaXN);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(272, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 69);
            this.panel1.TabIndex = 92;
            // 
            // radiobtnDaXN
            // 
            this.radiobtnDaXN.AutoSize = true;
            this.radiobtnDaXN.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(197)))));
            this.radiobtnDaXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnDaXN.Location = new System.Drawing.Point(236, 22);
            this.radiobtnDaXN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtnDaXN.MinimumSize = new System.Drawing.Size(0, 21);
            this.radiobtnDaXN.Name = "radiobtnDaXN";
            this.radiobtnDaXN.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.radiobtnDaXN.Size = new System.Drawing.Size(153, 28);
            this.radiobtnDaXN.TabIndex = 81;
            this.radiobtnDaXN.TabStop = true;
            this.radiobtnDaXN.Text = "Đã Xác Nhận";
            this.radiobtnDaXN.UnCheckedColor = System.Drawing.Color.Gray;
            this.radiobtnDaXN.UseVisualStyleBackColor = true;
            // 
            // radiobtnChuaXN
            // 
            this.radiobtnChuaXN.AutoSize = true;
            this.radiobtnChuaXN.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(197)))));
            this.radiobtnChuaXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnChuaXN.Location = new System.Drawing.Point(29, 21);
            this.radiobtnChuaXN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtnChuaXN.MinimumSize = new System.Drawing.Size(0, 21);
            this.radiobtnChuaXN.Name = "radiobtnChuaXN";
            this.radiobtnChuaXN.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.radiobtnChuaXN.Size = new System.Drawing.Size(175, 28);
            this.radiobtnChuaXN.TabIndex = 80;
            this.radiobtnChuaXN.TabStop = true;
            this.radiobtnChuaXN.Text = "Chưa Xác Nhận";
            this.radiobtnChuaXN.UnCheckedColor = System.Drawing.Color.Gray;
            this.radiobtnChuaXN.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgayNhan
            // 
            this.dateTimePickerNgayNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayNhan.Location = new System.Drawing.Point(301, 106);
            this.dateTimePickerNgayNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerNgayNhan.Name = "dateTimePickerNgayNhan";
            this.dateTimePickerNgayNhan.Size = new System.Drawing.Size(335, 26);
            this.dateTimePickerNgayNhan.TabIndex = 91;
            // 
            // lbNgNhan
            // 
            this.lbNgNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNgNhan.AutoSize = true;
            this.lbNgNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgNhan.ForeColor = System.Drawing.Color.Black;
            this.lbNgNhan.Location = new System.Drawing.Point(55, 114);
            this.lbNgNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgNhan.Name = "lbNgNhan";
            this.lbNgNhan.Size = new System.Drawing.Size(96, 20);
            this.lbNgNhan.TabIndex = 90;
            this.lbNgNhan.Text = "Ngày Nhận:";
            // 
            // lbXN
            // 
            this.lbXN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbXN.AutoSize = true;
            this.lbXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXN.ForeColor = System.Drawing.Color.Black;
            this.lbXN.Location = new System.Drawing.Point(55, 185);
            this.lbXN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbXN.Name = "lbXN";
            this.lbXN.Size = new System.Drawing.Size(87, 20);
            this.lbXN.TabIndex = 89;
            this.lbXN.Text = "Xác Nhận:";
            // 
            // lbMaDon
            // 
            this.lbMaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaDon.AutoSize = true;
            this.lbMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDon.ForeColor = System.Drawing.Color.Black;
            this.lbMaDon.Location = new System.Drawing.Point(55, 44);
            this.lbMaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaDon.Name = "lbMaDon";
            this.lbMaDon.Size = new System.Drawing.Size(72, 20);
            this.lbMaDon.TabIndex = 87;
            this.lbMaDon.Text = "Mã Đơn:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(224)))), ((int)(((byte)(133)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(224)))), ((int)(((byte)(133)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.BorderRadius = 18;
            this.btnEdit.BorderSize = 1;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(114, 277);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 43);
            this.btnEdit.TabIndex = 85;
            this.btnEdit.Text = "Chỉnh Sửa";
            this.btnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtMaDon
            // 
            this.txtMaDon.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtMaDon.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaDon.BorderSize = 2;
            this.txtMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDon.ForeColor = System.Drawing.Color.Black;
            this.txtMaDon.Location = new System.Drawing.Point(301, 34);
            this.txtMaDon.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaDon.Multiline = false;
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Padding = new System.Windows.Forms.Padding(9);
            this.txtMaDon.PasswordChar = false;
            this.txtMaDon.Size = new System.Drawing.Size(333, 44);
            this.txtMaDon.TabIndex = 84;
            this.txtMaDon.Texts = "";
            this.txtMaDon.UnderlinedStyle = false;
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(717, 350);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePickerNgayNhan);
            this.Controls.Add(this.lbNgNhan);
            this.Controls.Add(this.lbXN);
            this.Controls.Add(this.lbMaDon);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtMaDon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditOrderForm";
            this.Text = "EditOrderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonDesign btnCancel;
        private System.Windows.Forms.Panel panel1;
        public RadioButtonDesign radiobtnDaXN;
        public RadioButtonDesign radiobtnChuaXN;
        public System.Windows.Forms.DateTimePicker dateTimePickerNgayNhan;
        private System.Windows.Forms.Label lbNgNhan;
        private System.Windows.Forms.Label lbXN;
        private System.Windows.Forms.Label lbMaDon;
        private ButtonDesign btnEdit;
        public TextBoxDesign txtMaDon;
    }
}