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
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        MyData myDB = new MyData();
        Order order = new Order();

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            radiobtnChuaXN.Checked = true;
        }

        private bool checkFormat()
        {
            if (txtMaDon.Texts.Trim() == "")
                return false;
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool xacNhan = true;
            if (radiobtnChuaXN.Checked == true)
                xacNhan = false;
               
            if (checkFormat())
            {
                try
                {
                    myDB.openConnection();
                    SqlCommand comand = new SqlCommand("EXECUTE procedure__them_donnhaphang @MaDon, @NgayNhap, @XacNhan, @NVXacNhan", myDB.getConnection);
                    comand.Parameters.Add("@MaDon", SqlDbType.Char).Value = txtMaDon.Texts.Trim();
                    comand.Parameters.Add("@NgayNhap", SqlDbType.Date).Value = dateTimePickerNgayNhan.Value.ToString();
                    comand.Parameters.Add("@XacNhan", SqlDbType.Bit).Value = xacNhan;
                    comand.Parameters.Add("@NVXacNhan", SqlDbType.Char).Value = Globals.loginName;

                    comand.ExecuteNonQuery();
                    MessageBox.Show("Thêm Thành Công", "Thêm Đơn Nhập Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thêm Đơn Nhập Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các thông tin của Đơn Nhập Hàng");
            }
        }
    }
}
