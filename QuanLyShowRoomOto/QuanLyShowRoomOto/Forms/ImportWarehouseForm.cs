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
    public partial class ImportWarehouseForm : Form
    {
        public ImportWarehouseForm()
        {
            InitializeComponent();
        }

        Order order = new Order();
        MyData myDB = new MyData();

        public void fillGridOrder(SqlCommand comand)
        {
                dataGridView_ImportWarehouse.ReadOnly = true;
                dataGridView_ImportWarehouse.DataSource = order.getDataNhapHang(comand);
                dataGridView_ImportWarehouse.AllowUserToAddRows = false;

                dataGridView_ImportWarehouse.Columns[0].HeaderText = "Mã Đơn";
                dataGridView_ImportWarehouse.Columns[1].HeaderText = "Ngày Nhập";
                dataGridView_ImportWarehouse.Columns[2].HeaderText = "Xác Nhận";
                dataGridView_ImportWarehouse.Columns[3].HeaderText = "Nhân Viên Xác Nhận";
        }

        private void ImportWarehouseForm_Load(object sender, EventArgs e)
        {
            try
            {
                radiobtnTatCa.Checked = true;
                SqlCommand command = new SqlCommand("SELECT * FROM vw_DonHang");
                fillGridOrder(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Bạn không có quyền truy cập vào thông tin của Kho Nhập!", "Kho Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = false;
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFind.Texts.Trim() == "")
            {
                MessageBox.Show("Bạn vui lòng nhập Mã Đơn mà Bạn muốn tìm kiếm.", "Tìm Kiếm Đơn Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_DonHang WHERE MaDon = @MaDon", myDB.getConnection);
                cmd.Parameters.Add("@MaDon", SqlDbType.Char).Value = txtFind.Texts.Trim();
                fillGridOrder(cmd);
                if (dataGridView_ImportWarehouse.Rows.Count == 0)
                {
                    MessageBox.Show("Hiện chưa có Đơn Hàng nào có Mã Đơn như Bạn đang tìm kiếm.", "Tìm Kiếm Đơn Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd = new SqlCommand("SELECT * FROM vw_DonHang");
                    txtFind.Texts = "Nhập Mã Đơn để tìm kiếm Đơn Nhập Hàng";
                    fillGridOrder(cmd);
                }
            }
        }

        private void radiobtnChuaXN_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM vw_DonHang WHERE XacNhan = N'Chưa được xác nhận'");
            fillGridOrder(command);
        }

        private void radiobtnDaXN_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM vw_DonHang WHERE XacNhan = N'Đã được xác nhận'");
            fillGridOrder(command);
        }

        private void radiobtnTatCa_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM vw_DonHang");
            fillGridOrder(command);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView_ImportWarehouse.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn nhập cần xóa ở bảng bên dưới", "Kho nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maDon = dataGridView_ImportWarehouse.CurrentRow.Cells[0].Value.ToString().Trim();
            string maNV = dataGridView_ImportWarehouse.CurrentRow.Cells[3].Value.ToString().Trim();

            try
            {
                if (Globals.loginName == maNV)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xoá Đơn Nhập Hàng này?", "Xoá Đơn Nhập Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        myDB.openConnection();

                        SqlCommand comand = new SqlCommand("DELETE FROM DONNHAPHANG WHERE MaDon = @MaDon", myDB.getConnection);
                        comand.Parameters.Add("@MaDon", SqlDbType.Char).Value = maDon;

                        if (comand.ExecuteNonQuery() == 1)
                        {
                            myDB.closeConnection();
                        }
                        else
                        {
                            myDB.closeConnection();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không được xoá thông tin Đơn Hàng của Nhân Viên khác!", "Kho nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_DonHang", myDB.getConnection);
                fillGridOrder(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xoá Đơn Nhập Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_ImportWarehouse_DoubleClick(object sender, EventArgs e)
        {
            string maDon = dataGridView_ImportWarehouse.CurrentRow.Cells[0].Value.ToString().Trim();

            SingleDetailForm SingleDF = new SingleDetailForm();

            SingleDF.lb_MaDon.Text = maDon;

            SingleDF.Show();
        }

        private void thêmDonHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrderForm AddOF = new AddOrderForm();
            AddOF.Show();
            AddOF.FormClosed += ImportWarehouseForm_Load;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView_ImportWarehouse.CurrentRow == null)
			{
                MessageBox.Show("Vui lòng chọn đơn nhập cần sửa ở bảng bên dưới", "Kho nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                
            string maDon = dataGridView_ImportWarehouse.CurrentRow.Cells[0].Value.ToString().Trim();
            string maNV = dataGridView_ImportWarehouse.CurrentRow.Cells[3].Value.ToString().Trim();

            if (Globals.loginName == maNV)
            {
                EditOrderForm EditOF = new EditOrderForm();
                EditOF.txtMaDon.Texts = maDon;
                EditOF.txtMaDon.Enabled = false;
                if (dataGridView_ImportWarehouse.CurrentRow.Cells[2].Value.ToString() == "Đã được xác nhận")
                    EditOF.radiobtnDaXN.Checked = true;
                else
                    EditOF.radiobtnChuaXN.Checked = true;
                EditOF.dateTimePickerNgayNhan.Value = (DateTime)dataGridView_ImportWarehouse.CurrentRow.Cells[1].Value;

                EditOF.Show();
                EditOF.FormClosed += ImportWarehouseForm_Load;
            }
            else
            {
                MessageBox.Show("Bạn không được chỉnh sửa thông tin Đơn Hàng của Nhân Viên khác!", "Kho nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            if (txtFind.Texts == "Nhập Mã Đơn để tìm kiếm Đơn Nhập Hàng")
                txtFind.Texts = "";
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            if (txtFind.Texts == "")
                txtFind.Texts = "Nhập Mã Đơn để tìm kiếm Đơn Nhập Hàng";
        }
    }
}
