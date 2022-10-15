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
	public partial class StaffForm : Form
	{
        MyData myData = new MyData();
        private Form childForm;
        public StaffForm()
		{
			InitializeComponent();
		}

		private void StaffForm_Load(object sender, EventArgs e)
		{
            comboBox1.SelectedIndex = 2;
            fillGrid();
        }
        private void fillGrid()
        {
            DataTable tb = new DataTable();
            try
			{
                tb = myData.getData("select * from vw_Quan_Ly_NV");
			} 
            catch(Exception ex)
			{
                MessageBox.Show("Lỗi: " + ex.Message, "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //  this.Close();
                this.Enabled = false;
                return;
            }
            if(tb.Rows.Count == 0)
			{
                MessageBox.Show("Không có dữ liệu", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
			}                
            dataGridViewStaffList.DataSource = tb;
            dataGridViewStaffList.AllowUserToDeleteRows = false;
            dataGridViewStaffList.AllowUserToAddRows = false;
            for (int i = 0; i < dataGridViewStaffList.Columns.Count; i++)
                dataGridViewStaffList.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridViewStaffList.Columns[0].HeaderText = "Mã nhân viên";
            dataGridViewStaffList.Columns[1].HeaderText = "Họ";
            dataGridViewStaffList.Columns[2].HeaderText = "Tên";
            dataGridViewStaffList.Columns[3].HeaderText = "Giới tính";
            dataGridViewStaffList.Columns[4].HeaderText = "Ngày sinh";
            dataGridViewStaffList.Columns[5].HeaderText = "CMND";
            dataGridViewStaffList.Columns[6].HeaderText = "SĐT";
            dataGridViewStaffList.Columns[7].HeaderText = "Email";
            dataGridViewStaffList.Columns[8].HeaderText = "Lương";
            dataGridViewStaffList.Columns[9].HeaderText = "Ngày vào làm";
            dataGridViewStaffList.Columns[10].HeaderText = "Chức vụ";
            dataGridViewStaffList.Columns[11].HeaderText = "Trạng thái";
        }

		private void buttonSearch_Click(object sender, EventArgs e)
		{
            myData.openConnection();
            SqlCommand cmd = new SqlCommand("exec procedure_tim_kiem_nhan_vien_bang_thong_tin @thongTin", myData.getConnection);
        //    MessageBox.Show(myData.getConnection.ToString());
            cmd.Parameters.Add("@thongTin", SqlDbType.NVarChar).Value = textBoxSearch.Texts.ToString().Trim();
            try
            {
                DataTable tb = new DataTable();
                tb.Load(cmd.ExecuteReader());
                if (tb.Rows.Count > 0)
                {
                    dataGridViewStaffList.DataSource = tb;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Tìm kiếm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tìm kiếm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

		private void buttonDelete_Click(object sender, EventArgs e)
		{
            if(dataGridViewStaffList.CurrentRow == null)
			{
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa ở bảng bên dưới", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                
            if (MessageBox.Show("Bạn có chắc chắn xóa nhân viên đang chọn?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            string empCode = dataGridViewStaffList.CurrentRow.Cells[0].Value.ToString().Trim();
            if (empCode != null)
            {
                myData.openConnection();
                SqlCommand cmd = new SqlCommand("exec procedure_xoa_nhan_vien @MaNV", myData.getConnection);
                cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = empCode;
                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xóa thành công", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa thất bại", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridViewStaffList.DataSource = myData.getData("select * from vw_Quan_Ly_NV");
                myData.closeConnection();
            }
            else
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa trong bảng bên dưới", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

		private void buttonEdit_Click(object sender, EventArgs e)
		{
            EditInforEmpForm formEditInforEmp = new EditInforEmpForm();
            if(dataGridViewStaffList.CurrentRow == null)
			{
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa ở bảng bên dưới", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                
            formEditInforEmp.textBoxStaffCode.Texts = dataGridViewStaffList.CurrentRow.Cells[0].Value.ToString().Trim();
            formEditInforEmp.textBoxLastName.Texts = dataGridViewStaffList.CurrentRow.Cells[1].Value.ToString().Trim();
            formEditInforEmp.textBoxFirstName.Texts = dataGridViewStaffList.CurrentRow.Cells[2].Value.ToString().Trim();
            formEditInforEmp.radioButtonFemale.Checked = dataGridViewStaffList.CurrentRow.Cells[3].Value.ToString().Trim() == "Nữ" ? true : false;
            formEditInforEmp.radioButtonMale.Checked = dataGridViewStaffList.CurrentRow.Cells[3].Value.ToString().Trim() == "Nam" ? true : false;
            formEditInforEmp.dateTimePickerBirthDate.Value = Convert.ToDateTime(dataGridViewStaffList.CurrentRow.Cells[4].Value.ToString().Trim());
            formEditInforEmp.textBoxIDNumber.Texts = dataGridViewStaffList.CurrentRow.Cells[5].Value.ToString().Trim();
            formEditInforEmp.textBoxNBPhone.Texts = dataGridViewStaffList.CurrentRow.Cells[6].Value.ToString().Trim();
            formEditInforEmp.textBoxEmail.Texts = dataGridViewStaffList.CurrentRow.Cells[7].Value.ToString().Trim();
            formEditInforEmp.textBoxSalary.Texts = dataGridViewStaffList.CurrentRow.Cells[8].Value.ToString().Trim();
            formEditInforEmp.dateTimePickerWorkingTime.Value = Convert.ToDateTime(dataGridViewStaffList.CurrentRow.Cells[9].Value.ToString().Trim());
            formEditInforEmp.comboBoxPosition.Text = dataGridViewStaffList.CurrentRow.Cells[10].Value.ToString().Trim();
            formEditInforEmp.radioButtonOff.Checked = dataGridViewStaffList.CurrentRow.Cells[11].Value.ToString().Trim() == "Đã nghỉ" ? true : false;
            formEditInforEmp.radioButtonOn.Checked = dataGridViewStaffList.CurrentRow.Cells[11].Value.ToString().Trim() == "Đang làm" ? true : false;

            formEditInforEmp.Show();
            formEditInforEmp.FormClosed += StaffForm_Load;
        }

		private void buttonDesign1_Click(object sender, EventArgs e)
		{
            comboBox1.SelectedIndex = 2;
            textBoxSearch.Texts = "Mã NV, họ tên, CMND, sđt, email";
            fillGrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index == 2)
            {
                fillGrid();
                return;
            }
            DataTable tb = new DataTable();
            myData.openConnection();
            SqlCommand cmd = new SqlCommand("exec procedure_nhan_vien_theo_luong_tang_hoac_giam " + index, myData.getConnection);
            try
            {
                tb.Load(cmd.ExecuteReader());
                dataGridViewStaffList.DataSource = tb;

            }
            catch (Exception ex)
            {

            }
            myData.closeConnection();
        }

		

		private void bảngXếpHạngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
            StaffRankingsByQuantityForm formStaffRankings = new StaffRankingsByQuantityForm();
            formStaffRankings.Show();
        }

		private void nhânViênNghỉViệcToolStripMenuItem_Click(object sender, EventArgs e)
		{
            EmployeeLeaveForm employeeLeaveForm = new EmployeeLeaveForm();
            employeeLeaveForm.Show();

        }

		private void textBoxSearch_Leave(object sender, EventArgs e)
		{
            if (textBoxSearch.Texts.Trim() == "")
                textBoxSearch.Texts = "Mã NV, họ tên, CMND, sđt, email";
		}


		private void textBoxSearch_Enter(object sender, EventArgs e)
		{
            textBoxSearch.Texts = "";
        }

		private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if(dataGridViewStaffList.CurrentRow == null)
			{
                MessageBox.Show("Vui lòng chọn nhân viên cần tạo tài khoản", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
			}
            string chucVu = dataGridViewStaffList.CurrentRow.Cells[10].Value.ToString().Trim();
            if (chucVu == "Quản lý" || chucVu == "Quản kho" ||
                chucVu == "Nhân viên bán hàng" || chucVu == "Nhân viên bảo dưỡng" ||
                chucVu == "Thu ngân")
			{
                RegisterForm registerForm = new RegisterForm();
                registerForm.textBoxUsername.Texts = dataGridViewStaffList.CurrentRow.Cells[0].Value.ToString().Trim();
                registerForm.textBoxStaffCode.Texts = dataGridViewStaffList.CurrentRow.Cells[0].Value.ToString().Trim();
                registerForm.textBoxUsername.Enabled = false;

                registerForm.Show();
                registerForm.chucVu = chucVu;
            }                
            else
			{
                MessageBox.Show("Chỉ tạo tài khoản cho những nhân viên có vai trò lớn", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}                
            
		}
        private void xoáTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewStaffList.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa tài khoản", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = dataGridViewStaffList.CurrentRow.Cells[0].Value.ToString().Trim();
            myData.openConnection();
            SqlCommand cmd = new SqlCommand("exec xoa_login @loginName, @userName", myData.getConnection);
            cmd.Parameters.Add("@loginName", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = id;
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Không có gì để xóa", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                myData.closeConnection();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myData.closeConnection();
                return;
            }
        }

        private void thêmChứcVụToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddStaffForm formAddStaff = new AddStaffForm();
            formAddStaff.Show();
            formAddStaff.FormClosed += StaffForm_Load;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chucVu = dataGridViewStaffList.CurrentRow.Cells[10].Value.ToString().Trim();
            string id = dataGridViewStaffList.CurrentRow.Cells[0].Value.ToString().Trim();

            if (dataGridViewStaffList.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần đổi mật khẩu", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            myData.openConnection();
            SqlCommand cmd = new SqlCommand("exec xoa_login @loginName, @userName", myData.getConnection);
            cmd.Parameters.Add("@loginName", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = id;
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    if (chucVu == "Quản lý" || chucVu == "Quản kho" ||
                        chucVu == "Nhân viên bán hàng" || chucVu == "Nhân viên bảo dưỡng" ||
                        chucVu == "Thu ngân")
                    {
                        ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
                        resetPasswordForm.textBoxUsername.Texts = dataGridViewStaffList.CurrentRow.Cells[0].Value.ToString().Trim();
                        resetPasswordForm.textBoxStaffCode.Texts = dataGridViewStaffList.CurrentRow.Cells[0].Value.ToString().Trim();
                        resetPasswordForm.textBoxUsername.Enabled = false;

                        resetPasswordForm.Show();
                        resetPasswordForm.chucVu = chucVu;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không thuộc nhân viên nào!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên này chưa có tài khoản", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                myData.closeConnection();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myData.closeConnection();
                return;
            }        
        }
    }
}
