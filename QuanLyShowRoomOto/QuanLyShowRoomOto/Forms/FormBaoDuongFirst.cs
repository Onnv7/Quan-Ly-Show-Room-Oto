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
    public partial class FormBaoDuongFirst : Form
    {
        public FormBaoDuongFirst()
        {
            InitializeComponent();
        }
        MyData myDB = new MyData();
        Contract contract = new Contract();
        private void ThemBaoDuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxBaoDuong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã Hợp đồng kế bên nút 'Bảo Dưỡng Cho Hợp Đồng'", "Bảo dưỡng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SoLan() < 6)
            {
                FormAddBaoDuong fabd = new FormAddBaoDuong();
                fabd.txtMaHD.Texts = comboBoxBaoDuong.SelectedValue.ToString().Trim();
                fabd.Show(this);
            }
            else
            {
                MessageBox.Show("Mỗi HD chỉ được bảo dưỡng 6 lần ", "Bảo Dưỡng ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private int SoLan()
        {
            myDB.openConnection();
            int count = 0;
            SqlCommand cmd = new SqlCommand("select dbo.function_dem_so_lan_bao_duong (@MaHD)", myDB.getConnection);
            cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = comboBoxBaoDuong.SelectedValue.ToString().Trim();
            try
            {
                count = (int)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {

            }
            myDB.closeConnection();
            return count;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(dataGridViewBaoDuong.CurrentRow == null)
			{
                MessageBox.Show("Vui lòng chọn bảo dưỡng bạn muốn xem", "Bảo dưỡng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
			}                
            string MaNV = dataGridViewBaoDuong.CurrentRow.Cells[2].Value.ToString().Trim();
            myDB.openConnection();
            SqlCommand cmd = new SqlCommand("exec procedure_TT_NV_BaoDuong " + MaNV + "", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count == 0)
			{
                return;
			}                
            txtHoTenNV.Texts = table.Rows[0][0].ToString().Trim();
            txtCMNDNV.Texts = table.Rows[0][1].ToString().Trim();
            txtSDTNV.Texts = table.Rows[0][2].ToString().Trim();
            txtEmail.Texts = table.Rows[0][3].ToString().Trim();
            myDB.closeConnection();
        }

        private void btnBaoDuongHD_Click(object sender, EventArgs e)
        {
            if(comboBoxBaoDuong.SelectedItem == null)
			{
                MessageBox.Show("Vui lòng mã hợp đồng bạn muốn xem", "Bảo dưỡng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                
            myDB.openConnection();
            SqlCommand cmd = new SqlCommand("exec procedure_BaoDuong_CuaHD '" + comboBoxBaoDuong.SelectedValue.ToString() + "'", myDB.getConnection);
            DataTable table = contract.getDataContract(cmd);
            dataGridViewBaoDuong.DataSource = table;
            dataGridViewBaoDuong.AllowUserToAddRows = false;
            if (dataGridViewBaoDuong.Rows.Count <= 0)
            {
                MessageBox.Show("" + comboBoxBaoDuong.SelectedValue.ToString().Trim() + " chưa có bão dưỡng");
                //labelcount.Visible = true;
                labelcount.Text = "" + comboBoxBaoDuong.SelectedValue.ToString().Trim() + " đang có " + SoLan() + " bảo dưỡng.";
            }
            else
            {
                dataGridViewBaoDuong.Columns[0].HeaderText = "Mã HD";
                dataGridViewBaoDuong.Columns[1].HeaderText = "Ngày Bảo Dưỡng";
                dataGridViewBaoDuong.Columns[2].HeaderText = "NV Xác Nhận";
                labelcount.Visible = true;
                labelcount.Text = "" + comboBoxBaoDuong.SelectedValue.ToString().Trim() + " đang có " + SoLan() + " bảo dưỡng.";
            }

            myDB.closeConnection();
        }
        void fillCombox()
        {
            SqlCommand command = new SqlCommand("select * from HOPDONG");
            comboBoxBaoDuong.DataSource = contract.getDataContract(command);
            comboBoxBaoDuong.DisplayMember = "MaHD";
            comboBoxBaoDuong.ValueMember = "MaHD";
            comboBoxBaoDuong.SelectedItem = null;
        }

        private void FormBaoDuongFirst_Load(object sender, EventArgs e)
        {
            try
            {
                fillGrid();
                labelcount.Visible = false;
                fillCombox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Bạn không có quyền truy cập vào thông tin của Bảo Dưỡng!", "Bão Dưỡng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Enabled = false;
                return;
            }
        }
        void fillGrid()
        {
            myDB.openConnection();
            SqlCommand cmd = new SqlCommand("select * from BAODUONG", myDB.getConnection);
            DataTable table = contract.getDataContract(cmd);
            dataGridViewBaoDuong.DataSource = table;
            dataGridViewBaoDuong.AllowUserToAddRows = false;
            dataGridViewBaoDuong.Columns[0].HeaderText = "Mã HD";
            dataGridViewBaoDuong.Columns[1].HeaderText = "Ngày Bảo Dưỡng";
            dataGridViewBaoDuong.Columns[2].HeaderText = "NV Xác Nhận";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}
