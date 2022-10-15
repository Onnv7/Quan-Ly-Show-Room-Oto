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

namespace QuanLyShowRoomOto
{
	public partial class CarSoldForm : Form
	{
		MyData myData = new MyData();
		DataTable tb = new DataTable();
		public CarSoldForm()
		{
			InitializeComponent();
		}

		private void buttonCheck_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn năm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int year = Convert.ToInt32(comboBox1.SelectedItem.ToString());

			string sqlString = "select * from dbo.function_bang_quan_ly_ban_xe(" + year + ")";
			fillChart(sqlString);

			chart1.Series[0].XValueMember = "Thang";
			chart1.Series[0].YValueMembers = "SoLuong";
			chart1.Titles[0].Text = "Biểu đồ số lượng hợp đồng ở mỗi tháng của năm " + year;
		}
		private void fillChart(string sqlString)
		{
			myData.openConnection();
			SqlCommand cmd = new SqlCommand(sqlString, myData.getConnection);
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			tb.Clear();
			adp.Fill(tb);
			chart1.DataSource = tb;
			myData.closeConnection();
		}

		private void CarSoldForm_Load(object sender, EventArgs e)
		{
			DateTime time1 = DateTime.Now;
			myData.openConnection();
			int year = time1.Year;

			string sqlString = "select * from dbo.function_bang_quan_ly_ban_xe(" + year + ")";
			fillChart(sqlString);

			chart1.Series[0].XValueMember = "Thang";
			chart1.Series[0].YValueMembers = "SoLuong";
			chart1.Titles.Add("Biểu đồ số lượng hợp đồng ở mỗi tháng của năm " + year);
		}
	}
}
