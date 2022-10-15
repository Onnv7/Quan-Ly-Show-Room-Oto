using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyShowRoomOto
{
	public partial class RevenueForm : Form
	{
		MyData myData = new MyData();
		DataTable tb = new DataTable();
		public RevenueForm()
		{
			InitializeComponent();
		}

		private void RevenueForm_Load(object sender, EventArgs e)
		{
			string sqlString = "select * from dbo.bang_thu_nhap()";
			SqlCommand cmd = new SqlCommand(sqlString);
			try
			{
				fillChart(cmd);
			}	
			catch(Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Doanh thu", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Enabled = false;
				return;
			}
			
			int revenue = Convert.ToInt32(tb.Rows[0].ItemArray[1]);
			int expenditure = Convert.ToInt32(tb.Rows[1].ItemArray[1]);
			int total = revenue + expenditure;

			chartRevenue.Series[0].XValueMember = "MucTieu";
			chartRevenue.Series[0].YValueMembers = "Tien";
			chartRevenue.Titles.Add("Biểu đồ thể tiện thu - chi");

			labelRevenue.Text = "Thu: " + revenue;
			labelExpenditure.Text = "Chi: " + expenditure;
			labelProfit.Text = "Lợi nhuận: " + (revenue - expenditure);
		}

		private void buttonCheck_Click(object sender, EventArgs e)
		{
			if (checkComboBox() == false)
			{
				MessageBox.Show("Vui lòng chọn mốc thời gian", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DateTime time1 = new DateTime();
			DateTime time2 = new DateTime();

			time1 = Convert.ToDateTime(comboBoxYear.SelectedItem.ToString() + "/" + comboBoxMonth.SelectedItem.ToString() + "/1");
			time2 = Convert.ToDateTime(getDayOfMonth(comboBoxYear.SelectedItem.ToString(), comboBoxMonth.SelectedItem.ToString()));


			SqlCommand cmd = new SqlCommand("select * from dbo.bang_thu_nhap_theo_khoang_thoi_gian(@time1, @time2)", myData.getConnection);
			cmd.Parameters.Add("@time1", SqlDbType.Date).Value = time1;
			cmd.Parameters.Add("@time2", SqlDbType.Date).Value = time2;
			fillChart(cmd);

			int revenue = Convert.ToInt32(tb.Rows[0].ItemArray[1]);
			int expenditure = Convert.ToInt32(tb.Rows[1].ItemArray[1]);
			int total = revenue + expenditure;

			chartRevenue.Series[0].XValueMember = "MucTieu";
			chartRevenue.Series[0].YValueMembers = "Tien";

			fillInfoChart(revenue, expenditure, time1.ToString("dd/MM/yyyy"), time2.ToString("dd/MM/yyyy"));
		}

		private void buttonDesignRefresh_Click(object sender, EventArgs e)
		{
			string sqlString = "select * from dbo.bang_thu_nhap()";
			SqlCommand cmd = new SqlCommand(sqlString);
			fillChart(cmd);
			int revenue = Convert.ToInt32(tb.Rows[0].ItemArray[1]);
			int expenditure = Convert.ToInt32(tb.Rows[1].ItemArray[1]);
			int total = revenue + expenditure;

			chartRevenue.Series[0].ChartType = SeriesChartType.Column;
			chartRevenue.Series[0].XValueMember = "MucTieu";
			chartRevenue.Series[0].YValueMembers = "Tien";
			chartRevenue.Titles[0].Text = "Biểu đồ thể tiện thu - chi";

			labelRevenue.Text = "Thu: " + revenue;
			labelExpenditure.Text = "Chi: " + expenditure;
			labelProfit.Text = "Lợi nhuận: " + (revenue - expenditure);
		}

		private void buttonSwapChart_Click(object sender, EventArgs e)
		{
			int revenue = Convert.ToInt32(tb.Rows[0].ItemArray[1]);
			int expenditure = Convert.ToInt32(tb.Rows[1].ItemArray[1]);
			int total = revenue + expenditure;

			string sqlString = "select * from dbo.bang_thu_nhap()";
			SqlCommand cmd = new SqlCommand(sqlString);
			fillChart(cmd);

			chartRevenue.Series[0].XValueMember = "MucTieu";
			chartRevenue.Series[0].YValueMembers = "Tien";

			if (chartRevenue.Series[0].ChartType == SeriesChartType.Column)
			{
				chartRevenue.Series[0].ChartType = SeriesChartType.Pie;
				if(total == 0)
				{
					labelRevenue.Text = "Tổng tỉ lệ thu: " + "KHÔNG CÓ DỮ LIỆU";
					labelExpenditure.Text = "Tổng tỉ lệ chi: " + "KHÔNG CÓ DỮ LIỆU";
				}	
				else
				{
					labelRevenue.Text = "Tổng tỉ lệ thu: " + (revenue * 100 / total).ToString("0.00") + "%";
					labelExpenditure.Text = "Tổng tỉ lệ chi: " + (expenditure * 100 / total).ToString("0.00") + "%";
				}	
				labelProfit.Text = "";
				chartRevenue.Series[0].Points[0].Color = Color.FromArgb(156, 51, 188);
				chartRevenue.Series[0].Points[1].Color = Color.FromArgb(255, 122, 94);
				chartRevenue.Titles[0].Text = "Biểu đồ tỉ lệ thu - chi";
			}
			else if (chartRevenue.Series[0].ChartType == SeriesChartType.Pie)
			{
				chartRevenue.Series[0].ChartType = SeriesChartType.Column;
				labelRevenue.Text = "Thu: " + revenue;
				labelExpenditure.Text = "Chi: " + expenditure;
				labelProfit.Text = "Lợi nhuận: " + (revenue - expenditure);
				chartRevenue.Titles[0].Text = "Biểu đồ thể tiện thu - chi";

			}
		}
		private void fillChart(SqlCommand cmd)
		{
			myData.openConnection();
			cmd.Connection = myData.getConnection;
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			tb.Clear();
			adp.Fill(tb);
			chartRevenue.DataSource = tb;
			myData.closeConnection();
		}
		private string getDayOfMonth(string year, string month)
		{
			int m = Convert.ToInt32(month);
			int y = Convert.ToInt32(year);
			switch (m)
			{
				// các tháng 1, 3, 5, 7, 8, 10 và 12 có 31 ngày.
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					return year + "/" + month + "/31";
					break;

				// các tháng 4, 6, 9 và 11 có 30 ngày
				case 4:
				case 6:
				case 9:
				case 11:
					return year + "/" + month + "/30";
					break;

				// Riêng tháng 2 nếu là năm nhuận thì có 29 ngày, còn không thì có 28 ngày.
				case 2:
					if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
					{
						return year + "/" + month + "/29";
					}
					else
					{
						return year + "/" + month + "/28";
					}
					break;
			}
			return null;
		}
		private void fillInfoChart(int revenue, int expenditure, string time1, string time2)
		{
			int total = revenue + expenditure;
			if (chartRevenue.Series[0].ChartType == SeriesChartType.Pie)
			{
				if (total == 0)
				{
					labelRevenue.Text = "Tổng tỉ lệ thu: " + "KHÔNG CÓ DỮ LIỆU";
					labelExpenditure.Text = "Tổng tỉ lệ chi: " + "KHÔNG CÓ DỮ LIỆU";
				}
				else
				{
					labelRevenue.Text = "Tổng tỉ lệ thu: " + (revenue * 100 / total).ToString("0.00") + "%";
					labelExpenditure.Text = "Tổng tỉ lệ chi: " + (expenditure * 100 / total).ToString("0.00") + "%";
				}
				labelProfit.Text = "";
				chartRevenue.Series[0].Points[0].Color = Color.FromArgb(156, 51, 188);
				chartRevenue.Series[0].Points[1].Color = Color.FromArgb(255, 122, 94);
				chartRevenue.Titles[0].Text = "Biểu đồ tỉ lệ thu - chi từ " + time1 + " đến " + time2;
			}
			else if (chartRevenue.Series[0].ChartType == SeriesChartType.Column)
			{
				labelRevenue.Text = "Thu: " + revenue;
				labelExpenditure.Text = "Chi: " + expenditure;
				labelProfit.Text = "Lợi nhuận: " + (revenue - expenditure);
				chartRevenue.Titles[0].Text = "Biểu đồ thể tiện thu - chi từ " + time1 + " đến " + time2;

			}
		}
		private bool checkComboBox()
		{
			if (comboBoxMonth.SelectedItem == null || comboBoxYear.SelectedItem == null)
				return false;
			return true;
		}

		private void thuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			IncomeManagementForm incomeManagementForm = new IncomeManagementForm();
			incomeManagementForm.Show();
		}

		private void chiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SpendingManagementForm spendingManagementForm = new SpendingManagementForm();
			spendingManagementForm.Show();
		}

		private void thốngKêLượngXeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CarSoldForm carSoldForm = new CarSoldForm();
			carSoldForm.Show();
		}
	}
}
