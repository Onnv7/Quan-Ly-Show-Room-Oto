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
	public partial class RegisterForm : Form
	{
		public string chucVu;
		MyData myData = new MyData();
		public RegisterForm()
		{
			InitializeComponent();
		}
		private string getRole(string chucVu)
		{
			if (chucVu == "Quản lý")
				return "QL";
			if (chucVu == "Quản kho")
				return "NVQK";
			if (chucVu == "Nhân viên bán hàng")
				return "NVBH";
			if (chucVu == "Nhân viên bảo dưỡng")
				return "NVBD";
			if (chucVu == "Thu ngân")
				return "NVTT";
			return null;
		}	
		private void buttonRegister_Click(object sender, EventArgs e)
		{
			if(textBoxRePass.Texts != textBoxPass.Texts)
			{
				MessageBox.Show("Xác nhận mật khẩu không hợp lệ", "Đăng ký tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			myData.openConnection();
			SqlCommand cmd = new SqlCommand("exec tao_login @loginname, @pass, @username, @role", myData.getConnection);
			cmd.Parameters.Add("@loginname", SqlDbType.Char).Value = textBoxUsername.Texts.Trim();
			cmd.Parameters.Add("@pass", SqlDbType.Char).Value = textBoxPass.Texts.Trim();
			cmd.Parameters.Add("@username", SqlDbType.Char).Value = textBoxUsername.Texts.Trim();
			cmd.Parameters.Add("@role", SqlDbType.Char).Value = getRole(chucVu);
			try
			{
				if (cmd.ExecuteNonQuery() > 0)
					MessageBox.Show("Đăng ký tài khoản thành công", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Lỗi đăng ký", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch(Exception ex)
			{
				MessageBox.Show("Lỗi đăng ký: " + ex.Message, "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			myData.closeConnection();
		}

        private void buttonCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
