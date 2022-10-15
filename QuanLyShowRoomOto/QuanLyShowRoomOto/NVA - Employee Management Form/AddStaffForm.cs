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
	public partial class AddStaffForm : Form
	{
		public AddStaffForm()
		{
			InitializeComponent();
		}
        MyData myDB = new MyData();
		private void AddStaffForm_Load(object sender, EventArgs e)
		{
            myDB.openConnection();
            SqlCommand cmd = new SqlCommand("Select TenCV from CHUCVU", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable rd = new DataTable();
            //rd = null;

            try
            {
                //rd.Load(cmd.ExecuteReader());
                adapter.Fill(rd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (rd.Rows.Count > 0)
            {
                int i = 0;
                while (i < rd.Rows.Count)
                {
                    comboBoxAddPosition.Items.Add(rd.Rows[i].ItemArray[0].ToString().Trim());
                    i++;
                }
            }
            myDB.closeConnection();
        }

		private void buttonAdd_Click(object sender, EventArgs e)
		{
            if (checkFormat() == true)
            {
                MyData myDB = new MyData();
                myDB.openConnection();
                SqlCommand cmd = new SqlCommand("execute procedure_them_nhan_vien @MaNV, @Ho, @Ten, @GioiTinh, @NgaySinh, @CMND, @SDT, @Email, @Luong, @MaCV, @NgayVaoLam", myDB.getConnection);
                cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = textBoxAddStaffCode.Texts.Trim();
                cmd.Parameters.Add("@Ho", SqlDbType.NChar).Value = textBoxAddLastName.Texts.Trim();
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = textBoxAddName.Texts.Trim();
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = (radioButtonFemale.Checked == true ? 0 : 1);
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePickerBirthDate.Value;
                cmd.Parameters.Add("@CMND", SqlDbType.Char).Value = textBoxAddIDNumber.Texts.Trim();
                cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = textBoxAddNBPhone.Texts.Trim();
                cmd.Parameters.Add("@Email", SqlDbType.Char).Value = textBoxAddEmail.Texts.Trim();
                cmd.Parameters.Add("@Luong", SqlDbType.Int).Value = Int32.Parse(textBoxAddSalary.Texts);

                SqlCommand cmdId = new SqlCommand("Select * from NHANVIEN where MaNV =" + "'" + textBoxAddStaffCode.Texts.Trim() + "'", myDB.getConnection);
                DataTable tbID = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmdId);
                adapter.Fill(tbID);
                if (tbID.Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SqlCommand cmdTenCV = new SqlCommand("Select MaCV from CHUCVU where TenCV = @TenCV", myDB.getConnection);
                cmdTenCV.Parameters.Add("@TenCV", SqlDbType.NVarChar).Value = comboBoxAddPosition.SelectedItem.ToString().Trim();
                string MaCV = "";
                try
                {
                    MaCV = cmdTenCV.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thực thi dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (MaCV == "")
                    return;
                cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = MaCV;
                cmd.Parameters.Add("@NgayVaoLam", SqlDbType.Date).Value = dateTimePickerAddWorkingTime.Value;
                //   cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Không được để trống thông tin", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool checkFormat()
        {
            if (textBoxAddStaffCode.Texts.Trim() == "" ||
                textBoxAddLastName.Texts.Trim() == "" ||
                textBoxAddName.Texts.Trim() == "" ||
                (radioButtonFemale.Checked == false && radioButtonMale.Checked == false) ||
                dateTimePickerBirthDate.Value == null ||
                textBoxAddIDNumber.Texts.Trim() == "" ||
                textBoxAddNBPhone.Texts.Trim() == "" ||
                textBoxAddSalary.Texts.Trim() == "" ||
                dateTimePickerAddWorkingTime.Value == null||
                comboBoxAddPosition.Text.Trim() == "")
                return false;
            return true;
        }

		private void buttonCancel_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
