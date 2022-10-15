
namespace QuanLyShowRoomOto
{
    partial class FormAddBaoDuong
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
            this.lb_DayPay = new System.Windows.Forms.Label();
            this.dateTimePickerDayPay = new System.Windows.Forms.DateTimePicker();
            this.lb_AddMaXe = new System.Windows.Forms.Label();
            this.txtMaHD = new QuanLyShowRoomOto.TextBoxDesign();
            this.btnAdd = new QuanLyShowRoomOto.ButtonDesign();
            this.btnCancel = new QuanLyShowRoomOto.ButtonDesign();
            this.SuspendLayout();
            // 
            // lb_DayPay
            // 
            this.lb_DayPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_DayPay.AutoSize = true;
            this.lb_DayPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DayPay.ForeColor = System.Drawing.Color.Black;
            this.lb_DayPay.Location = new System.Drawing.Point(113, 125);
            this.lb_DayPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_DayPay.Name = "lb_DayPay";
            this.lb_DayPay.Size = new System.Drawing.Size(115, 16);
            this.lb_DayPay.TabIndex = 128;
            this.lb_DayPay.Text = "Ngày Bảo Dưỡng:";
            // 
            // dateTimePickerDayPay
            // 
            this.dateTimePickerDayPay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDayPay.Location = new System.Drawing.Point(275, 125);
            this.dateTimePickerDayPay.Name = "dateTimePickerDayPay";
            this.dateTimePickerDayPay.Size = new System.Drawing.Size(261, 20);
            this.dateTimePickerDayPay.TabIndex = 127;
            // 
            // lb_AddMaXe
            // 
            this.lb_AddMaXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_AddMaXe.AutoSize = true;
            this.lb_AddMaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddMaXe.ForeColor = System.Drawing.Color.Black;
            this.lb_AddMaXe.Location = new System.Drawing.Point(113, 58);
            this.lb_AddMaXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_AddMaXe.Name = "lb_AddMaXe";
            this.lb_AddMaXe.Size = new System.Drawing.Size(53, 16);
            this.lb_AddMaXe.TabIndex = 125;
            this.lb_AddMaXe.Text = "Mã HD:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtMaHD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaHD.BorderSize = 2;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaHD.Location = new System.Drawing.Point(275, 48);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Multiline = false;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaHD.PasswordChar = false;
            this.txtMaHD.Size = new System.Drawing.Size(261, 36);
            this.txtMaHD.TabIndex = 132;
            this.txtMaHD.Texts = "";
            this.txtMaHD.UnderlinedStyle = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(244)))), ((int)(((byte)(92)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(244)))), ((int)(((byte)(92)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderRadius = 18;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(386, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 131;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(70)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(70)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 18;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(116, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 130;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddBaoDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(643, 335);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lb_DayPay);
            this.Controls.Add(this.dateTimePickerDayPay);
            this.Controls.Add(this.lb_AddMaXe);
            this.Name = "FormAddBaoDuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBaoDuongForm";
            this.Load += new System.EventHandler(this.FormAddBaoDuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_DayPay;
        private System.Windows.Forms.DateTimePicker dateTimePickerDayPay;
        private System.Windows.Forms.Label lb_AddMaXe;
        private ButtonDesign btnAdd;
        private ButtonDesign btnCancel;
        public TextBoxDesign txtMaHD;
    }
}