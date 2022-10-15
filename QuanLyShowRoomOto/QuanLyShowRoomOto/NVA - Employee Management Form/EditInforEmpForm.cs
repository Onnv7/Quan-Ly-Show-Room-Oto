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
	public partial class EditInforEmpForm : Form
	{
		public EditInforEmpForm()
		{
			InitializeComponent();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
            var result = MessageBox.Show("Bạn có nuốn thay đổi thông tin nhân viên?", "Thay đổi thông tin nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MyData myData = new MyData();
                myData.openConnection();
                SqlCommand cmd = new SqlCommand("exec procedure_sua_nhan_vien @MaNV, @Ho, @Ten, @GioiTinh, @NgaySinh, @CMND, @Sdt, @Email, @Luong, @MaCV, @NgayVaoLam, @TrangThai", myData.getConnection);
                cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = textBoxStaffCode.Texts.ToString().Trim();
                cmd.Parameters.Add("@Ho", SqlDbType.NVarChar).Value = textBoxLastName.Texts.ToString().Trim();
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = textBoxFirstName.Texts.ToString().Trim();
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = (radioButtonFemale.Checked == true ? false : true);
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePickerBirthDate.Value;
                cmd.Parameters.Add("@CMND", SqlDbType.Char).Value = textBoxIDNumber.Texts.ToString().Trim();
                cmd.Parameters.Add("@Sdt", SqlDbType.Char).Value = textBoxNBPhone.Texts.ToString().Trim();
                cmd.Parameters.Add("@Email", SqlDbType.Char).Value = textBoxEmail.Texts.ToString().Trim();
                cmd.Parameters.Add("@Luong", SqlDbType.Int).Value = Convert.ToInt32(textBoxSalary.Texts.ToString().Trim());
                cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = getPosCode(comboBoxPosition.Text.ToString().Trim());
                cmd.Parameters.Add("@NgayVaoLam", SqlDbType.Date).Value = dateTimePickerWorkingTime.Value;
                cmd.Parameters.Add("@TrangThai", SqlDbType.Bit).Value = radioButtonOff.Checked == true ? false : true;

                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thay đổi thông tin thành công", "Thay đổi thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thay đổi thông tin thất bại", "Thay đổi thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thay đổi thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                myData.closeConnection();
            }
        }
        private string getPosCode(string posName)
        {
            MyData myData = new MyData();
            myData.openConnection();
            SqlCommand cmd = new SqlCommand("select MaCV from CHUCVU where TenCV = @TenCV", myData.getConnection);
            cmd.Parameters.Add("@TenCV", SqlDbType.NVarChar).Value = posName;
            string result;
            try
			{
                result = cmd.ExecuteScalar().ToString().Trim();
            }          
            catch(SqlException ex)
			{
                MessageBox.Show(ex.Message, "Chỉnh sửa thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
			}            
            myData.closeConnection();
            return result;

        }

		private void EditInforEmpForm_Load(object sender, EventArgs e)
		{
            textBoxStaffCode.Enabled = false;
            MyData myDB = new MyData();
            myDB.openConnection();
            SqlCommand cmd = new SqlCommand("Select TenCV from CHUCVU", myDB.getConnection);
            var rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    comboBoxPosition.Items.Add(rd["TenCV"]);
                }
            }
            myDB.closeConnection();
        }

		private void buttonCancel_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void labelAddNBPhone_Click(object sender, EventArgs e)
		{

		}
	}
}
