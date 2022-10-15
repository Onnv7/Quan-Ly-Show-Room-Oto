using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShowRoomOto
{
	public partial class PositionListForm : Form
	{
		Position position = new Position();
		string oldPos = "";
		public PositionListForm()
		{
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void PositionListForm_Load(object sender, EventArgs e)
		{
			MyData myDB = new MyData();
			try
			{ 
				dataGridViewListPos.DataSource = myDB.getData("select * from vw_Chuc_vu");
			}	
			catch(Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Chức vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				myDB.closeConnection();
				return;
			}

			dataGridViewListPos.AllowUserToDeleteRows = false;
			dataGridViewListPos.AllowUserToAddRows = false;
			for (int i = 0; i < dataGridViewListPos.Columns.Count; i++)
				dataGridViewListPos.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

			dataGridViewListPos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridViewListPos.Columns[0].HeaderText = "Mã chức vụ";
			dataGridViewListPos.Columns[1].HeaderText = "Chức vụ";
			dataGridViewListPos.Columns[2].HeaderText = "Số lượng nhân viên";
		}

		

		
		private void fillData()
		{
			MyData myDB = new MyData();
			dataGridViewListPos.DataSource = myDB.getData("select * from vw_Chuc_vu");
		}

		
	}
}
