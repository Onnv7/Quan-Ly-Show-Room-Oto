
namespace QuanLyShowRoomOto
{
	partial class SpendingManagementForm
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
            this.labelUnpaid = new System.Windows.Forms.Label();
            this.labelPaid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartSpendingManagement = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpendingManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUnpaid
            // 
            this.labelUnpaid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnpaid.AutoSize = true;
            this.labelUnpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnpaid.Location = new System.Drawing.Point(752, 369);
            this.labelUnpaid.Name = "labelUnpaid";
            this.labelUnpaid.Size = new System.Drawing.Size(51, 20);
            this.labelUnpaid.TabIndex = 6;
            this.labelUnpaid.Text = "label2";
            // 
            // labelPaid
            // 
            this.labelPaid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPaid.AutoSize = true;
            this.labelPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaid.Location = new System.Drawing.Point(752, 209);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(51, 20);
            this.labelPaid.TabIndex = 5;
            this.labelPaid.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chartSpendingManagement);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 660);
            this.panel1.TabIndex = 4;
            // 
            // chartSpendingManagement
            // 
            this.chartSpendingManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            chartArea1.Name = "ChartArea1";
            this.chartSpendingManagement.ChartAreas.Add(chartArea1);
            this.chartSpendingManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSpendingManagement.Legends.Add(legend1);
            this.chartSpendingManagement.Location = new System.Drawing.Point(0, 0);
            this.chartSpendingManagement.Name = "chartSpendingManagement";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tiền (đv: triệu vnđ)";
            this.chartSpendingManagement.Series.Add(series1);
            this.chartSpendingManagement.Size = new System.Drawing.Size(672, 660);
            this.chartSpendingManagement.TabIndex = 0;
            this.chartSpendingManagement.Text = "chart1";
            // 
            // SpendingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1042, 675);
            this.Controls.Add(this.labelUnpaid);
            this.Controls.Add(this.labelPaid);
            this.Controls.Add(this.panel1);
            this.Name = "SpendingManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi";
            this.Load += new System.EventHandler(this.SpendingManagementForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpendingManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelUnpaid;
		private System.Windows.Forms.Label labelPaid;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartSpendingManagement;
	}
}