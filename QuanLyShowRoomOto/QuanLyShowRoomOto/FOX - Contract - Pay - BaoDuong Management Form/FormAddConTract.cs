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
    public partial class FormAddConTract : Form
    {
        public FormAddConTract()
        {
            InitializeComponent();
        }
        MyData myDB = new MyData();
        Contract contract = new Contract();
        private void AddConTract_Load(object sender, EventArgs e)
        {
            fillCombox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkFormat() == true)
            {
                myDB.openConnection();
                SqlCommand cmd = new SqlCommand("exec procedure_tao_hop_dong @MaHD ,@NgayKy ,@NgayNhanXe ,@Thue ,@TongChiPhi " +
                                        ", @SoLanThanhToan , @MaKH , @MaXe , @MaNV ," +
                                        "@MaGD1 , @SoTienGD1 , @XacNhan1 , @HanChot1 ," +
                                        "@MaGD2 , @SoTienGD2 , @XacNhan2 , @HanChot2 ," +
                                        "@MaGD3 , @SoTienGD3 , @XacNhan3 , @HanChot3 ", myDB.getConnection);
                cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = txtMaHD.Texts.Trim();
                cmd.Parameters.Add("@NgayKy", SqlDbType.Date).Value = dateTimePicker_Sign.Value;
                cmd.Parameters.Add("@NgayNhanXe", SqlDbType.Date).Value = dateTimePicker_Recieve.Value;
                cmd.Parameters.Add("@Thue", SqlDbType.Int).Value = Int32.Parse(txtThue.Texts.Trim());
                cmd.Parameters.Add("@TongChiPhi", SqlDbType.Int).Value = Int32.Parse(txtSumCost.Texts.Trim());
                if (radioButtonDesign1.Checked)
                {
                    cmd.Parameters.Add("@SoLanThanhToan", SqlDbType.Int).Value = Convert.ToString(1).Trim();

                    cmd.Parameters.Add("@MaGD1", SqlDbType.Char).Value = txtMaGD1.Texts.Trim();
                    cmd.Parameters.Add("@SoTienGD1", SqlDbType.Int).Value = Int32.Parse(txtPayMoney1.Texts.Trim());
                    cmd.Parameters.Add("@XacNhan1", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@HanChot1", SqlDbType.Date).Value = dateTimePicker_HanChot1.Value;

                    cmd.Parameters.Add("@MaGD2", SqlDbType.Char).Value = "";
                    cmd.Parameters.Add("@SoTienGD2", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@XacNhan2", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@HanChot2", SqlDbType.Date).Value = dateTimePicker_HanChot2.Value;

                    cmd.Parameters.Add("@MaGD3", SqlDbType.Char).Value = "";
                    cmd.Parameters.Add("@SoTienGD3", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@XacNhan3", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@HanChot3", SqlDbType.Date).Value = dateTimePicker_HanChot3.Value;
                }
                else if (radioButtonDesign2.Checked)
                {
                    cmd.Parameters.Add("@SoLanThanhToan", SqlDbType.Int).Value = Convert.ToString(2).Trim();


                    cmd.Parameters.Add("@MaGD1", SqlDbType.Char).Value = txtMaGD1.Texts.Trim();
                    cmd.Parameters.Add("@SoTienGD1", SqlDbType.Int).Value = Int32.Parse(txtPayMoney1.Texts.Trim());
                    cmd.Parameters.Add("@XacNhan1", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@HanChot1", SqlDbType.Date).Value = dateTimePicker_HanChot1.Value;

                    cmd.Parameters.Add("@MaGD2", SqlDbType.Char).Value = txtMaGD2.Texts.Trim();
                    cmd.Parameters.Add("@SoTienGD2", SqlDbType.Int).Value = Int32.Parse(txtPayMoney2.Texts.Trim());
                    cmd.Parameters.Add("@XacNhan2", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@HanChot2", SqlDbType.Date).Value = dateTimePicker_HanChot2.Value;

                    cmd.Parameters.Add("@MaGD3", SqlDbType.Char).Value = "";
                    cmd.Parameters.Add("@SoTienGD3", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@XacNhan3", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@HanChot3", SqlDbType.Date).Value = dateTimePicker_HanChot3.Value;
                }
                else
                {
                    cmd.Parameters.Add("@SoLanThanhToan", SqlDbType.Int).Value = Convert.ToString(3).Trim();


                    cmd.Parameters.Add("@MaGD", SqlDbType.Char).Value = txtMaGD1.Texts.Trim();
                    cmd.Parameters.Add("@SoTienGD1", SqlDbType.Int).Value = Int32.Parse(txtPayMoney1.Texts.Trim());
                    cmd.Parameters.Add("@XacNhan1", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@HanChot1", SqlDbType.Date).Value = dateTimePicker_HanChot1.Value;

                    cmd.Parameters.Add("@MaGD2", SqlDbType.Char).Value = txtMaGD2.Texts.Trim();
                    cmd.Parameters.Add("@SoTienGD2", SqlDbType.Int).Value = Int32.Parse(txtPayMoney2.Texts.Trim());
                    cmd.Parameters.Add("@XacNhan2", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@HanChot2", SqlDbType.Date).Value = dateTimePicker_HanChot2.Value;

                    cmd.Parameters.Add("@MaGD3", SqlDbType.Char).Value = txtMaGD3.Texts.Trim();
                    cmd.Parameters.Add("@SoTienGD3", SqlDbType.Int).Value = Int32.Parse(txtPayMoney3.Texts.Trim());
                    cmd.Parameters.Add("@XacNhan3", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@HanChot3", SqlDbType.Date).Value = dateTimePicker_HanChot3.Value;
                }
                cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = txtMaKH.Texts.Trim();
                cmd.Parameters.Add("@MaXe", SqlDbType.Char).Value = comboBoxMaXe.SelectedValue.ToString().Trim();
                cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = Globals.loginName;
                myDB.openConnection();
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thêm hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                myDB.closeConnection();
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thêm hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool checkFormat()
        {
            bool flag = true;
            if (txtMaHD.Texts.Trim() == "" ||
                dateTimePicker_Sign.Value == null ||
                dateTimePicker_Recieve.Value == null ||
                txtThue.Texts.Trim() == "" ||
                txtSumCost.Texts.Trim() == "" ||
                (radioButtonDesign1.Checked == false &&
                radioButtonDesign2.Checked == false &&
                radioButtonDesign3.Checked == false) ||
                txtMaKH.Texts.Trim() == "" ||
                comboBoxMaXe.SelectedValue == null)
                flag = false;
            if (radioButtonDesign1.Checked)
            {
                if (txtMaGD1.Texts.Trim() == "" ||
                    txtPayMoney1.Texts.Trim() == "" ||
                    txtTongTien1.Texts.Trim() == "" ||
                    txt_timePay1.Texts.Trim() == "" ||
                    dateTimePicker_HanChot1.Value == null)
                    flag = false;
            }
            if (radioButtonDesign2.Checked)
            {
                if (txtMaGD1.Texts.Trim() == "" ||
                    txtPayMoney1.Texts.Trim() == "" ||
                    txtTongTien1.Texts.Trim() == "" ||
                    txt_timePay1.Texts.Trim() == "" ||
                    dateTimePicker_HanChot1.Value == null ||
                    txtMaGD2.Texts.Trim() == "" ||
                    txtPayMoney2.Texts.Trim() == "" ||
                    txtTongTien2.Texts.Trim() == "" ||
                    txt_timePay2.Texts.Trim() == "" ||
                    dateTimePicker_HanChot2.Value == null)
                    flag = false;
            }
            if (radioButtonDesign3.Checked)
            {
                if (txtMaGD1.Texts.Trim() == "" ||
                    txtPayMoney1.Texts.Trim() == "" ||
                    txtTongTien1.Texts.Trim() == "" ||
                    txt_timePay1.Texts.Trim() == "" ||
                    dateTimePicker_HanChot1.Value == null || txtMaGD2.Texts.Trim() == "" ||
                    txtPayMoney2.Texts.Trim() == "" ||
                    txtTongTien2.Texts.Trim() == "" ||
                    txt_timePay2.Texts.Trim() == "" ||
                    dateTimePicker_HanChot2.Value == null ||
                    txtMaGD3.Texts.Trim() == "" ||
                    txtPayMoney3.Texts.Trim() == "" ||
                    txtTongTien3.Texts.Trim() == "" ||
                    txt_timePay3.Texts.Trim() == "" ||
                    dateTimePicker_HanChot3.Value == null)
                    flag = false;
            }
            return flag;


        }
        void fillCombox()
        {
            SqlCommand command = new SqlCommand("select * from vw_Kho_Xe");

            comboBoxMaXe.DataSource = contract.getDataContract(command);
            comboBoxMaXe.DisplayMember = "MaXe";
            comboBoxMaXe.ValueMember = "MaXe";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtThue_Leave(object sender, EventArgs e)
        {
            int Thue = Convert.ToInt32(txtThue.Texts.Trim());
            myDB.openConnection();
            SqlCommand cmd = new SqlCommand("exec procedure_GiaBan_cuaXe '" + comboBoxMaXe.SelectedValue.ToString().Trim() + "'", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            txtSumCost.Texts = ((int)table.Rows[0][0] + ((int)table.Rows[0][0] * Thue) / 100).ToString().Trim();
        }

		private void radioButtonDesign1_CheckedChanged(object sender, EventArgs e)
		{
            if (radioButtonDesign1.Checked == true)
			{
                panelGD1.Visible = true;
                panelGD2.Visible = false;
                panelGD3.Visible = false;
                txtTongTien1.Texts = txtSumCost.Texts;
                txtPayMoney1.Texts = txtSumCost.Texts;
                txt_timePay1.Texts = 1.ToString().Trim();
            }                
            else
			{

			}
            this.Size = new Size(1165, 831);

        }

        private void comboBoxMaXe_SelectedIndexChanged(object sender, EventArgs e)
		{
            try
			{
                txtThue_Leave(sender, e);
			}                
            catch(Exception ex)
			{

			}            
            //int Thue = Convert.ToInt32(txtThue.Texts.Trim());
            //myDB.openConnection();
            //SqlCommand cmd = new SqlCommand("exec procedure_GiaBan_cuaXe '" + comboBoxMaXe.SelectedValue.ToString().Trim() + "'", myDB.getConnection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //txtSumCost.Texts = ((int)table.Rows[0][0] + ((int)table.Rows[0][0] * Thue) / 100).ToString().Trim();
        }

		private void radioButtonDesign2_CheckedChanged(object sender, EventArgs e)
		{
            if(radioButtonDesign2.Checked == true)
			{
                panelGD1.Visible = true;
                panelGD2.Visible = true;
                panelGD3.Visible = false;
                txtTongTien1.Texts = txtSumCost.Texts;
                txt_timePay1.Texts = 1.ToString().Trim();
                txt_timePay2.Texts = 2.ToString().Trim();
            }      
            else
			{

			}        
            this.Size = new Size(1162, 831);

        }

        private void radioButtonDesign3_CheckedChanged(object sender, EventArgs e)
		{
            if (radioButtonDesign3.Checked == true)
            {
                panelGD1.Visible = true;
                panelGD2.Visible = true;
                panelGD3.Visible = true;
                txtTongTien1.Texts = txtSumCost.Texts;
                txt_timePay1.Texts = 1.ToString().Trim();
                txt_timePay2.Texts = 2.ToString().Trim();
                txt_timePay3.Texts = 3.ToString().Trim();
            }
            else
            {

            }
            this.Size = new Size(1175, 831);
        }

        private void txtPayMoney1_Leave(object sender, EventArgs e)
        {
            int TongTien = Convert.ToInt32(txtTongTien1.Texts.Trim());
            int TienDu = TongTien - Convert.ToInt32(txtPayMoney1.Texts.Trim());
            txtTongTien2.Texts = TienDu.ToString();
            txtPayMoney2.Texts = TienDu.ToString();
        }

        private void txtPayMoney2__TextChanged(object sender, EventArgs e)
        {
            int TongTien = Convert.ToInt32(txtTongTien2.Texts.Trim());
            int TienDu = TongTien - Convert.ToInt32(txtPayMoney2.Texts.Trim());
            txtPayMoney3.Texts = TienDu.ToString().Trim();
            txtTongTien3.Texts = TienDu.ToString().Trim();
        }
    }
}
