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
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        MyData myDB = new MyData();
        Car car = new Car();
        string MaXe;

        public void fillGridCar(SqlCommand comand)
        {
            dataGridView_Warehouse.ReadOnly = true;
            dataGridView_Warehouse.DataSource = car.getDataXe(comand);
            dataGridView_Warehouse.AllowUserToAddRows = false;

            dataGridView_Warehouse.Columns[0].HeaderText = "Mã Xe";
            dataGridView_Warehouse.Columns[1].HeaderText = "Nhãn Hiệu";
            dataGridView_Warehouse.Columns[2].HeaderText = "Màu Sắc";
            dataGridView_Warehouse.Columns[3].HeaderText = "Loại Xe";
            dataGridView_Warehouse.Columns[4].HeaderText = "Năm Sản Xuất";
            dataGridView_Warehouse.Columns[5].HeaderText = "Số Ghế";
            dataGridView_Warehouse.Columns[6].HeaderText = "Giá";
            dataGridView_Warehouse.Columns[7].HeaderText = "Số Lượng";
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Kho_Xe", myDB.getConnection);
                fillGridCar(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Bạn không có quyền truy cập vào thông tin của Kho!", "Kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = false;
                return;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {

            if(dataGridView_Warehouse.CurrentRow == null)
			{
                MessageBox.Show("Vui lòng chọn xe cần xóa ở bảng bên dưới", "Xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                
            MaXe = dataGridView_Warehouse.CurrentRow.Cells[0].Value.ToString().Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xoá Xe này?", "Xoá Xe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MaXe != null)
                {
                    myDB.openConnection();
                    SqlCommand comand = new SqlCommand("DELETE FROM XE WHERE MaXe = @MaXe", myDB.getConnection);
                    comand.Parameters.Add("@MaXe", SqlDbType.Char).Value = MaXe;

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
                    MessageBox.Show("Bạn vui lòng chọn Mã Xe cần xoá!", "Xoá Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM XE", myDB.getConnection);
            fillGridCar(cmd);
            }
            catch
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này", "Xoá Xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFind.Texts.Trim() == "")
            {
                MessageBox.Show("Bạn vui lòng nhập Mã Xe hoặc Nhãn Hiệu hoặc Loại Xe mà Bạn muốn tìm kiếm.", "Tìm Kiếm Xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("exec procedure_tim_kiem_ma_xe_nhan_xe @Text", myDB.getConnection);
                cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txtFind.Texts.Trim();
                fillGridCar(cmd);
                if (dataGridView_Warehouse.Rows.Count == 0)
                {
                    MessageBox.Show("Trong Kho không có Xe có Mã Xe hoặc Nhãn Hiệu hoặc Loại Xe mà Bạn muốn tìm kiếm.", "Tìm Kiếm Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlCommand command = new SqlCommand("SELECT * FROM vw_Kho_Xe", myDB.getConnection);
                    fillGridCar(command);
                }
            }
        }

        private void thêmXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarForm AddCF = new AddCarForm();
            AddCF.Show();
            AddCF.FormClosed += WarehouseForm_Load;
        }

        private void dataGridView_Warehouse_DoubleClick(object sender, EventArgs e)
        {
            EditCarForm EditCF = new EditCarForm();
            EditCF.Show();
            EditCF.FormClosed += WarehouseForm_Load;
            EditCF.txtMaXe.Enabled = false;
            EditCF.txtMaXe.Texts = dataGridView_Warehouse.CurrentRow.Cells[0].Value.ToString().Trim();
            EditCF.txtNhanHieu.Texts = dataGridView_Warehouse.CurrentRow.Cells[1].Value.ToString().Trim();
            EditCF.txtMauSac.Texts = dataGridView_Warehouse.CurrentRow.Cells[2].Value.ToString().Trim();
            EditCF.txtLoai.Texts = dataGridView_Warehouse.CurrentRow.Cells[3].Value.ToString().Trim();
            EditCF.txtNamSX.Texts = dataGridView_Warehouse.CurrentRow.Cells[4].Value.ToString().Trim();
            EditCF.txtSoGhe.Texts = dataGridView_Warehouse.CurrentRow.Cells[5].Value.ToString().Trim();
            EditCF.txtGia.Texts = dataGridView_Warehouse.CurrentRow.Cells[6].Value.ToString().Trim();
            EditCF.txtSoLg.Texts = dataGridView_Warehouse.CurrentRow.Cells[7].Value.ToString().Trim();
        }

        private void giảmDầnSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Kho_Xe ORDER BY SoLuong desc", myDB.getConnection);
                fillGridCar(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Bạn không có quyền truy cập vào Chức Năng này!", "Sắp Xếp Kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                giảmDầnSốLượngToolStripMenuItem.Enabled = false;
                return;
            }
        }

        private void tăngDầnMãXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_Kho_Xe", myDB.getConnection);
                fillGridCar(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Bạn không có quyền truy cập vào Chức Năng này!", "Sắp Xếp Kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tăngDầnMãXeToolStripMenuItem.Enabled = false;
                return;
            }
        }
	}
}
