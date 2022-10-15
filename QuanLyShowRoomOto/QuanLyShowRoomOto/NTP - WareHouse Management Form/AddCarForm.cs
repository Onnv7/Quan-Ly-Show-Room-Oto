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
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        MyData myDB = new MyData();

        private bool checkFormat()
        {
            if (txtMaXe.Texts.Trim() == "" ||
                txtNhanHieu.Texts.Trim() == "" ||
                txtMauSac.Texts.Trim() == "" ||
                txtGia.Texts.Trim() == "" ||
                txtLoai.Texts.Trim() == "" ||
                txtSoGhe.Texts.Trim() == "" ||
                txtSoLg.Texts.Trim() == "" ||
                txtNamSX.Texts.Trim() == "")
                return false;
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myDB.openConnection();
            SqlCommand comand = new SqlCommand("EXECUTE procedure__them_xe @MaXe, @NhanHieu, @MauSac, @Loai, @NamSX, @SoGhe, @GiaBan, @SoLuong", myDB.getConnection);
            
            comand.Parameters.Add("@MaXe", SqlDbType.Char).Value = txtMaXe.Texts.Trim();
            comand.Parameters.Add("NhanHieu", SqlDbType.Char).Value = txtNhanHieu.Texts.Trim();
            comand.Parameters.Add("@MauSac", SqlDbType.NChar).Value = txtMauSac.Texts.Trim();
            comand.Parameters.Add("@Loai", SqlDbType.NVarChar).Value = txtLoai.Texts.Trim();
            comand.Parameters.Add("@NamSX", SqlDbType.Int).Value = txtNamSX.Texts.Trim();
            comand.Parameters.Add("@SoGhe", SqlDbType.Int).Value = txtSoGhe.Texts.Trim();
            comand.Parameters.Add("@GiaBan", SqlDbType.Int).Value = txtGia.Texts.Trim();
            comand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = txtSoLg.Texts.Trim();

            if (checkFormat())
            {
                try
                {
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Thêm Thành Công", "Thêm Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "Thêm Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng không được để trống các thông tin của Xe");
            }
        }
    }
}
