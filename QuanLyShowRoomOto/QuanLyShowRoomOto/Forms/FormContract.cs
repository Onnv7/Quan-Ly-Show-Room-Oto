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
    public partial class FormContract : Form
    {
        public FormContract()
        {
            InitializeComponent();
        }
        MyData myDB = new MyData();
        Contract contract = new Contract();
        public void fillGrid()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Hop_Dong", myDB.getConnection);
            dataGridView_Contract.ReadOnly = true;
            dataGridView_Contract.DataSource = contract.getDataContract(cmd);
            dataGridView_Contract.AllowUserToAddRows = false;
            dataGridView_Contract.Columns[0].HeaderText = "Mã HD";
            dataGridView_Contract.Columns[1].HeaderText = "Ngày Ký";
            dataGridView_Contract.Columns[2].HeaderText = "Ngày Nhận Xe";
            dataGridView_Contract.Columns[3].HeaderText = "Mã KH";
            dataGridView_Contract.Columns[4].HeaderText = "Họ & Tên";
            dataGridView_Contract.Columns[5].HeaderText = "CMND";
            dataGridView_Contract.Columns[6].HeaderText = "Giới Tính";
            dataGridView_Contract.Columns[7].HeaderText = "Địa Chỉ";
            dataGridView_Contract.Columns[8].HeaderText = "Ngày Sinh";
            dataGridView_Contract.Columns[9].HeaderText = "SĐT";
            dataGridView_Contract.Columns[10].HeaderText = "Nghề Nghiệp";
            dataGridView_Contract.Columns[11].HeaderText = "Mã NV";
            dataGridView_Contract.Columns[12].HeaderText = "CMND OF NV";
            dataGridView_Contract.Columns[13].HeaderText = "Họ & Tên NV";
            dataGridView_Contract.Columns[14].HeaderText = "Mã Xe";
            dataGridView_Contract.Columns[15].HeaderText = "Tên Xe";
            dataGridView_Contract.Columns[16].HeaderText = "Màu Sắc";
            dataGridView_Contract.Columns[17].HeaderText = "Năm Sản Xuất";
            dataGridView_Contract.Columns[18].HeaderText = "Số Ghế";
            dataGridView_Contract.Columns[19].HeaderText = "Thuế";
            dataGridView_Contract.Columns[20].HeaderText = "Giá Bán";
            dataGridView_Contract.Columns[21].HeaderText = "Tổng Chi Phí";
            dataGridView_Contract.Columns[22].HeaderText = "Số Lần Thanh Toán";
            fillCombox();
            labelTotal.Text = "Total ConTract : " + dataGridView_Contract.Rows.Count;
        }

        private void newContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CusForContract cfc = new CusForContract();
            cfc.Show(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkFormat())
            {
                SqlCommand cmd = new SqlCommand("exec procedure_sua_hopdonng @MaHD, @NgayKy, @NgayNhanXe, @Thue, @TongCHiPhi, @SoLanThanhToan, @MaKH, @MaXe, @MaNV", myDB.getConnection);
                cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = comboBoxMaHD.SelectedValue.ToString();
                cmd.Parameters.Add("@NgayKy", SqlDbType.DateTime).Value = dateTimePicker_Sign.Value;
                cmd.Parameters.Add("@NgayNhanXe", SqlDbType.DateTime).Value = dateTimePicker_Recieve.Value;
                cmd.Parameters.Add("@Thue", SqlDbType.Int).Value = Int32.Parse(txtThue.Texts);
                cmd.Parameters.Add("@TongChiPhi", SqlDbType.Int).Value = Int32.Parse(txtSumCost.Texts);
                cmd.Parameters.Add("@SoLanThanhToan", SqlDbType.Int).Value = Int32.Parse(txtTimesPay.Texts);
                cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = comboBoxKhachhang.SelectedValue.ToString();
                cmd.Parameters.Add("@MaXe", SqlDbType.Char).Value = comboBoxMaXe.SelectedValue.ToString();
                cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = Globals.loginName;
                myDB.openConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    myDB.closeConnection();
                    MessageBox.Show("Edit Done", "Edit ConTract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillCombo(comboBoxMaHD.SelectedIndex);
                    fillGrid();
                    txtSumCost.Texts = "";
                    txtThue.Texts = "";
                    txtTimesPay.Texts = "";
                }
                else
                {
                    myDB.closeConnection();
                    MessageBox.Show("Edit Fail", "Edit ConTract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Khong duoc de trong");
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            try
            {
                fillGrid();
            }
            catch
            {
                MessageBox.Show("Lỗi: Bạn không có quyền truy cập vào thông tin của Hợp Đồng!", "Hợp Đồng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Enabled = false;
                return;
            }
        }
        private void dataGridView_Contract_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fillCombox();
            comboBoxMaHD.SelectedValue = dataGridView_Contract.CurrentRow.Cells[0].Value;
            dateTimePicker_Sign.Value = (DateTime)dataGridView_Contract.CurrentRow.Cells[1].Value;
            dateTimePicker_Recieve.Value = (DateTime)dataGridView_Contract.CurrentRow.Cells[2].Value;
            txtThue.Texts = dataGridView_Contract.CurrentRow.Cells[19].Value.ToString();
            txtSumCost.Texts = dataGridView_Contract.CurrentRow.Cells[21].Value.ToString();
            txtTimesPay.Texts = dataGridView_Contract.CurrentRow.Cells[22].Value.ToString();
            comboBoxKhachhang.SelectedValue = dataGridView_Contract.CurrentRow.Cells[3].Value;
            comboBoxMaXe.SelectedValue = dataGridView_Contract.CurrentRow.Cells[14].Value;
        }

        private void comboBoxMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //lấy dữ liệu
                SqlCommand cmd = new SqlCommand("exec proc_tim_kiem_theo_maHD @MaHD", myDB.getConnection);
                cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = comboBoxMaHD.SelectedValue;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dateTimePicker_Sign.Text = table.Rows[0][1].ToString();
                dateTimePicker_Recieve.Text = table.Rows[0][2].ToString();
                txtThue.Texts = table.Rows[0][3].ToString();
                txtSumCost.Texts = table.Rows[0][4].ToString();
                txtTimesPay.Texts = table.Rows[0][5].ToString();
                comboBoxKhachhang.SelectedValue = table.Rows[0][6];
                comboBoxMaXe.SelectedValue = table.Rows[0][7];
            }
            catch { }
        }
        void fillCombo(int index)
        {
            SqlCommand command = new SqlCommand("select * from HOPDONG");
            SqlCommand command1 = new SqlCommand("select * from vw_Kho_Xe");
            SqlCommand command3 = new SqlCommand("select * from vw_Quan_Ly_KH");

            comboBoxMaHD.DataSource = contract.getDataContract(command);
            comboBoxMaHD.DisplayMember = "MaHD";
            comboBoxMaHD.ValueMember = "MaHD";
            comboBoxMaHD.SelectedItem = index;

            comboBoxKhachhang.DataSource = contract.getDataContract(command3);
            comboBoxKhachhang.DisplayMember = "MaKH";
            comboBoxKhachhang.ValueMember = "MaKH";
            comboBoxKhachhang.SelectedItem = index;

            comboBoxMaXe.DataSource = contract.getDataContract(command1);
            comboBoxMaXe.DisplayMember = "MaXe";
            comboBoxMaXe.ValueMember = "MaXe";
            comboBoxMaXe.SelectedItem = index;
        }
        void fillCombox()
        {
            SqlCommand command = new SqlCommand("select * from HOPDONG");
            SqlCommand command1 = new SqlCommand("select * from vw_Kho_Xe");
            SqlCommand command3 = new SqlCommand("select * from vw_Quan_Ly_KH");

            comboBoxMaHD.DataSource = contract.getDataContract(command);
            comboBoxMaHD.DisplayMember = "MaHD";
            comboBoxMaHD.ValueMember = "MaHD";
            comboBoxMaHD.SelectedItem = null;

            comboBoxKhachhang.DataSource = contract.getDataContract(command3);
            comboBoxKhachhang.DisplayMember = "MaKH";
            comboBoxKhachhang.ValueMember = "MaKH";
            comboBoxKhachhang.SelectedItem = null;

            comboBoxMaXe.DataSource = contract.getDataContract(command1);
            comboBoxMaXe.DisplayMember = "MaXe";
            comboBoxMaXe.ValueMember = "MaXe";
            comboBoxMaXe.SelectedItem = null;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (radioButtonDesign_MaHD.Checked)
            {
                SqlCommand cmd = new SqlCommand("exec procedute_FindHD_TheoMaHD '%" + txtFind.Texts + "%'");
                DataTable table = contract.getDataContract(cmd);
                if (table.Rows.Count > 0)
                {
                    dataGridView_Contract.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Not Found", "Find Contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (radioButtonDesign_Name.Checked)
            {
                SqlCommand cmd = new SqlCommand("exec procedute_FindHD_TheoTenKH '%" + txtFind.Texts + "%'");
                DataTable table = contract.getDataContract(cmd);
                if (table.Rows.Count > 0)
                {
                    dataGridView_Contract.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Not Found", "Find Contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (radioButtonDesign_NameXe.Checked)
            {
                SqlCommand cmd = new SqlCommand("exec procedute_FindHD_TheoTenXe '%" + txtFind.Texts + "%'");
                DataTable table = contract.getDataContract(cmd);
                if (table.Rows.Count > 0)
                {
                    dataGridView_Contract.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Not Found", "Find Contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillGrid();
            txtSumCost.Texts = "";
            txtThue.Texts = "";
            txtTimesPay.Texts = "";
        }

        private void txtThue_Leave(object sender, EventArgs e)
        {
            int Thue = Convert.ToInt32(txtThue.Texts.Trim());
            myDB.openConnection();
            SqlCommand cmd = new SqlCommand("exec procedure_GiaBan_cuaXe z'" + comboBoxMaXe.SelectedValue.ToString().Trim() + "'", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            txtSumCost.Texts = ((int)table.Rows[0][0] + ((int)table.Rows[0][0] * Thue) / 100).ToString().Trim();
        }
        private bool checkFormat()
        {
            if (comboBoxMaHD.SelectedItem == null ||
                txtSumCost.Texts == "" ||
                txtThue.Texts == "" ||
                txtTimesPay.Texts == "" ||
                comboBoxMaXe.SelectedItem == null ||
                comboBoxKhachhang.SelectedItem == null ||
                dateTimePicker_Recieve.Value == null ||
                dateTimePicker_Sign.Value == null)
                return false;
             return true;
        }

        private void comboBoxMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtThue_Leave(sender, e);
            }
            catch (Exception ex)
            {

            }
        }
    } 
}
