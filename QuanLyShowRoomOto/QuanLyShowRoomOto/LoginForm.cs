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
	public partial class LoginForm : Form
	{
		MyData myData = new MyData();
		public LoginForm()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			Globals.SetLoginName(textBoxUsername.Texts.ToString().Trim());
			Globals.SetPassword(textBoxPass.Texts.ToString().Trim());
			// connect cho toàn project
			//Globals.SetStrCon(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = AnT;User ID =" + Globals.loginName + "; password=" + Globals.passWord);

			//connect cho toàn project
			//Data Source=LAPTOP-A63NABPT\MINGDUC;Initial Catalog=QuanLyShowroomOto;Integrated Security=True
			Globals.SetStrCon(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyShowroomOto;User ID =" + Globals.loginName + "; password=" + Globals.passWord);

			// con cho 1 login 
			string strConn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyShowroomOto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			SqlConnection con = new SqlConnection(strConn);		
			
			SqlCommand command = new SqlCommand("SELECT * from TAIKHOAN where TenTaiKhoan = @uname and MatKhau = @pass", con);
			command.Parameters.Add("@uname", SqlDbType.Char).Value = textBoxUsername.Texts.ToString().Trim();
			command.Parameters.Add("@pass", SqlDbType.Char).Value = textBoxPass.Texts.ToString().Trim();
			con.Open();
			DataTable tb = new DataTable();
			try
			{
				tb.Load(command.ExecuteReader());

				if (tb.Rows.Count > 0)
				{
					MessageBox.Show("Đăng nhập thành công", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
					MainForm mainForm = new MainForm();
					mainForm.Show();
					mainForm.FormClosed += LoginForm_FormClosed;
					this.Hide();
				}
				else
				{
					MessageBox.Show("Sai mật khẩu hoặc tên tài khoản", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}	
			}
			catch(Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			con.Close();
        }

		private void LoginForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				MessageBox.Show("Bạn nhấn enter");
				buttonLogin_Click(null, null);
			}
		}
        private void buttonCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
			iconPictureBox1.Image = Image.FromFile("../../Images/logo.jpg");
		}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
			if (textBoxPass.PasswordChar == false)
				textBoxPass.PasswordChar = true;
			else
				textBoxPass.PasswordChar = false;
		}

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			this.Show();
        }
    }
}
