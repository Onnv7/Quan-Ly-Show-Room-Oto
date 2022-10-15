
namespace QuanLyShowRoomOto
{
    partial class FormBaoDuongFirst
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
            this.comboBoxBaoDuong = new System.Windows.Forms.ComboBox();
            this.dataGridViewBaoDuong = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemBaoDuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelcount = new System.Windows.Forms.Label();
            this.btnShow = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new QuanLyShowRoomOto.TextBoxDesign();
            this.txtSDTNV = new QuanLyShowRoomOto.TextBoxDesign();
            this.txtCMNDNV = new QuanLyShowRoomOto.TextBoxDesign();
            this.txtHoTenNV = new QuanLyShowRoomOto.TextBoxDesign();
            this.btnBaoDuongHD = new QuanLyShowRoomOto.ButtonDesign();
            this.btnRefresh = new QuanLyShowRoomOto.ButtonDesign();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoDuong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxBaoDuong
            // 
            this.comboBoxBaoDuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxBaoDuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaoDuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaoDuong.FormattingEnabled = true;
            this.comboBoxBaoDuong.Location = new System.Drawing.Point(267, 51);
            this.comboBoxBaoDuong.Name = "comboBoxBaoDuong";
            this.comboBoxBaoDuong.Size = new System.Drawing.Size(149, 24);
            this.comboBoxBaoDuong.TabIndex = 150;
            // 
            // dataGridViewBaoDuong
            // 
            this.dataGridViewBaoDuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBaoDuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBaoDuong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.dataGridViewBaoDuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaoDuong.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewBaoDuong.Name = "dataGridViewBaoDuong";
            this.dataGridViewBaoDuong.Size = new System.Drawing.Size(776, 197);
            this.dataGridViewBaoDuong.TabIndex = 152;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 153;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemBaoDuongToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ThemBaoDuongToolStripMenuItem
            // 
            this.ThemBaoDuongToolStripMenuItem.Name = "ThemBaoDuongToolStripMenuItem";
            this.ThemBaoDuongToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ThemBaoDuongToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ThemBaoDuongToolStripMenuItem.Text = "Thêm Bảo Dưỡng";
            this.ThemBaoDuongToolStripMenuItem.Click += new System.EventHandler(this.ThemBaoDuongToolStripMenuItem_Click);
            // 
            // labelcount
            // 
            this.labelcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcount.Location = new System.Drawing.Point(12, 303);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(776, 37);
            this.labelcount.TabIndex = 154;
            this.labelcount.Text = "label1";
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(197)))));
            this.btnShow.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnShow.IconColor = System.Drawing.Color.Black;
            this.btnShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShow.Location = new System.Drawing.Point(12, 343);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(179, 37);
            this.btnShow.TabIndex = 155;
            this.btnShow.Text = "Show Thông Tin Nhân Viên";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 160;
            this.label1.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 161;
            this.label2.Text = "CMND:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(393, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 162;
            this.label3.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(393, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 163;
            this.label4.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(465, 449);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(261, 36);
            this.txtEmail.TabIndex = 159;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSDTNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtSDTNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtSDTNV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSDTNV.BorderSize = 2;
            this.txtSDTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNV.ForeColor = System.Drawing.Color.Black;
            this.txtSDTNV.Location = new System.Drawing.Point(465, 387);
            this.txtSDTNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDTNV.Multiline = false;
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Padding = new System.Windows.Forms.Padding(7);
            this.txtSDTNV.PasswordChar = false;
            this.txtSDTNV.Size = new System.Drawing.Size(261, 36);
            this.txtSDTNV.TabIndex = 158;
            this.txtSDTNV.Texts = "";
            this.txtSDTNV.UnderlinedStyle = false;
            // 
            // txtCMNDNV
            // 
            this.txtCMNDNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCMNDNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtCMNDNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtCMNDNV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCMNDNV.BorderSize = 2;
            this.txtCMNDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDNV.ForeColor = System.Drawing.Color.Black;
            this.txtCMNDNV.Location = new System.Drawing.Point(95, 449);
            this.txtCMNDNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMNDNV.Multiline = false;
            this.txtCMNDNV.Name = "txtCMNDNV";
            this.txtCMNDNV.Padding = new System.Windows.Forms.Padding(7);
            this.txtCMNDNV.PasswordChar = false;
            this.txtCMNDNV.Size = new System.Drawing.Size(261, 36);
            this.txtCMNDNV.TabIndex = 157;
            this.txtCMNDNV.Texts = "";
            this.txtCMNDNV.UnderlinedStyle = false;
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHoTenNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTenNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtHoTenNV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHoTenNV.BorderSize = 2;
            this.txtHoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtHoTenNV.Location = new System.Drawing.Point(95, 387);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenNV.Multiline = false;
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Padding = new System.Windows.Forms.Padding(7);
            this.txtHoTenNV.PasswordChar = false;
            this.txtHoTenNV.Size = new System.Drawing.Size(261, 36);
            this.txtHoTenNV.TabIndex = 156;
            this.txtHoTenNV.Texts = "";
            this.txtHoTenNV.UnderlinedStyle = false;
            // 
            // btnBaoDuongHD
            // 
            this.btnBaoDuongHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBaoDuongHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
            this.btnBaoDuongHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
            this.btnBaoDuongHD.BorderColor = System.Drawing.Color.Black;
            this.btnBaoDuongHD.BorderRadius = 18;
            this.btnBaoDuongHD.BorderSize = 1;
            this.btnBaoDuongHD.FlatAppearance.BorderSize = 0;
            this.btnBaoDuongHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoDuongHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoDuongHD.ForeColor = System.Drawing.Color.Black;
            this.btnBaoDuongHD.Location = new System.Drawing.Point(73, 41);
            this.btnBaoDuongHD.Name = "btnBaoDuongHD";
            this.btnBaoDuongHD.Size = new System.Drawing.Size(170, 40);
            this.btnBaoDuongHD.TabIndex = 151;
            this.btnBaoDuongHD.Text = "Bảo Dưỡng Cho HD:";
            this.btnBaoDuongHD.TextColor = System.Drawing.Color.Black;
            this.btnBaoDuongHD.UseVisualStyleBackColor = false;
            this.btnBaoDuongHD.Click += new System.EventHandler(this.btnBaoDuongHD_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(73)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(73)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.BorderRadius = 18;
            this.btnRefresh.BorderSize = 1;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(596, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(170, 40);
            this.btnRefresh.TabIndex = 164;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.Black;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormBaoDuongFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDTNV);
            this.Controls.Add(this.txtCMNDNV);
            this.Controls.Add(this.txtHoTenNV);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewBaoDuong);
            this.Controls.Add(this.btnBaoDuongHD);
            this.Controls.Add(this.comboBoxBaoDuong);
            this.Name = "FormBaoDuongFirst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảo dưỡng";
            this.Load += new System.EventHandler(this.FormBaoDuongFirst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoDuong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonDesign btnBaoDuongHD;
        public System.Windows.Forms.ComboBox comboBoxBaoDuong;
        private System.Windows.Forms.DataGridView dataGridViewBaoDuong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemBaoDuongToolStripMenuItem;
        private System.Windows.Forms.Label labelcount;
        private FontAwesome.Sharp.IconButton btnShow;
        private TextBoxDesign txtHoTenNV;
        private TextBoxDesign txtCMNDNV;
        private TextBoxDesign txtSDTNV;
        private TextBoxDesign txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ButtonDesign btnRefresh;
    }
}