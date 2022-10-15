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
    public partial class EditCarForm : Form
    {
        public EditCarForm()
        {
            InitializeComponent();
        }

        MyData myDB = new MyData();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE XE SET NhanHieu = @NH, MauSac = @Mau, Loai = @Loai," +
                "NamSX = @Nam, SoGhe = @SoGhe, GiaBan = @Gia, SoLuong = @SoLg WHERE MaXe = @MaXe", myDB.getConnection);

                cmd.Parameters.Add("@MaXe", SqlDbType.Char).Value = txtMaXe.Texts.Trim();
                cmd.Parameters.Add("@NH", SqlDbType.Char).Value = txtNhanHieu.Texts.Trim();
                cmd.Parameters.Add("@Mau", SqlDbType.NChar).Value = txtMauSac.Texts.Trim();
                cmd.Parameters.Add("@Loai", SqlDbType.NVarChar).Value = txtLoai.Texts.Trim();
                cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = txtNamSX.Texts.Trim();
                cmd.Parameters.Add("@SoGhe", SqlDbType.Int).Value = txtSoGhe.Texts.Trim();
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = txtGia.Texts.Trim();
                cmd.Parameters.Add("@SoLg", SqlDbType.Int).Value = txtSoLg.Texts.Trim();

                myDB.openConnection();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    myDB.closeConnection();
                    MessageBox.Show("Chỉnh Sửa Thành Công", "Chỉnh Sửa Thông Tin Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    myDB.closeConnection();
                    MessageBox.Show("Chỉnh Sửa Thất Bại", "Chỉnh Sửa Thông Tin Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Bạn không có quyền truy cập vào Chức Năng này!", "Chỉnh Sửa Kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEdit.Enabled = false;
                return;
            }
        }
    }
}
