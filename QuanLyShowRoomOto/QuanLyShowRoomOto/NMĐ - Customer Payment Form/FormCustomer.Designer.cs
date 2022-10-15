
namespace QuanLyShowRoomOto.Forms
{
    partial class FormCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFindTop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFindCustomer = new System.Windows.Forms.Button();
            this.textBoxFindCustomer = new System.Windows.Forms.TextBox();
            this.labelSumCustomer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCustomerList = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKháchHàngVàXeĐãMuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngChiPhíThanhToánCủaKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinThanhToánHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonPayment);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxPayment);
            this.panel1.Controls.Add(this.buttonCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxCount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonFindTop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxTop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonFindCustomer);
            this.panel1.Controls.Add(this.textBoxFindCustomer);
            this.panel1.Controls.Add(this.labelSumCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 130);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(541, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tìm khách hàng:";
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(187)))), ((int)(((byte)(250)))));
            this.buttonPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayment.Location = new System.Drawing.Point(1063, 56);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(49, 24);
            this.buttonPayment.TabIndex = 13;
            this.buttonPayment.Text = "🔍";
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(541, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thông tin thanh toán của khách hàng:";
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPayment.Location = new System.Drawing.Point(839, 58);
            this.textBoxPayment.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(204, 22);
            this.textBoxPayment.TabIndex = 11;
            // 
            // buttonCount
            // 
            this.buttonCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(187)))), ((int)(((byte)(250)))));
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCount.Location = new System.Drawing.Point(448, 17);
            this.buttonCount.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(49, 24);
            this.buttonCount.TabIndex = 10;
            this.buttonCount.Text = "🔍";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Khách hàng mua ít nhất";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCount.Location = new System.Drawing.Point(234, 19);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(48, 22);
            this.textBoxCount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(300, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "xe để nhận ưu đãi";
            // 
            // buttonFindTop
            // 
            this.buttonFindTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(187)))), ((int)(((byte)(250)))));
            this.buttonFindTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindTop.Location = new System.Drawing.Point(408, 59);
            this.buttonFindTop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFindTop.Name = "buttonFindTop";
            this.buttonFindTop.Size = new System.Drawing.Size(49, 24);
            this.buttonFindTop.TabIndex = 6;
            this.buttonFindTop.Text = "🔍";
            this.buttonFindTop.UseVisualStyleBackColor = false;
            this.buttonFindTop.Click += new System.EventHandler(this.buttonFindTop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(168, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "khách hàng mua nhiều xe nhất";
            // 
            // textBoxTop
            // 
            this.textBoxTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTop.Location = new System.Drawing.Point(102, 65);
            this.textBoxTop.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTop.Name = "textBoxTop";
            this.textBoxTop.Size = new System.Drawing.Size(48, 22);
            this.textBoxTop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top: ";
            // 
            // buttonFindCustomer
            // 
            this.buttonFindCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(187)))), ((int)(((byte)(250)))));
            this.buttonFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindCustomer.Location = new System.Drawing.Point(872, 15);
            this.buttonFindCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFindCustomer.Name = "buttonFindCustomer";
            this.buttonFindCustomer.Size = new System.Drawing.Size(76, 24);
            this.buttonFindCustomer.TabIndex = 2;
            this.buttonFindCustomer.Text = "🔍";
            this.buttonFindCustomer.UseVisualStyleBackColor = false;
            this.buttonFindCustomer.Click += new System.EventHandler(this.buttonFindCustomer_Click);
            // 
            // textBoxFindCustomer
            // 
            this.textBoxFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindCustomer.Location = new System.Drawing.Point(670, 16);
            this.textBoxFindCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFindCustomer.Name = "textBoxFindCustomer";
            this.textBoxFindCustomer.Size = new System.Drawing.Size(188, 22);
            this.textBoxFindCustomer.TabIndex = 1;
            // 
            // labelSumCustomer
            // 
            this.labelSumCustomer.AutoSize = true;
            this.labelSumCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.labelSumCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumCustomer.ForeColor = System.Drawing.Color.Black;
            this.labelSumCustomer.Location = new System.Drawing.Point(882, 97);
            this.labelSumCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSumCustomer.Name = "labelSumCustomer";
            this.labelSumCustomer.Size = new System.Drawing.Size(161, 20);
            this.labelSumCustomer.TabIndex = 0;
            this.labelSumCustomer.Text = "Tổng số khách hàng: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCustomerList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 381);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewCustomerList
            // 
            this.dataGridViewCustomerList.AllowUserToAddRows = false;
            this.dataGridViewCustomerList.AllowUserToDeleteRows = false;
            this.dataGridViewCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.dataGridViewCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomerList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomerList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCustomerList.Name = "dataGridViewCustomerList";
            this.dataGridViewCustomerList.ReadOnly = true;
            this.dataGridViewCustomerList.RowHeadersWidth = 51;
            this.dataGridViewCustomerList.RowTemplate.Height = 24;
            this.dataGridViewCustomerList.Size = new System.Drawing.Size(1156, 381);
            this.dataGridViewCustomerList.TabIndex = 0;
            this.dataGridViewCustomerList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaffList_CellContentDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânKháchHàngToolStripMenuItem,
            this.thôngTinKháchHàngVàXeĐãMuaToolStripMenuItem,
            this.tổngChiPhíThanhToánCủaKháchHàngToolStripMenuItem,
            this.thanhToánHợpĐồngToolStripMenuItem,
            this.thôngTinThanhToánHợpĐồngToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // thôngTinCáNhânKháchHàngToolStripMenuItem
            // 
            this.thôngTinCáNhânKháchHàngToolStripMenuItem.Name = "thôngTinCáNhânKháchHàngToolStripMenuItem";
            this.thôngTinCáNhânKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.thôngTinCáNhânKháchHàngToolStripMenuItem.Text = "Thông tin cá nhân khách hàng";
            this.thôngTinCáNhânKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânKháchHàngToolStripMenuItem_Click);
            // 
            // thôngTinKháchHàngVàXeĐãMuaToolStripMenuItem
            // 
            this.thôngTinKháchHàngVàXeĐãMuaToolStripMenuItem.Name = "thôngTinKháchHàngVàXeĐãMuaToolStripMenuItem";
            this.thôngTinKháchHàngVàXeĐãMuaToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.thôngTinKháchHàngVàXeĐãMuaToolStripMenuItem.Text = "Thông tin khách hàng và xe đã mua";
            this.thôngTinKháchHàngVàXeĐãMuaToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngVàXeĐãMuaToolStripMenuItem_Click);
            // 
            // tổngChiPhíThanhToánCủaKháchHàngToolStripMenuItem
            // 
            this.tổngChiPhíThanhToánCủaKháchHàngToolStripMenuItem.Name = "tổngChiPhíThanhToánCủaKháchHàngToolStripMenuItem";
            this.tổngChiPhíThanhToánCủaKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.tổngChiPhíThanhToánCủaKháchHàngToolStripMenuItem.Text = "Tổng chi phí thanh toán của khách hàng";
            this.tổngChiPhíThanhToánCủaKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.tổngChiPhíThanhToánCủaKháchHàngToolStripMenuItem_Click);
            // 
            // thanhToánHợpĐồngToolStripMenuItem
            // 
            this.thanhToánHợpĐồngToolStripMenuItem.Name = "thanhToánHợpĐồngToolStripMenuItem";
            this.thanhToánHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.thanhToánHợpĐồngToolStripMenuItem.Text = "Thanh toán hợp đồng";
            this.thanhToánHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.thanhToánHợpĐồngToolStripMenuItem_Click);
            // 
            // thôngTinThanhToánHợpĐồngToolStripMenuItem
            // 
            this.thôngTinThanhToánHợpĐồngToolStripMenuItem.Name = "thôngTinThanhToánHợpĐồngToolStripMenuItem";
            this.thôngTinThanhToánHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.thôngTinThanhToánHợpĐồngToolStripMenuItem.Text = "Thông tin thanh toán hợp đồng";
            this.thôngTinThanhToánHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinThanhToánHợpĐồngToolStripMenuItem_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1156, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dataGridViewCustomerList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label labelSumCustomer;
        private System.Windows.Forms.Button buttonFindCustomer;
        public System.Windows.Forms.TextBox textBoxFindCustomer;
        private System.Windows.Forms.Button buttonFindTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngVàXeĐãMuaToolStripMenuItem;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.ToolStripMenuItem tổngChiPhíThanhToánCủaKháchHàngToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem thanhToánHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinThanhToánHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânKháchHàngToolStripMenuItem;
    }
}