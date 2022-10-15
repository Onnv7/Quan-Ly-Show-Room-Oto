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
	public partial class EmployeeLeaveForm : Form
	{
		MyData myData = new MyData();
		public EmployeeLeaveForm()
		{
			InitializeComponent();
		}

		private void EmployeeLeaveForm_Load(object sender, EventArgs e)
		{
			DataTable tb = new DataTable();
			myData.openConnection();
			SqlCommand cmd = new SqlCommand("select * from vw_nhan_vien_da_nghi_viec", myData.getConnection);
			try
			{
				tb.Load(cmd.ExecuteReader());
				dataGridViewEmployeeLeave.DataSource = tb;
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				myData.closeConnection();
				return;
			}
			myData.closeConnection();
		}
	}
}
