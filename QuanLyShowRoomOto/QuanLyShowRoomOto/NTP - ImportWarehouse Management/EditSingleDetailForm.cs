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
    public partial class EditSingleDetailForm : Form
    {
        public EditSingleDetailForm()
        {
            InitializeComponent();
        }
        MyData myDB = new MyData();
        Order order = new Order();

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int soLg = Convert.ToInt32(txtSoLg.Texts.ToString());
                int giaNhap = Convert.ToInt32(txtGiaNhap.Texts.ToString());

                SqlCommand cmd = new SqlCommand("UPDATE CHITIETNHAPXE SET SoLuong = @SoLuong, GiaNhap = @GiaNhap WHERE MaDon = @MaDon AND MaXe = @MaXe", myDB.getConnection);
                cmd.Parameters.Add("@MaDon", SqlDbType.Char).Value = txtMaDon.Texts.ToString().Trim();
                cmd.Parameters.Add("@MaXe", SqlDbType.Char).Value = txtMaXe.Texts.ToString().Trim();
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLg;
                cmd.Parameters.Add("@GiaNhap", SqlDbType.Int).Value = giaNhap;

                myDB.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
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
