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
    public partial class SingleDetailForm : Form
    {
        public SingleDetailForm()
        {
            InitializeComponent();
        }

        MyData myDB = new MyData();
        Order order = new Order();

        public void fillGridSingleDetail(SqlCommand comand)
        {
            dataGridView_SingleDetail.ReadOnly = true;
            dataGridView_SingleDetail.DataSource = order.getDataNhapHang(comand);
            dataGridView_SingleDetail.AllowUserToAddRows = false;

            dataGridView_SingleDetail.Columns[0].HeaderText = "Mã Đơn";
            dataGridView_SingleDetail.Columns[1].HeaderText = "Mã Xe";
            dataGridView_SingleDetail.Columns[2].HeaderText = "Ngày Nhập";
            dataGridView_SingleDetail.Columns[3].HeaderText = "Số Lượng";
            dataGridView_SingleDetail.Columns[4].HeaderText = "Giá Nhập";
            dataGridView_SingleDetail.Columns[5].HeaderText = "Xác Nhận";
            dataGridView_SingleDetail.Columns[6].HeaderText = "Nhân Viên Xác Nhận";
        }

        private void SingleDetailForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Don_Chitiet_Nhaphang WHERE MaDon = @MaDon");
            cmd.Parameters.Add("@MaDon", SqlDbType.Char).Value = lb_MaDon.Text.ToString().Trim();
            fillGridSingleDetail(cmd);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xoá Chi Tiết Đơn Nhập Hàng này?", "Xoá Chi Tiết Đơn Nhập Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maDon = dataGridView_SingleDetail.CurrentRow.Cells[0].Value.ToString().Trim();

                    if (maDon != null)
                    {
                        SqlCommand comand = new SqlCommand("DELETE FROM CHITIETNHAPXE WHERE MaDon = @MaDon AND MaXe = @MaXe", myDB.getConnection);
                        comand.Parameters.Add("@MaDon", SqlDbType.Char).Value = maDon;
                        comand.Parameters.Add("@MaXe", SqlDbType.Char).Value = dataGridView_SingleDetail.CurrentRow.Cells[1].Value.ToString().Trim();

                        myDB.openConnection();

                        if (comand.ExecuteNonQuery() == 1)
                        {
                            myDB.closeConnection();
                        }
                        else
                        {
                            myDB.closeConnection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn vui lòng chọn Mã Đơn cần xoá!", "Xoá Chi Tiết Đơn Nhập Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Don_Chitiet_Nhaphang WHERE MaDon = @MaDon", myDB.getConnection);
                cmd.Parameters.Add("@MaDon", SqlDbType.Char).Value = dataGridView_SingleDetail.CurrentRow.Cells[0].Value.ToString();
                fillGridSingleDetail(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xoá Chi Tiết Đơn Nhập Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSingleDetailForm EditSingleDetailF = new EditSingleDetailForm();
            EditSingleDetailF.Show();

            EditSingleDetailF.txtMaDon.Texts = dataGridView_SingleDetail.CurrentRow.Cells[0].Value.ToString().Trim();
            EditSingleDetailF.txtMaDon.Enabled = false;
            EditSingleDetailF.txtMaXe.Texts = dataGridView_SingleDetail.CurrentRow.Cells[1].Value.ToString().Trim();
            EditSingleDetailF.txtMaXe.Enabled = false;
            EditSingleDetailF.txtSoLg.Texts = dataGridView_SingleDetail.CurrentRow.Cells[3].Value.ToString().Trim();
            EditSingleDetailF.txtGiaNhap.Texts = dataGridView_SingleDetail.CurrentRow.Cells[4].Value.ToString().Trim();

            EditSingleDetailF.FormClosed += SingleDetailForm_Load;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSingleDetailForm AddSingleDetailF = new AddSingleDetailForm();
            AddSingleDetailF.Show();
            AddSingleDetailF.FormClosed += SingleDetailForm_Load;
            AddSingleDetailF.txtMaDon.Texts = lb_MaDon.Text.ToString().Trim();
        }
    }
}
