
namespace QuanLyShowRoomOto
{
    partial class ImportWarehouseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelImport = new System.Windows.Forms.Panel();
            this.lbFind = new System.Windows.Forms.Label();
            this.panelRadioBtn = new System.Windows.Forms.Panel();
            this.radiobtnTatCa = new QuanLyShowRoomOto.RadioButtonDesign();
            this.radiobtnDaXN = new QuanLyShowRoomOto.RadioButtonDesign();
            this.radiobtnChuaXN = new QuanLyShowRoomOto.RadioButtonDesign();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmDonHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemove = new QuanLyShowRoomOto.ButtonDesign();
            this.btnEdit = new QuanLyShowRoomOto.ButtonDesign();
            this.btnSearch = new QuanLyShowRoomOto.ButtonDesign();
            this.txtFind = new QuanLyShowRoomOto.TextBoxDesign();
            this.dataGridView_ImportWarehouse = new System.Windows.Forms.DataGridView();
            this.panelImport.SuspendLayout();
            this.panelRadioBtn.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ImportWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImport
            // 
            this.panelImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.panelImport.Controls.Add(this.lbFind);
            this.panelImport.Controls.Add(this.panelRadioBtn);
            this.panelImport.Controls.Add(this.lbTimKiem);
            this.panelImport.Controls.Add(this.menuStrip1);
            this.panelImport.Controls.Add(this.btnRemove);
            this.panelImport.Controls.Add(this.btnEdit);
            this.panelImport.Controls.Add(this.btnSearch);
            this.panelImport.Controls.Add(this.txtFind);
            this.panelImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImport.Location = new System.Drawing.Point(0, 0);
            this.panelImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelImport.Name = "panelImport";
            this.panelImport.Size = new System.Drawing.Size(1083, 155);
            this.panelImport.TabIndex = 6;
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFind.ForeColor = System.Drawing.Color.Black;
            this.lbFind.Location = new System.Drawing.Point(17, 122);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(146, 16);
            this.lbFind.TabIndex = 70;
            this.lbFind.Text = "Nhập Mã Đơn Cần Tìm:";
            // 
            // panelRadioBtn
            // 
            this.panelRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelRadioBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRadioBtn.Controls.Add(this.radiobtnTatCa);
            this.panelRadioBtn.Controls.Add(this.radiobtnDaXN);
            this.panelRadioBtn.Controls.Add(this.radiobtnChuaXN);
            this.panelRadioBtn.Location = new System.Drawing.Point(553, 36);
            this.panelRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRadioBtn.Name = "panelRadioBtn";
            this.panelRadioBtn.Size = new System.Drawing.Size(192, 103);
            this.panelRadioBtn.TabIndex = 69;
            // 
            // radiobtnTatCa
            // 
            this.radiobtnTatCa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radiobtnTatCa.AutoSize = true;
            this.radiobtnTatCa.CheckedColor = System.Drawing.Color.MediumBlue;
            this.radiobtnTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnTatCa.Location = new System.Drawing.Point(13, 68);
            this.radiobtnTatCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiobtnTatCa.MinimumSize = new System.Drawing.Size(0, 17);
            this.radiobtnTatCa.Name = "radiobtnTatCa";
            this.radiobtnTatCa.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.radiobtnTatCa.Size = new System.Drawing.Size(79, 22);
            this.radiobtnTatCa.TabIndex = 68;
            this.radiobtnTatCa.TabStop = true;
            this.radiobtnTatCa.Text = "Tất cả";
            this.radiobtnTatCa.UnCheckedColor = System.Drawing.Color.Gray;
            this.radiobtnTatCa.UseVisualStyleBackColor = true;
            this.radiobtnTatCa.CheckedChanged += new System.EventHandler(this.radiobtnTatCa_CheckedChanged);
            // 
            // radiobtnDaXN
            // 
            this.radiobtnDaXN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radiobtnDaXN.AutoSize = true;
            this.radiobtnDaXN.CheckedColor = System.Drawing.Color.MediumBlue;
            this.radiobtnDaXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnDaXN.Location = new System.Drawing.Point(13, 41);
            this.radiobtnDaXN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiobtnDaXN.MinimumSize = new System.Drawing.Size(0, 17);
            this.radiobtnDaXN.Name = "radiobtnDaXN";
            this.radiobtnDaXN.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.radiobtnDaXN.Size = new System.Drawing.Size(166, 22);
            this.radiobtnDaXN.TabIndex = 67;
            this.radiobtnDaXN.TabStop = true;
            this.radiobtnDaXN.Text = "Đã Được Xác Nhận";
            this.radiobtnDaXN.UnCheckedColor = System.Drawing.Color.Gray;
            this.radiobtnDaXN.UseVisualStyleBackColor = true;
            this.radiobtnDaXN.CheckedChanged += new System.EventHandler(this.radiobtnDaXN_CheckedChanged);
            // 
            // radiobtnChuaXN
            // 
            this.radiobtnChuaXN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radiobtnChuaXN.AutoSize = true;
            this.radiobtnChuaXN.CheckedColor = System.Drawing.Color.MediumBlue;
            this.radiobtnChuaXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnChuaXN.Location = new System.Drawing.Point(13, 12);
            this.radiobtnChuaXN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiobtnChuaXN.MinimumSize = new System.Drawing.Size(0, 17);
            this.radiobtnChuaXN.Name = "radiobtnChuaXN";
            this.radiobtnChuaXN.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.radiobtnChuaXN.Size = new System.Drawing.Size(182, 22);
            this.radiobtnChuaXN.TabIndex = 66;
            this.radiobtnChuaXN.TabStop = true;
            this.radiobtnChuaXN.Text = "Chưa Được Xác Nhận";
            this.radiobtnChuaXN.UnCheckedColor = System.Drawing.Color.Gray;
            this.radiobtnChuaXN.UseVisualStyleBackColor = true;
            this.radiobtnChuaXN.CheckedChanged += new System.EventHandler(this.radiobtnChuaXN_CheckedChanged);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.lbTimKiem.Location = new System.Drawing.Point(408, 47);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(130, 16);
            this.lbTimKiem.TabIndex = 65;
            this.lbTimKiem.Text = "Tìm Kiếm Đơn Hàng:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1083, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmDonHangToolStripMenuItem});
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // thêmDonHangToolStripMenuItem
            // 
            this.thêmDonHangToolStripMenuItem.Name = "thêmDonHangToolStripMenuItem";
            this.thêmDonHangToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.thêmDonHangToolStripMenuItem.Text = "Thêm Đơn Nhập Hàng";
            this.thêmDonHangToolStripMenuItem.Click += new System.EventHandler(this.thêmDonHangToolStripMenuItem_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.btnRemove.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.btnRemove.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.BorderRadius = 18;
            this.btnRemove.BorderSize = 1;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(927, 32);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 40);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Xoá";
            this.btnRemove.TextColor = System.Drawing.Color.Black;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.BorderRadius = 18;
            this.btnEdit.BorderSize = 1;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(802, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.BorderRadius = 18;
            this.btnSearch.BorderSize = 1;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(211, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.SystemColors.Window;
            this.txtFind.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(81)))));
            this.txtFind.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFind.BorderSize = 2;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.DimGray;
            this.txtFind.Location = new System.Drawing.Point(34, 36);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFind.Multiline = false;
            this.txtFind.Name = "txtFind";
            this.txtFind.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtFind.PasswordChar = false;
            this.txtFind.Size = new System.Drawing.Size(318, 36);
            this.txtFind.TabIndex = 0;
            this.txtFind.Texts = "Nhập Mã Đơn để tìm kiếm Đơn Nhập Hàng";
            this.txtFind.UnderlinedStyle = false;
            this.txtFind.Enter += new System.EventHandler(this.txtFind_Enter);
            this.txtFind.Leave += new System.EventHandler(this.txtFind_Leave);
            // 
            // dataGridView_ImportWarehouse
            // 
            this.dataGridView_ImportWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ImportWarehouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_ImportWarehouse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ImportWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ImportWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ImportWarehouse.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ImportWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ImportWarehouse.Location = new System.Drawing.Point(0, 155);
            this.dataGridView_ImportWarehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_ImportWarehouse.Name = "dataGridView_ImportWarehouse";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ImportWarehouse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ImportWarehouse.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_ImportWarehouse.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_ImportWarehouse.RowTemplate.Height = 24;
            this.dataGridView_ImportWarehouse.Size = new System.Drawing.Size(1083, 472);
            this.dataGridView_ImportWarehouse.TabIndex = 7;
            this.dataGridView_ImportWarehouse.DoubleClick += new System.EventHandler(this.dataGridView_ImportWarehouse_DoubleClick);
            // 
            // ImportWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1083, 627);
            this.Controls.Add(this.dataGridView_ImportWarehouse);
            this.Controls.Add(this.panelImport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ImportWarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho nhập";
            this.Load += new System.EventHandler(this.ImportWarehouseForm_Load);
            this.panelImport.ResumeLayout(false);
            this.panelImport.PerformLayout();
            this.panelRadioBtn.ResumeLayout(false);
            this.panelRadioBtn.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ImportWarehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImport;
        private ButtonDesign btnRemove;
        private ButtonDesign btnEdit;
        private ButtonDesign btnSearch;
        private TextBoxDesign txtFind;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmDonHangToolStripMenuItem;
        private System.Windows.Forms.Panel panelRadioBtn;
        private RadioButtonDesign radiobtnTatCa;
        private RadioButtonDesign radiobtnDaXN;
        private RadioButtonDesign radiobtnChuaXN;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.DataGridView dataGridView_ImportWarehouse;
        private System.Windows.Forms.Label lbFind;
    }
}