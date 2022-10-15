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
    public partial class FormAddBaoDuong : Form
    {
        public FormAddBaoDuong()
        {
            InitializeComponent();
        }
        MyData myDB = new MyData();
        Contract contract = new Contract();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (checkFormat())
            {
                myDB.openConnection();
                SqlCommand cmd = new SqlCommand("exec procedure__them_baoduong @MaHD, @NgayBD, @NVXacNhan", myDB.getConnection);
                cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = txtMaHD.Texts.Trim();
                cmd.Parameters.Add("@NgayBD", SqlDbType.Date).Value = dateTimePickerDayPay.Value;
                cmd.Parameters.Add("@NVXacNhan", SqlDbType.Char).Value = Globals.loginName;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Them thanh cong");
                    Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                myDB.closeConnection();
            }
            else
            {
                MessageBox.Show("Khong duoc de trong");
            }

        }
        
        private void FormAddBaoDuong_Load(object sender, EventArgs e)
        {
            
        }
        private bool checkFormat()
        {
            if (txtMaHD.Texts.Trim() == "" ||
                dateTimePickerDayPay.Value == null)
                return false;
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
