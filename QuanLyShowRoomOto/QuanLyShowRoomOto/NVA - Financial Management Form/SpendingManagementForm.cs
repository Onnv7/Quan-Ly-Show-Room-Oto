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
	public partial class SpendingManagementForm : Form
	{
		MyData myData = new MyData();
		DataTable tb = new DataTable();
		public SpendingManagementForm()
		{
			InitializeComponent();
		}

		private void SpendingManagementForm_Load(object sender, EventArgs e)
		{
			string sqlString = "select * from vw_Tien_Chi";
			fillChart(sqlString);
			int unpaid;
			int paid;
			if (tb.Rows.Count == 0)
			{
				unpaid = 0;
				paid = 0;
			}
			else
			{
				unpaid = Convert.ToInt32(tb.Rows[0].ItemArray[1]);
				paid = Convert.ToInt32(tb.Rows[1].ItemArray[1]);
			}
			 

			chartSpendingManagement.Series[0].XValueMember = "TrangThai";
			chartSpendingManagement.Series[0].YValueMembers = "Tien";
			chartSpendingManagement.Titles.Add("Biểu đồ quản lý chi");

			labelPaid.Text = "Chưa thanh toán: " + unpaid;
			labelUnpaid.Text = "Đã thanh toán: " + paid;
		}
		private void fillChart(string sqlString)
		{
			myData.openConnection();
			SqlCommand cmd = new SqlCommand(sqlString, myData.getConnection);
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			tb.Clear();
			adp.Fill(tb);
			chartSpendingManagement.DataSource = tb;
			myData.closeConnection();
		}
	}
}
