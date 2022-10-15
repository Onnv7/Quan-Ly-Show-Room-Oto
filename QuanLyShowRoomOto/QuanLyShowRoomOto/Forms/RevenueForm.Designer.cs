
namespace QuanLyShowRoomOto
{
	partial class RevenueForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSwapChart = new QuanLyShowRoomOto.ButtonDesign();
            this.buttonDesignRefresh = new QuanLyShowRoomOto.ButtonDesign();
            this.buttonCheck = new QuanLyShowRoomOto.ButtonDesign();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.labelProfit = new System.Windows.Forms.Label();
            this.labelExpenditure = new System.Windows.Forms.Label();
            this.labelRevenue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêLượngXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 652);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonSwapChart);
            this.panel1.Controls.Add(this.buttonDesignRefresh);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.labelMonth);
            this.panel1.Controls.Add(this.labelYear);
            this.panel1.Controls.Add(this.comboBoxMonth);
            this.panel1.Controls.Add(this.comboBoxYear);
            this.panel1.Controls.Add(this.labelProfit);
            this.panel1.Controls.Add(this.labelExpenditure);
            this.panel1.Controls.Add(this.labelRevenue);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(693, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 634);
            this.panel1.TabIndex = 13;
            // 
            // buttonSwapChart
            // 
            this.buttonSwapChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSwapChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(197)))));
            this.buttonSwapChart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(197)))));
            this.buttonSwapChart.BorderColor = System.Drawing.Color.Black;
            this.buttonSwapChart.BorderRadius = 18;
            this.buttonSwapChart.BorderSize = 1;
            this.buttonSwapChart.FlatAppearance.BorderSize = 0;
            this.buttonSwapChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwapChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwapChart.ForeColor = System.Drawing.Color.Black;
            this.buttonSwapChart.Location = new System.Drawing.Point(207, 477);
            this.buttonSwapChart.Name = "buttonSwapChart";
            this.buttonSwapChart.Size = new System.Drawing.Size(150, 40);
            this.buttonSwapChart.TabIndex = 12;
            this.buttonSwapChart.Text = "Chuyển biểu đồ";
            this.buttonSwapChart.TextColor = System.Drawing.Color.Black;
            this.buttonSwapChart.UseVisualStyleBackColor = false;
            this.buttonSwapChart.Click += new System.EventHandler(this.buttonSwapChart_Click);
            // 
            // buttonDesignRefresh
            // 
            this.buttonDesignRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDesignRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(73)))));
            this.buttonDesignRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(73)))));
            this.buttonDesignRefresh.BorderColor = System.Drawing.Color.Black;
            this.buttonDesignRefresh.BorderRadius = 18;
            this.buttonDesignRefresh.BorderSize = 1;
            this.buttonDesignRefresh.FlatAppearance.BorderSize = 0;
            this.buttonDesignRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesignRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesignRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonDesignRefresh.Location = new System.Drawing.Point(25, 477);
            this.buttonDesignRefresh.Name = "buttonDesignRefresh";
            this.buttonDesignRefresh.Size = new System.Drawing.Size(150, 40);
            this.buttonDesignRefresh.TabIndex = 11;
            this.buttonDesignRefresh.Text = "Làm mới";
            this.buttonDesignRefresh.TextColor = System.Drawing.Color.Black;
            this.buttonDesignRefresh.UseVisualStyleBackColor = false;
            this.buttonDesignRefresh.Click += new System.EventHandler(this.buttonDesignRefresh_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
            this.buttonCheck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
            this.buttonCheck.BorderColor = System.Drawing.Color.Black;
            this.buttonCheck.BorderRadius = 18;
            this.buttonCheck.BorderSize = 1;
            this.buttonCheck.FlatAppearance.BorderSize = 0;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.Black;
            this.buttonCheck.Location = new System.Drawing.Point(118, 391);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(150, 40);
            this.buttonCheck.TabIndex = 10;
            this.buttonCheck.Text = "Kiểm tra";
            this.buttonCheck.TextColor = System.Drawing.Color.Black;
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelMonth
            // 
            this.labelMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.Location = new System.Drawing.Point(187, 299);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(50, 16);
            this.labelMonth.TabIndex = 9;
            this.labelMonth.Text = "Tháng:";
            // 
            // labelYear
            // 
            this.labelYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(3, 299);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(40, 16);
            this.labelYear.TabIndex = 8;
            this.labelYear.Text = "Năm:";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(236, 296);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMonth.TabIndex = 7;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.comboBoxYear.Location = new System.Drawing.Point(49, 296);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYear.TabIndex = 6;
            // 
            // labelProfit
            // 
            this.labelProfit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfit.AutoSize = true;
            this.labelProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelProfit.Location = new System.Drawing.Point(70, 172);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(0, 20);
            this.labelProfit.TabIndex = 5;
            // 
            // labelExpenditure
            // 
            this.labelExpenditure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExpenditure.AutoSize = true;
            this.labelExpenditure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpenditure.Location = new System.Drawing.Point(70, 98);
            this.labelExpenditure.Name = "labelExpenditure";
            this.labelExpenditure.Size = new System.Drawing.Size(0, 20);
            this.labelExpenditure.TabIndex = 4;
            // 
            // labelRevenue
            // 
            this.labelRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRevenue.AutoSize = true;
            this.labelRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevenue.Location = new System.Drawing.Point(70, 41);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new System.Drawing.Size(0, 20);
            this.labelRevenue.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.chartRevenue);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 651);
            this.panel3.TabIndex = 4;
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(0, 0);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tiền (đv: triệu đồng)";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(667, 651);
            this.chartRevenue.TabIndex = 0;
            this.chartRevenue.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuToolStripMenuItem,
            this.chiToolStripMenuItem,
            this.thốngKêLượngXeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1083, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thuToolStripMenuItem
            // 
            this.thuToolStripMenuItem.Name = "thuToolStripMenuItem";
            this.thuToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.thuToolStripMenuItem.Text = "Thu";
            this.thuToolStripMenuItem.Click += new System.EventHandler(this.thuToolStripMenuItem_Click);
            // 
            // chiToolStripMenuItem
            // 
            this.chiToolStripMenuItem.Name = "chiToolStripMenuItem";
            this.chiToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.chiToolStripMenuItem.Text = "Chi";
            this.chiToolStripMenuItem.Click += new System.EventHandler(this.chiToolStripMenuItem_Click);
            // 
            // thốngKêLượngXeToolStripMenuItem
            // 
            this.thốngKêLượngXeToolStripMenuItem.Name = "thốngKêLượngXeToolStripMenuItem";
            this.thốngKêLượngXeToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.thốngKêLượngXeToolStripMenuItem.Text = "Thống kê lượng xe bán ra";
            this.thốngKêLượngXeToolStripMenuItem.Click += new System.EventHandler(this.thốngKêLượngXeToolStripMenuItem_Click);
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RevenueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.RevenueForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelMonth;
		private System.Windows.Forms.Label labelYear;
		private System.Windows.Forms.ComboBox comboBoxMonth;
		private System.Windows.Forms.ComboBox comboBoxYear;
		private System.Windows.Forms.Label labelProfit;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label labelExpenditure;
		private System.Windows.Forms.Label labelRevenue;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem thuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chiToolStripMenuItem;
		private ButtonDesign buttonSwapChart;
		private ButtonDesign buttonDesignRefresh;
		private ButtonDesign buttonCheck;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem thốngKêLượngXeToolStripMenuItem;
	}
}