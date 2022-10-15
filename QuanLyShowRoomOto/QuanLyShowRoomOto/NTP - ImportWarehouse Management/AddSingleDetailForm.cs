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
    public partial class AddSingleDetailForm : Form
    {
        public AddSingleDetailForm()
        {
            InitializeComponent();
        }

        MyData myDB = new MyData();
        Order order = new Order();

        private void AddSingleDetailForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT MaXe FROM XE");

            txtMaDon.Enabled = false;

            comboBoxMaXe.DataSource = order.getDataNhapHang(cmd);
            comboBoxMaXe.DisplayMember = "MaXe";
            comboBoxMaXe.ValueMember = "MaXe";
        }
        private bool checkFormat()
        {
            if (txtSoLg.Texts.Trim() == "" || txtGiaNhap.Texts.Trim() == "")
                return false;
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            myDB.openConnection();
            SqlCommand comand = new SqlCommand("EXECUTE procedure__them_chitietnhapxe @MaDon, @MaXe, @SoLuong, @GiaNhap", myDB.getConnection);
            comand.Parameters.Add("@MaDon", SqlDbType.Char).Value = txtMaDon.Texts.Trim();
            comand.Parameters.Add("@MaXe", SqlDbType.Char).Value = comboBoxMaXe.SelectedValue.ToString().Trim();
            comand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = Convert.ToInt32(txtSoLg.Texts.ToString());
            comand.Parameters.Add("@GiaNhap", SqlDbType.Int).Value = Convert.ToInt32(txtGiaNhap.Texts.ToString());

            if (checkFormat())
            {
                try
                {
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Thêm Thành Công", "Thêm Chi Tiết Đơn Nhập Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thêm Chi Tiết Đơn Nhập Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các thông tin của Chi Tiết Đơn Hàng");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
