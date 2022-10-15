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
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }
		public string chucVu;
		MyData myData = new MyData();
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
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

        private void buttonResetPass_Click(object sender, EventArgs e)
        {
			if (textBoxRePass.Texts != textBoxPass.Texts)
			{
				MessageBox.Show("Xác nhận mật khẩu không hợp lệ", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
					MessageBox.Show("Đổi mật khẩu tài khoản thành công", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Lỗi Đổi mật khẩu", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi Đổi mật khẩu: " + ex.Message, "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			myData.closeConnection();
		}
    }
}
