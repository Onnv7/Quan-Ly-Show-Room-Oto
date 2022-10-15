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
    public partial class EditOrderForm : Form
    {
        public EditOrderForm()
        {
            InitializeComponent();
        }
        MyData myDB = new MyData();
        Order order = new Order();
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool xacNhan = true;
                if (radiobtnChuaXN.Checked == true)
                    xacNhan = false;

                myDB.openConnection();

                SqlCommand cmd = new SqlCommand("UPDATE DONNHAPHANG SET NgayNhap = @NgayNhap, XacNhan = @XacNhan, NVXacNhan = @NVXacNhan WHERE MaDon = @MaDon", myDB.getConnection);
                cmd.Parameters.Add("@MaDon", SqlDbType.Char).Value = txtMaDon.Texts.ToString().Trim();
                cmd.Parameters.Add("@NgayNhap", SqlDbType.Date).Value = dateTimePickerNgayNhan.Value.ToString().Trim();
                cmd.Parameters.Add("@XacNhan", SqlDbType.Bit).Value = xacNhan;
                cmd.Parameters.Add("@NVXacNhan", SqlDbType.Char).Value = Globals.loginName;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    myDB.closeConnection();
                    MessageBox.Show("Chỉnh Sửa Thành Công", "Chỉnh Sửa Chi Tiết Đơn Nhập Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    myDB.closeConnection();
                    MessageBox.Show("Chỉnh Sửa Thất Bại", "Chỉnh Sửa Chi Tiết Đơn Nhập Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chỉnh Sửa Chi Tiết Đơn Nhập Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
