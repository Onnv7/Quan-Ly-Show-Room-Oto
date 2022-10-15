
namespace QuanLyShowRoomOto
{
	partial class StaffRankingsByQuantityForm
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.dataGridViewStaffTop = new System.Windows.Forms.DataGridView();
            this.panelFunct = new System.Windows.Forms.Panel();
            this.buttonThisMonth = new QuanLyShowRoomOto.ButtonDesign();
            this.buttonThisWeek = new QuanLyShowRoomOto.ButtonDesign();
            this.buttonCheck = new QuanLyShowRoomOto.ButtonDesign();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.labelOr = new System.Windows.Forms.Label();
            this.numericUpDownTop = new System.Windows.Forms.NumericUpDown();
            this.labelTopStaff = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffTop)).BeginInit();
            this.panelFunct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTop)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dataGridViewStaffTop);
            this.panelContent.Controls.Add(this.panelFunct);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1174, 613);
            this.panelContent.TabIndex = 6;
            // 
            // dataGridViewStaffTop
            // 
            this.dataGridViewStaffTop.AllowUserToAddRows = false;
            this.dataGridViewStaffTop.AllowUserToDeleteRows = false;
            this.dataGridViewStaffTop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStaffTop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.dataGridViewStaffTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStaffTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaffTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStaffTop.Location = new System.Drawing.Point(0, 170);
            this.dataGridViewStaffTop.Name = "dataGridViewStaffTop";
            this.dataGridViewStaffTop.RowHeadersWidth = 51;
            this.dataGridViewStaffTop.Size = new System.Drawing.Size(1174, 443);
            this.dataGridViewStaffTop.TabIndex = 0;
            // 
            // panelFunct
            // 
            this.panelFunct.Controls.Add(this.buttonThisMonth);
            this.panelFunct.Controls.Add(this.buttonThisWeek);
            this.panelFunct.Controls.Add(this.buttonCheck);
            this.panelFunct.Controls.Add(this.labelCount);
            this.panelFunct.Controls.Add(this.labelTotal);
            this.panelFunct.Controls.Add(this.checkBoxAll);
            this.panelFunct.Controls.Add(this.labelOr);
            this.panelFunct.Controls.Add(this.numericUpDownTop);
            this.panelFunct.Controls.Add(this.labelTopStaff);
            this.panelFunct.Controls.Add(this.labelTo);
            this.panelFunct.Controls.Add(this.labelTime);
            this.panelFunct.Controls.Add(this.dateTimePickerTo);
            this.panelFunct.Controls.Add(this.dateTimePickerFrom);
            this.panelFunct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFunct.Location = new System.Drawing.Point(0, 0);
            this.panelFunct.Name = "panelFunct";
            this.panelFunct.Size = new System.Drawing.Size(1174, 170);
            this.panelFunct.TabIndex = 1;
            // 
            // buttonThisMonth
            // 
            this.buttonThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.buttonThisMonth.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.buttonThisMonth.BorderColor = System.Drawing.Color.Black;
            this.buttonThisMonth.BorderRadius = 18;
            this.buttonThisMonth.BorderSize = 1;
            this.buttonThisMonth.FlatAppearance.BorderSize = 0;
            this.buttonThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThisMonth.ForeColor = System.Drawing.Color.Black;
            this.buttonThisMonth.Location = new System.Drawing.Point(928, 86);
            this.buttonThisMonth.Name = "buttonThisMonth";
            this.buttonThisMonth.Size = new System.Drawing.Size(150, 40);
            this.buttonThisMonth.TabIndex = 17;
            this.buttonThisMonth.Text = "Tháng này";
            this.buttonThisMonth.TextColor = System.Drawing.Color.Black;
            this.buttonThisMonth.UseVisualStyleBackColor = false;
            this.buttonThisMonth.Click += new System.EventHandler(this.buttonThisMonth_Click);
            // 
            // buttonThisWeek
            // 
            this.buttonThisWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(73)))));
            this.buttonThisWeek.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(73)))));
            this.buttonThisWeek.BorderColor = System.Drawing.Color.Black;
            this.buttonThisWeek.BorderRadius = 18;
            this.buttonThisWeek.BorderSize = 1;
            this.buttonThisWeek.FlatAppearance.BorderSize = 0;
            this.buttonThisWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThisWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThisWeek.ForeColor = System.Drawing.Color.Black;
            this.buttonThisWeek.Location = new System.Drawing.Point(761, 88);
            this.buttonThisWeek.Name = "buttonThisWeek";
            this.buttonThisWeek.Size = new System.Drawing.Size(150, 40);
            this.buttonThisWeek.TabIndex = 16;
            this.buttonThisWeek.Text = "Tuần này";
            this.buttonThisWeek.TextColor = System.Drawing.Color.Black;
            this.buttonThisWeek.UseVisualStyleBackColor = false;
            this.buttonThisWeek.Click += new System.EventHandler(this.buttonThisWeek_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCheck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCheck.BorderColor = System.Drawing.Color.Black;
            this.buttonCheck.BorderRadius = 18;
            this.buttonCheck.BorderSize = 1;
            this.buttonCheck.FlatAppearance.BorderSize = 0;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.Black;
            this.buttonCheck.Location = new System.Drawing.Point(595, 88);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(150, 40);
            this.buttonCheck.TabIndex = 15;
            this.buttonCheck.Text = "Kiểm tra";
            this.buttonCheck.TextColor = System.Drawing.Color.Black;
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(185, 130);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 16);
            this.labelCount.TabIndex = 14;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(171)))));
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(11, 140);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(151, 18);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "Tổng số nhân viên:";
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAll.Location = new System.Drawing.Point(322, 87);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(65, 20);
            this.checkBoxAll.TabIndex = 12;
            this.checkBoxAll.Text = "Tất cả";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOr.Location = new System.Drawing.Point(251, 88);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(38, 16);
            this.labelOr.TabIndex = 11;
            this.labelOr.Text = "hoặc";
            // 
            // numericUpDownTop
            // 
            this.numericUpDownTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTop.Location = new System.Drawing.Point(111, 86);
            this.numericUpDownTop.Name = "numericUpDownTop";
            this.numericUpDownTop.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTop.TabIndex = 10;
            this.numericUpDownTop.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelTopStaff
            // 
            this.labelTopStaff.AutoSize = true;
            this.labelTopStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopStaff.Location = new System.Drawing.Point(30, 88);
            this.labelTopStaff.Name = "labelTopStaff";
            this.labelTopStaff.Size = new System.Drawing.Size(36, 16);
            this.labelTopStaff.TabIndex = 8;
            this.labelTopStaff.Text = "Top:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(340, 22);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(31, 16);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "đến";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(30, 21);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(90, 16);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Mốc thời gian:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(427, 16);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(199, 22);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(137, 16);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(155, 22);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(208)))), ((int)(((byte)(234)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1174, 100);
            this.panelTitle.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(93)))));
            this.labelTitle.Location = new System.Drawing.Point(261, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(662, 37);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Bảng xếp hạng nhân viên theo số lượng xe";
            // 
            // StaffRankingsByQuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1174, 713);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitle);
            this.Name = "StaffRankingsByQuantityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffRankingsByQuantityForm";
            this.Load += new System.EventHandler(this.StaffRankingsByQuantityForm_Load);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffTop)).EndInit();
            this.panelFunct.ResumeLayout(false);
            this.panelFunct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTop)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelContent;
		private System.Windows.Forms.DataGridView dataGridViewStaffTop;
		private System.Windows.Forms.Panel panelFunct;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.CheckBox checkBoxAll;
		private System.Windows.Forms.Label labelOr;
		private System.Windows.Forms.NumericUpDown numericUpDownTop;
		private System.Windows.Forms.Label labelTopStaff;
		private System.Windows.Forms.Label labelTo;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.DateTimePicker dateTimePickerTo;
		private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label labelTitle;
		private ButtonDesign buttonThisMonth;
		private ButtonDesign buttonThisWeek;
		private ButtonDesign buttonCheck;
	}
}