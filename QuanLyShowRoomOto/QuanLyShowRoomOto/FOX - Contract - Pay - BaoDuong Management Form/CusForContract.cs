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
    public partial class CusForContract : Form
    {
        public CusForContract()
        {
            InitializeComponent();
        }
        Contract contract = new Contract();
        private void CusForContract_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM vw_Quan_Ly_KH");
            fillGrid(command);
        }
        public void fillGrid(SqlCommand comand)
        {
            dataGridViewCus.ReadOnly = true;
            dataGridViewCus.DataSource = contract.getDataContract(comand);
            dataGridViewCus.AllowUserToAddRows = false;
            dataGridViewCus.Columns[0].HeaderText = "Mã KH";
            dataGridViewCus.Columns[1].HeaderText = "Họ Tên";
            dataGridViewCus.Columns[2].HeaderText = "Giới Tính";
            dataGridViewCus.Columns[3].HeaderText = "Ngày Sinh";
            dataGridViewCus.Columns[4].HeaderText = "CMND";
            dataGridViewCus.Columns[5].HeaderText = "SĐT";
            dataGridViewCus.Columns[6].HeaderText = "Nghề Nghiệp";
            dataGridViewCus.Columns[7].HeaderText = "Địa Chỉ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddCustomer fac = new FormAddCustomer();
            fac.Show(this);
            
        }

        private void dataGridViewCus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAddConTract fact = new FormAddConTract();
            fact.txtMaKH.Texts = dataGridViewCus.CurrentRow.Cells[0].Value.ToString();
            fact.Show(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM vw_Quan_Ly_KH");
            fillGrid(command);
        }
    }
}
