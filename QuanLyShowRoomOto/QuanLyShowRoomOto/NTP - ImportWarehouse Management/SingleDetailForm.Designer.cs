
namespace QuanLyShowRoomOto
{
    partial class SingleDetailForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lb_MaDon = new System.Windows.Forms.Label();
			this.lb_ChiTiet = new System.Windows.Forms.Label();
			this.dataGridView_SingleDetail = new System.Windows.Forms.DataGridView();
			this.btnCancel = new QuanLyShowRoomOto.ButtonDesign();
			this.btnRemove = new QuanLyShowRoomOto.ButtonDesign();
			this.btnEdit = new QuanLyShowRoomOto.ButtonDesign();
			this.btnAdd = new QuanLyShowRoomOto.ButtonDesign();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_SingleDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_MaDon
			// 
			this.lb_MaDon.AutoSize = true;
			this.lb_MaDon.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_MaDon.ForeColor = System.Drawing.Color.Maroon;
			this.lb_MaDon.Location = new System.Drawing.Point(699, 30);
			this.lb_MaDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_MaDon.Name = "lb_MaDon";
			this.lb_MaDon.Size = new System.Drawing.Size(113, 46);
			this.lb_MaDon.TabIndex = 53;
			this.lb_MaDon.Text = "MD01";
			this.lb_MaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb_ChiTiet
			// 
			this.lb_ChiTiet.AutoSize = true;
			this.lb_ChiTiet.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ChiTiet.ForeColor = System.Drawing.Color.Maroon;
			this.lb_ChiTiet.Location = new System.Drawing.Point(326, 30);
			this.lb_ChiTiet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_ChiTiet.Name = "lb_ChiTiet";
			this.lb_ChiTiet.Size = new System.Drawing.Size(380, 46);
			this.lb_ChiTiet.TabIndex = 52;
			this.lb_ChiTiet.Text = "Chi Tiết Đơn Nhập Hàng";
			this.lb_ChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView_SingleDetail
			// 
			this.dataGridView_SingleDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_SingleDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_SingleDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_SingleDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_SingleDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_SingleDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_SingleDetail.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_SingleDetail.Location = new System.Drawing.Point(16, 102);
			this.dataGridView_SingleDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridView_SingleDetail.Name = "dataGridView_SingleDetail";
			this.dataGridView_SingleDetail.RowHeadersWidth = 51;
			this.dataGridView_SingleDetail.RowTemplate.Height = 24;
			this.dataGridView_SingleDetail.Size = new System.Drawing.Size(1097, 386);
			this.dataGridView_SingleDetail.TabIndex = 54;
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
			this.btnCancel.Location = new System.Drawing.Point(841, 535);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(210, 58);
			this.btnCancel.TabIndex = 55;
			this.btnCancel.Text = "Thoát";
			this.btnCancel.TextColor = System.Drawing.Color.Black;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(73)))));
			this.btnRemove.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(73)))));
			this.btnRemove.BorderColor = System.Drawing.Color.Black;
			this.btnRemove.BorderRadius = 18;
			this.btnRemove.BorderSize = 1;
			this.btnRemove.FlatAppearance.BorderSize = 0;
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemove.ForeColor = System.Drawing.Color.Black;
			this.btnRemove.Location = new System.Drawing.Point(588, 536);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(210, 58);
			this.btnRemove.TabIndex = 56;
			this.btnRemove.Text = "Xoá Chi Tiết Đơn";
			this.btnRemove.TextColor = System.Drawing.Color.Black;
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.btnEdit.BorderColor = System.Drawing.Color.Black;
			this.btnEdit.BorderRadius = 18;
			this.btnEdit.BorderSize = 1;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.Black;
			this.btnEdit.Location = new System.Drawing.Point(335, 536);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(210, 57);
			this.btnEdit.TabIndex = 57;
			this.btnEdit.Text = "Chỉnh Sửa Chi Tiết Đơn";
			this.btnEdit.TextColor = System.Drawing.Color.Black;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
			this.btnAdd.Location = new System.Drawing.Point(82, 536);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(210, 57);
			this.btnAdd.TabIndex = 58;
			this.btnAdd.Text = "Thêm Chi Tiết Đơn";
			this.btnAdd.TextColor = System.Drawing.Color.Black;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// SingleDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
			this.ClientSize = new System.Drawing.Size(1132, 660);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.dataGridView_SingleDetail);
			this.Controls.Add(this.lb_MaDon);
			this.Controls.Add(this.lb_ChiTiet);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "SingleDetailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SingleDetailForm";
			this.Load += new System.EventHandler(this.SingleDetailForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_SingleDetail)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_MaDon;
        private System.Windows.Forms.Label lb_ChiTiet;
        public System.Windows.Forms.DataGridView dataGridView_SingleDetail;
        private ButtonDesign btnCancel;
        private ButtonDesign btnRemove;
        private ButtonDesign btnEdit;
        private ButtonDesign btnAdd;
    }
}