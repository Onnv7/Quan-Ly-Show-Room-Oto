
namespace QuanLyShowRoomOto
{
    partial class AddOrderForm
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
            this.btnAdd = new QuanLyShowRoomOto.ButtonDesign();
            this.txtMaDon = new QuanLyShowRoomOto.TextBoxDesign();
            this.lbMaDon = new System.Windows.Forms.Label();
            this.lbXN = new System.Windows.Forms.Label();
            this.lbNgNhan = new System.Windows.Forms.Label();
            this.dateTimePickerNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.radiobtnDaXN = new QuanLyShowRoomOto.RadioButtonDesign();
            this.radiobtnChuaXN = new QuanLyShowRoomOto.RadioButtonDesign();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new QuanLyShowRoomOto.ButtonDesign();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAdd.Location = new System.Drawing.Point(58, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMaDon
            // 
            this.txtMaDon.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtMaDon.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaDon.BorderSize = 2;
            this.txtMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDon.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaDon.Location = new System.Drawing.Point(218, 43);
            this.txtMaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDon.Multiline = false;
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtMaDon.PasswordChar = false;
            this.txtMaDon.Size = new System.Drawing.Size(250, 36);
            this.txtMaDon.TabIndex = 2;
            this.txtMaDon.Texts = "";
            this.txtMaDon.UnderlinedStyle = false;
            // 
            // lbMaDon
            // 
            this.lbMaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaDon.AutoSize = true;
            this.lbMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDon.ForeColor = System.Drawing.Color.Black;
            this.lbMaDon.Location = new System.Drawing.Point(34, 50);
            this.lbMaDon.Name = "lbMaDon";
            this.lbMaDon.Size = new System.Drawing.Size(57, 16);
            this.lbMaDon.TabIndex = 75;
            this.lbMaDon.Text = "Mã Đơn:";
            // 
            // lbXN
            // 
            this.lbXN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbXN.AutoSize = true;
            this.lbXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXN.ForeColor = System.Drawing.Color.Black;
            this.lbXN.Location = new System.Drawing.Point(34, 164);
            this.lbXN.Name = "lbXN";
            this.lbXN.Size = new System.Drawing.Size(69, 16);
            this.lbXN.TabIndex = 77;
            this.lbXN.Text = "Xác Nhận:";
            // 
            // lbNgNhan
            // 
            this.lbNgNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNgNhan.AutoSize = true;
            this.lbNgNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgNhan.ForeColor = System.Drawing.Color.Black;
            this.lbNgNhan.Location = new System.Drawing.Point(34, 107);
            this.lbNgNhan.Name = "lbNgNhan";
            this.lbNgNhan.Size = new System.Drawing.Size(79, 16);
            this.lbNgNhan.TabIndex = 78;
            this.lbNgNhan.Text = "Ngày Nhận:";
            // 
            // dateTimePickerNgayNhan
            // 
            this.dateTimePickerNgayNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayNhan.Location = new System.Drawing.Point(218, 101);
            this.dateTimePickerNgayNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerNgayNhan.Name = "dateTimePickerNgayNhan";
            this.dateTimePickerNgayNhan.Size = new System.Drawing.Size(210, 22);
            this.dateTimePickerNgayNhan.TabIndex = 79;
            // 
            // radiobtnDaXN
            // 
            this.radiobtnDaXN.AutoSize = true;
            this.radiobtnDaXN.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(197)))));
            this.radiobtnDaXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnDaXN.Location = new System.Drawing.Point(194, 17);
            this.radiobtnDaXN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiobtnDaXN.MinimumSize = new System.Drawing.Size(0, 17);
            this.radiobtnDaXN.Name = "radiobtnDaXN";
            this.radiobtnDaXN.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.radiobtnDaXN.Size = new System.Drawing.Size(126, 22);
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
            this.radiobtnChuaXN.Location = new System.Drawing.Point(22, 17);
            this.radiobtnChuaXN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiobtnChuaXN.MinimumSize = new System.Drawing.Size(0, 17);
            this.radiobtnChuaXN.Name = "radiobtnChuaXN";
            this.radiobtnChuaXN.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.radiobtnChuaXN.Size = new System.Drawing.Size(142, 22);
            this.radiobtnChuaXN.TabIndex = 80;
            this.radiobtnChuaXN.TabStop = true;
            this.radiobtnChuaXN.Text = "Chưa Xác Nhận";
            this.radiobtnChuaXN.UnCheckedColor = System.Drawing.Color.Gray;
            this.radiobtnChuaXN.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radiobtnDaXN);
            this.panel1.Controls.Add(this.radiobtnChuaXN);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(196, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 55);
            this.panel1.TabIndex = 82;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 18;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(323, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 83;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(529, 301);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePickerNgayNhan);
            this.Controls.Add(this.lbNgNhan);
            this.Controls.Add(this.lbXN);
            this.Controls.Add(this.lbMaDon);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMaDon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrderForm";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonDesign btnAdd;
        private TextBoxDesign txtMaDon;
        private System.Windows.Forms.Label lbMaDon;
        private System.Windows.Forms.Label lbXN;
        private System.Windows.Forms.Label lbNgNhan;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhan;
        private RadioButtonDesign radiobtnDaXN;
        private RadioButtonDesign radiobtnChuaXN;
        private System.Windows.Forms.Panel panel1;
        private ButtonDesign btnCancel;
    }
}