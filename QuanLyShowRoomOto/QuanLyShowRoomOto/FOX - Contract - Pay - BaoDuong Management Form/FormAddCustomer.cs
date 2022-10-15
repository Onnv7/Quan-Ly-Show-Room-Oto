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
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkFormat() == true)
            {
                MyData myDB = new MyData();
                myDB.openConnection();
                //SqlCommand cmd = new SqlCommand("execute procedure__them_khachhang (@MaKH, @HoTen, @GioiTinh, @NgaySinh, @CMND, @SDT, @NgheNghiep, @DiaChi", myDB.getConnection);
                SqlCommand cmd = new SqlCommand("exec procedure__them_khachhang @MaKH, @HoTen, @GioiTinh, @NgaySinh, @CMND, @SDT, @NgheNghiep, @DiaChi", myDB.getConnection);
                cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = txtMaKH.Texts.Trim();
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txtFullName.Texts.Trim();
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = (radioButtonFemale.Checked == true ? 0 : 1);
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePickerBirthDate.Value;
                cmd.Parameters.Add("@CMND", SqlDbType.Char).Value = txtCMND.Texts.Trim();
                cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = txtPhone.Texts.Trim();
                cmd.Parameters.Add("@NgheNghiep", SqlDbType.NVarChar).Value = txtJob.Texts.Trim();
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtAddrs.Texts.Trim();
                //   cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                myDB.closeConnection();
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }
        private bool checkFormat()
        {
            if (txtMaKH.Texts.Trim() == "" ||
                txtFullName.Texts.Trim() == "" ||
                txtJob.Texts.Trim() == "" ||
                (radioButtonFemale.Checked == false && radioButtonMale.Checked == false) ||
                dateTimePickerBirthDate.Value == null ||
                txtCMND.Texts.Trim() == "" ||
                txtPhone.Texts.Trim() == "" ||
                txtAddrs.Texts.Trim() == "")
                return false;
            return true;
        }
        private void buttonDesign1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void dateTimePickerBirthDate_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
