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
	public partial class StaffRankingsByQuantityForm : Form
	{
		Employee employee = new Employee();
		MyData myData = new MyData();
		public StaffRankingsByQuantityForm()
		{
			InitializeComponent();
		}
		private void fillGrid(DateTime time1, DateTime time2)
		{
			int top;
			if (checkBoxAll.Checked == true)
			{
				top = employee.countEmp(getPosCode());
			}
			else
				top = Convert.ToInt32(numericUpDownTop.Value);
			myData.openConnection();
			string sqlStr = "exec procdure_top_nhan_vien_ban_xe_theo_so_luong @time1, @time2, @top";
			SqlCommand cmd = new SqlCommand(sqlStr, myData.getConnection);
			cmd.Parameters.Add("@time1", SqlDbType.Date).Value = time1;
			cmd.Parameters.Add("@time2", SqlDbType.Date).Value = time2;
			cmd.Parameters.Add("@top", SqlDbType.Int).Value = top;
			DataTable tb = new DataTable();
			try
			{
				tb.Load(cmd.ExecuteReader());
				dataGridViewStaffTop.DataSource = tb;

				dataGridViewStaffTop.Columns[0].HeaderText = "Mã nhân viên";
				dataGridViewStaffTop.Columns[1].HeaderText = "Họ tên";
				dataGridViewStaffTop.Columns[2].HeaderText = "Số xe đã bán";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				myData.closeConnection();
				return;
			}

			
			labelTotal.Text = "Tổng số nhân viên: " + dataGridViewStaffTop.Rows.Count.ToString().Trim();

			myData.closeConnection();
		}
		private void StaffRankingsByQuantityForm_Load(object sender, EventArgs e)
		{
			DateTime time1 = DateTime.Now.Date.AddDays(-7);
			DateTime time2 = DateTime.Now.Date;
			fillGrid(time1, time2);

			dataGridViewStaffTop.AllowUserToDeleteRows = false;
			dataGridViewStaffTop.AllowUserToAddRows = false;
			for (int i = 0; i < dataGridViewStaffTop.Columns.Count; i++)
				dataGridViewStaffTop.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
		}
		private string getPosCode()
		{
			myData.openConnection();
			string rs = "";
			SqlCommand cmd = new SqlCommand("select dbo.function_lay_ma_nhan_vien_ban_xe()", myData.getConnection);
			try
			{
				rs = cmd.ExecuteScalar().ToString().Trim();
			}
			catch (Exception ex)
			{

			}
			myData.closeConnection();
			return rs;
		}

		private void buttonCheck_Click(object sender, EventArgs e)
		{
			DateTime time1 = Convert.ToDateTime(dateTimePickerFrom.Value.ToString());
			DateTime time2 = Convert.ToDateTime(dateTimePickerTo.Value.ToString());

			fillGrid(time1, time2);
		}

		private void buttonThisWeek_Click(object sender, EventArgs e)
		{
			DateTime time1 = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek + 1);
			DateTime time2 = DateTime.Now.Date;
			dateTimePickerFrom.Value = time1;
			dateTimePickerTo.Value = time2;
			fillGrid(time1, time2);
		}

		private void buttonThisMonth_Click(object sender, EventArgs e)
		{
			DateTime time1 = DateTime.Now.Date.AddDays(-(int)DateTime.Now.Day + 1);
			DateTime time2 = DateTime.Now.Date;
			dateTimePickerFrom.Value = time1;
			dateTimePickerTo.Value = time2;
			fillGrid(time1, time2);
		}

		private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxAll.Checked == true)
				numericUpDownTop.Enabled = false;
			else
				numericUpDownTop.Enabled = true;
		}
	}
}
