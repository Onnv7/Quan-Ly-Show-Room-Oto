using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShowRoomOto.Forms
{
    public partial class FormUpdateDeleteCustomer : Form
    {

        public FormUpdateDeleteCustomer()
        {
            InitializeComponent();
        }


        //private void buttonAdd_Click(object sender, EventArgs e)
        //{
        //    if (checkFormat() == true)
        //    {
        //        MyData myDB = new MyData();
        //        myDB.openConnection();
        //        //SqlCommand cmd = new SqlCommand("execute procedure__them_khachhang (@MaKH, @HoTen, @GioiTinh, @NgaySinh, @CMND, @SDT, @NgheNghiep, @DiaChi", myDB.getConnection);
        //        SqlCommand cmd = new SqlCommand("insert into KHACHHANG(MaKH, HoTen, GioiTinh, NgaySinh, CMND, SDT, NgheNghiep, DiaChi) values(@MaKH, @HoTen, @GioiTinh, @NgaySinh, @CMND, @SDT, @NgheNghiep, @DiaChi)", myDB.getConnection);
        //        cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = textBoxAddCustomerCode.Texts.Trim();
        //        cmd.Parameters.Add("@HoTen", SqlDbType.Char).Value = textBoxAddFullName.Texts.Trim();
        //        cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = (radioButtonFemale.Checked == true ? 0 : 1);
        //        cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePickerBirthDate.Value;
        //        cmd.Parameters.Add("@CMND", SqlDbType.Char).Value = textBoxAddIDNumber.Texts.Trim();
        //        cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = textBoxAddNBPhone.Texts.Trim();
        //        cmd.Parameters.Add("@NgheNghiep", SqlDbType.NChar).Value = textBoxJob.Texts.Trim();
        //        cmd.Parameters.Add("@DiaChi", SqlDbType.NChar).Value = textBoxAddress.Texts.Trim();
        //     //   cmd.CommandType = CommandType.StoredProcedure;
        //        try
        //        {
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Them thanh cong");
        //        }    
        //        catch(SqlException ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }


        //    }
        //    else
        //        MessageBox.Show("Khong duoc de trong");
        //}

        private bool checkFormat()
        {
            if (textBoxAddCustomerCode.Texts.Trim() == "" ||
                textBoxAddFullName.Texts.Trim() == "" ||
                textBoxJob.Texts.Trim() == "" ||
                (radioButtonFemale.Checked == false && radioButtonMale.Checked == false) ||
                dateTimePickerBirthDate.Value == null ||
                textBoxAddIDNumber.Texts.Trim() == "" ||
                textBoxAddNBPhone.Texts.Trim() == "" ||
                textBoxAddress.Texts.Trim() == "")
                return false;
            return true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MyData myDB = new MyData();
            myDB.openConnection();
            //insert into KHACHHANG(MaKH, HoTen, GioiTinh, NgaySinh, CMND, SDT, NgheNghiep, DiaChi)
            if (checkFormat() == true)
            {
                //SqlCommand cmd = new SqlCommand("UPDATE KHACHHANG set HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, CMND = @CMND, SDT = @SDT, NgheNghiep = @NgheNghiep, DiaChi = @DiaChi WHERE MaKH = @MaKH", myDB.getConnection);
                SqlCommand cmd = new SqlCommand("execute procedure_sua_khach_hang @MaKH, @HoTen, @GioiTinh, @NgaySinh, @CMND, @SDT, @NgheNghiep, @DiaChi ", myDB.getConnection);
                cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = textBoxAddCustomerCode.Texts.Trim();
                cmd.Parameters.Add("@HoTen", SqlDbType.NChar).Value = textBoxAddFullName.Texts.Trim();
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = (radioButtonFemale.Checked == true ? 0 : 1);
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePickerBirthDate.Value;
                cmd.Parameters.Add("@CMND", SqlDbType.Char).Value = textBoxAddIDNumber.Texts.Trim();
                cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = textBoxAddNBPhone.Texts.Trim();
                cmd.Parameters.Add("@NgheNghiep", SqlDbType.NChar).Value = textBoxJob.Texts.Trim();
                cmd.Parameters.Add("@DiaChi", SqlDbType.NChar).Value = textBoxAddress.Texts.Trim();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cap nhat thanh cong");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Cap nhat that bai");
                }
                myDB.closeConnection();

            }
            else
                MessageBox.Show("Khong duoc de trong");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MyData mydb = new MyData();
            SqlCommand cmd = new SqlCommand("execute procedure_xoa_khach_hang @MaKH", mydb.getConnection);

            cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = textBoxAddCustomerCode.Texts.Trim();
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                mydb.closeConnection();
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
