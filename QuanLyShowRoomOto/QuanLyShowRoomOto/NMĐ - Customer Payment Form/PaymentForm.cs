using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShowRoomOto.Forms
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần thanh toán ở bảng bên dưới", "Thanh toán hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maGD = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bool phuongthucthanhtoan = radioButtonCard.Checked ? true : false;
            DateTime time = dateTimePicker1.Value;
            //string maNV = comboBoxStaff.SelectedValue.ToString();
            string maNV = Globals.loginName;
            MyData myDB = new MyData();
            myDB.openConnection();
            SqlCommand command = new SqlCommand("execute procedure_thanh_toan_hop_dong @phuongthucthanhtoan,@time, @maNV ,@maGD ", myDB.getConnection);
            command.Parameters.Add("@phuongthucthanhtoan", SqlDbType.Bit).Value = phuongthucthanhtoan;
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = time;
            command.Parameters.Add("@maNV", SqlDbType.VarChar).Value = maNV;
            command.Parameters.Add("@maGD", SqlDbType.VarChar).Value = maGD;
            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thanh Toán Hợp Đồng Thành Công", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Refresh
                    SqlCommand command1 = new SqlCommand("select * from vw_Thanh_Toan_Hop_Dong_Chua_Xac_Nhan", myDB.getConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command1);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Thanh Toán Hợp Đồng Thất Bại", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        DataTable initialcomboBoxStaff()
        {
            MyData myDB = new MyData();

            SqlCommand command = new SqlCommand("execute procedure_chon_nhan_vien_thu_ngan", myDB.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(Globals.loginName);
                //comboBoxStaff.DataSource = initialcomboBoxStaff();
                //comboBoxStaff.DisplayMember = "MaNV";
                //comboBoxStaff.ValueMember = "MaNV";
                labelStaff.Text = Globals.loginName;
                MyData myDB = new MyData();
                SqlCommand command = new SqlCommand("select * from vw_Thanh_Toan_Hop_Dong_Chua_Xac_Nhan", myDB.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns[0].HeaderText = "Mã Giao Dịch";
                dataGridView1.Columns[1].HeaderText = "Mã Hợp Đồng";
                dataGridView1.Columns[2].HeaderText = "Họ Và Tên";
                dataGridView1.Columns[3].HeaderText = "Số Tiền Giao Dịch";
                dataGridView1.Columns[4].HeaderText = "Hạn Chót";
            }
            catch
            {
                MessageBox.Show("Lỗi: Bạn không có quyền truy cập vào thông tin Thanh Toán!", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void buttonFindCustomer_Click(object sender, EventArgs e)
        {
            string name = textBoxFindCustomer.Text.Trim();
            MyData myDB = new MyData();
            SqlCommand command = new SqlCommand("select * from vw_Thanh_Toan_Hop_Dong_Chua_Xac_Nhan Where HoTen LIKE N'%" + name + "%'", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Mã Giao Dịch";
            dataGridView1.Columns[1].HeaderText = "Mã Hợp Đồng";
            dataGridView1.Columns[2].HeaderText = "Họ Và Tên";
            dataGridView1.Columns[3].HeaderText = "Số Tiền Giao Dịch";
            dataGridView1.Columns[4].HeaderText = "Hạn Chót";
        }

        private void buttonFindContract_Click(object sender, EventArgs e)
        {
            string maHD = textBoxFindContract.Text.Trim();
            MyData myDB = new MyData();
            SqlCommand command = new SqlCommand("select * from vw_Thanh_Toan_Hop_Dong_Chua_Xac_Nhan WHERE MaHD = @maHD", myDB.getConnection);
            command.Parameters.Add("@maHD", SqlDbType.VarChar).Value = maHD;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Mã Giao Dịch";
            dataGridView1.Columns[1].HeaderText = "Mã Hợp Đồng";
            dataGridView1.Columns[2].HeaderText = "Họ Và Tên";
            dataGridView1.Columns[3].HeaderText = "Số Tiền Giao Dịch";
            dataGridView1.Columns[4].HeaderText = "Hạn Chót";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyData myDB = new MyData();
            SqlCommand command = new SqlCommand("select * from vw_Thanh_Toan_Hop_Dong_Qua_Han", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Mã Giao Dịch";
            dataGridView1.Columns[1].HeaderText = "Mã Hợp Đồng";
            dataGridView1.Columns[2].HeaderText = "Họ Và Tên";
            dataGridView1.Columns[3].HeaderText = "Số Tiền Giao Dịch";
            dataGridView1.Columns[4].HeaderText = "Hạn Chót";
        }
    }
}
