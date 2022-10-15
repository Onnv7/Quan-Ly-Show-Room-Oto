using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyShowRoomOto.Forms
{
    public partial class FormCustomer : Form
    {
        private Form childForm;


        MyData myDB = new MyData();
        public FormCustomer()
        {
            InitializeComponent();
        }

        //private void iconButtonAddStaff_Click(object sender, EventArgs e)
        //{
        //    FormAddStaff formAddStaff = new FormAddStaff();
        //    childForm = formAddStaff;
        //    childForm.Show();
        //}
        public void FormCustomer_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable tb = new DataTable();
                tb = myDB.getData("select * from vw_Quan_Ly_KH");

                dataGridViewCustomerList.DataSource = tb;
                dataGridViewCustomerList.AllowUserToDeleteRows = false;
                dataGridViewCustomerList.AllowUserToAddRows = false;
                dataGridViewCustomerList.Columns[0].HeaderText = "Mã Khách Hàng";
                dataGridViewCustomerList.Columns[1].HeaderText = "Họ Và Tên";
                dataGridViewCustomerList.Columns[2].HeaderText = "Giới Tính";
                dataGridViewCustomerList.Columns[3].HeaderText = "Ngày Sinh";
                dataGridViewCustomerList.Columns[4].HeaderText = "CMND";
                dataGridViewCustomerList.Columns[5].HeaderText = "Số Điện Thoại";
                dataGridViewCustomerList.Columns[6].HeaderText = "Nghề Nghiệp";
                dataGridViewCustomerList.Columns[7].HeaderText = "Địa Chỉ";
                myDB.openConnection();
                SqlCommand command = new SqlCommand("execute procedure_so_luong_khach_hang", myDB.getConnection);
                string count = "0";
                try
                {
                    count = command.ExecuteScalar().ToString().Trim();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                labelSumCustomer.Text = "Tổng số khách hàng: " + count;
                myDB.closeConnection();
            }
            catch
            {
                MessageBox.Show("Lỗi: Bạn không có quyền truy cập vào thông tin của Khách Hàng!", "Kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = false;
                return;
            }
        }
        private void buttonFindTop_Click(object sender, EventArgs e)
        {
            MyData myDB = new MyData();
            myDB.openConnection();
            DataTable tb = new DataTable();
            string top = textBoxTop.Text.Trim();
            SqlCommand commandSL = new SqlCommand("execute procedure_so_luong_khach_hang", myDB.getConnection);
            if (top.Equals("") || int.TryParse(top, out int _) == false)
            {
                top = commandSL.ExecuteScalar().ToString().Trim();
            }
            SqlCommand commandTop = new SqlCommand("select * from function_top_khach_hang_mua_xe(@top)", myDB.getConnection);
            commandTop.Parameters.Add("@top", SqlDbType.Int).Value = int.Parse(top);
            tb.Load(commandTop.ExecuteReader());
            dataGridViewCustomerList.DataSource = tb;
            dataGridViewCustomerList.AllowUserToDeleteRows = false;
            dataGridViewCustomerList.AllowUserToAddRows = false;
            dataGridViewCustomerList.Columns[0].HeaderText = "Mã Khách Hàng";
            dataGridViewCustomerList.Columns[1].HeaderText = "Họ Và Tên";
            dataGridViewCustomerList.Columns[2].HeaderText = "Số Lượng Xe Đã Mua";
        }
        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddCustomer formAddCustomer = new FormAddCustomer();
            formAddCustomer.Show();
        }

        private void dataGridViewStaffList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormUpdateDeleteCustomer formUpdateDeleteCustomer = new FormUpdateDeleteCustomer();
            formUpdateDeleteCustomer.textBoxAddCustomerCode.Texts = dataGridViewCustomerList.CurrentRow.Cells[0].Value.ToString().Trim();
            formUpdateDeleteCustomer.textBoxAddFullName.Texts = dataGridViewCustomerList.CurrentRow.Cells[1].Value.ToString().Trim();
            if (dataGridViewCustomerList.CurrentRow.Cells[2].Value.ToString() == "False")
            {
                formUpdateDeleteCustomer.radioButtonFemale.Checked = true;
            }
            else
            {
                formUpdateDeleteCustomer.radioButtonMale.Checked = true;
            }
            formUpdateDeleteCustomer.dateTimePickerBirthDate.Value = (DateTime)dataGridViewCustomerList.CurrentRow.Cells[3].Value;
            formUpdateDeleteCustomer.textBoxAddIDNumber.Texts = dataGridViewCustomerList.CurrentRow.Cells[4].Value.ToString().Trim();
            formUpdateDeleteCustomer.textBoxAddNBPhone.Texts = dataGridViewCustomerList.CurrentRow.Cells[5].Value.ToString().Trim();
            formUpdateDeleteCustomer.textBoxJob.Texts = dataGridViewCustomerList.CurrentRow.Cells[6].Value.ToString().Trim();
            formUpdateDeleteCustomer.textBoxAddress.Texts = dataGridViewCustomerList.CurrentRow.Cells[7].Value.ToString().Trim();
            formUpdateDeleteCustomer.FormClosed += FormCustomer_Load;
            formUpdateDeleteCustomer.ShowDialog();

        }

        private void buttonFindCustomer_Click(object sender, EventArgs e)
        {
            MyData myDB = new MyData();
            myDB.openConnection();
            SqlCommand command = new SqlCommand("execute procedure_tim_kiem_khach_hang_bang_thong_tin @thongTin", myDB.getConnection);
            command.Parameters.Add("@thongtin", SqlDbType.NVarChar).Value = textBoxFindCustomer.Text.Trim();
            DataTable table = new DataTable();
            try
            {
                table.Load(command.ExecuteReader());
                dataGridViewCustomerList.DataSource = table;
                dataGridViewCustomerList.Columns[0].HeaderText = "Mã Khách Hàng";
                dataGridViewCustomerList.Columns[1].HeaderText = "Họ Và Tên";
                dataGridViewCustomerList.Columns[2].HeaderText = "Giới Tính";
                dataGridViewCustomerList.Columns[3].HeaderText = "Ngày Sinh";
                dataGridViewCustomerList.Columns[4].HeaderText = "CMND";
                dataGridViewCustomerList.Columns[5].HeaderText = "Số Điện Thoại";
                dataGridViewCustomerList.Columns[6].HeaderText = "Nghề Nghiệp";
                dataGridViewCustomerList.Columns[7].HeaderText = "Địa Chỉ";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SomeThing Went Wrong");
            }


        }

        private void buttonCount_Click(object sender, EventArgs e)
        {

            MyData myDB = new MyData();
            myDB.openConnection();
            DataTable tb = new DataTable();
            string count = textBoxCount.Text.Trim();
            if (count.Equals("") || int.TryParse(count, out int _) == false)
            {
                count = "1";
            }
            SqlCommand commandTop = new SqlCommand("select * from function_so_khach_hang_mua_xe_tren_sl(@count)", myDB.getConnection);
            commandTop.Parameters.Add("@count", SqlDbType.Int).Value = int.Parse(count);
            tb.Load(commandTop.ExecuteReader());
            dataGridViewCustomerList.DataSource = tb;
            dataGridViewCustomerList.AllowUserToDeleteRows = false;
            dataGridViewCustomerList.AllowUserToAddRows = false;
            dataGridViewCustomerList.Columns[0].HeaderText = "Mã Khách Hàng";
            dataGridViewCustomerList.Columns[1].HeaderText = "Họ Và Tên";
            dataGridViewCustomerList.Columns[2].HeaderText = "Số Lượng Xe Đã Mua";
        }

        private void thôngTinKháchHàngVàXeĐãMuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyData myDB = new MyData();
            SqlCommand command = new SqlCommand("execute procedure_khach_hang_va_xe", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewCustomerList.DataSource = table;
            dataGridViewCustomerList.AllowUserToDeleteRows = false;
            dataGridViewCustomerList.AllowUserToAddRows = false;
            dataGridViewCustomerList.Columns[0].HeaderText = "Họ và Tên";
            dataGridViewCustomerList.Columns[1].HeaderText = "Loại";
            dataGridViewCustomerList.Columns[2].HeaderText = "Giá Bán";
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            try
            {
                MyData myDB = new MyData();
                SqlCommand command = new SqlCommand("execute procedure_thong_tin_khach_hang_thanh_toan @name", myDB.getConnection);
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBoxPayment.Text.Trim();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewCustomerList.DataSource = table;
                dataGridViewCustomerList.AllowUserToDeleteRows = false;
                dataGridViewCustomerList.AllowUserToAddRows = false;
                dataGridViewCustomerList.Columns[0].HeaderText = "Họ và Tên";
                dataGridViewCustomerList.Columns[1].HeaderText = "Số Tiền Giao Dịch";
                dataGridViewCustomerList.Columns[2].HeaderText = "Phương Thức Thanh Toán";
                dataGridViewCustomerList.Columns[3].HeaderText = "Ngày Thanh Toán";

            }
            catch
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này", "Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tổngChiPhíThanhToánCủaKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MyData myDB = new MyData();
                SqlCommand command = new SqlCommand("execute procedure_thong_tin_khach_hang_thanh_toan_pro", myDB.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewCustomerList.DataSource = table;
                dataGridViewCustomerList.AllowUserToDeleteRows = false;
                dataGridViewCustomerList.AllowUserToAddRows = false;
                dataGridViewCustomerList.Columns[0].HeaderText = "Mã Hợp Đồng";
                dataGridViewCustomerList.Columns[1].HeaderText = "Họ Và Tên";
                dataGridViewCustomerList.Columns[2].HeaderText = "Số Tiền Đã Trả";
                dataGridViewCustomerList.Columns[3].HeaderText = "Tổng Chi Phí";
                dataGridViewCustomerList.Columns[4].HeaderText = "Số Tiền Còn Thiếu";
            }
            catch
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này", "Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thanhToánHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                PaymentForm paymentForm = new PaymentForm();
                paymentForm.ShowDialog(this);
            }
            catch
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này", "Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thôngTinThanhToánHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MyData myDB = new MyData();
                SqlCommand command = new SqlCommand("select * from vw_Thanh_Toan_Hop_Dong", myDB.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewCustomerList.DataSource = table;
                dataGridViewCustomerList.AllowUserToDeleteRows = false;
                dataGridViewCustomerList.AllowUserToAddRows = false;
                dataGridViewCustomerList.Columns[0].HeaderText = "Mã Giao Dịch";
                dataGridViewCustomerList.Columns[1].HeaderText = "Mã Hợp Đồng";
                dataGridViewCustomerList.Columns[2].HeaderText = "Họ Và Tên";
                dataGridViewCustomerList.Columns[3].HeaderText = "Phương Thức Thanh Toán";
                dataGridViewCustomerList.Columns[4].HeaderText = "Số Tiền Giao Dịch";
                dataGridViewCustomerList.Columns[5].HeaderText = "Ngày Thanh Toán";
                dataGridViewCustomerList.Columns[6].HeaderText = "Hạn Chót";
                dataGridViewCustomerList.Columns[7].HeaderText = "Xác Nhận";
                dataGridViewCustomerList.Columns[8].HeaderText = "Mã Nhân Viên";
            }
            catch
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này", "Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thôngTinCáNhânKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyData myDB = new MyData();
            DataTable tb = new DataTable();
            tb = myDB.getData("select * from vw_Quan_Ly_KH");

            dataGridViewCustomerList.DataSource = tb;
            dataGridViewCustomerList.AllowUserToDeleteRows = false;
            dataGridViewCustomerList.AllowUserToAddRows = false;
            dataGridViewCustomerList.Columns[0].HeaderText = "Mã Khách Hàng";
            dataGridViewCustomerList.Columns[1].HeaderText = "Họ Và Tên";
            dataGridViewCustomerList.Columns[2].HeaderText = "Giới Tính";
            dataGridViewCustomerList.Columns[3].HeaderText = "Ngày Sinh";
            dataGridViewCustomerList.Columns[4].HeaderText = "CMND";
            dataGridViewCustomerList.Columns[5].HeaderText = "Số Điện Thoại";
            dataGridViewCustomerList.Columns[6].HeaderText = "Nghề Nghiệp";
            dataGridViewCustomerList.Columns[7].HeaderText = "Địa Chỉ";

            myDB.openConnection();
            SqlCommand command = new SqlCommand("execute procedure_so_luong_khach_hang", myDB.getConnection);
            labelSumCustomer.Text = "Tổng số khách hàng: " + command.ExecuteScalar().ToString().Trim();

        }
    }
}
