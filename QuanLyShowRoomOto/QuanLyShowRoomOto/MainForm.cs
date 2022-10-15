using FontAwesome.Sharp;
using QuanLyShowRoomOto.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShowRoomOto
{
	public partial class MainForm : Form
	{
		private IconButton currentBtn;
		private Panel leftBoderBtn;
		private Form currentChildForm;
		private struct RGBColor
		{
			public static Color color1 = Color.FromArgb(119, 44, 139);
			public static Color color2 = Color.FromArgb(160, 64, 102);
			public static Color color3 = Color.FromArgb(242, 70, 3);
			public static Color color4 = Color.FromArgb(2, 28, 70);
			public static Color color5 = Color.FromArgb(192, 69, 148);
			public static Color color6 = Color.FromArgb(32, 81, 18);
		}
		public MainForm()
		{
			InitializeComponent();
			leftBoderBtn = new Panel();
			leftBoderBtn.Size = new Size(7, 49);
			panelMenu.Controls.Add(leftBoderBtn);
		}

		private void ActivateButton(object sender, Color color)
		{
			if (sender != null)
			{
				DisableButton();

				currentBtn = (IconButton)sender;
				currentBtn.BackColor = Color.FromArgb(141, 223, 241);
				currentBtn.ForeColor = color;
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = color;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;

				leftBoderBtn.BackColor = color;
				leftBoderBtn.Location = new Point(0, currentBtn.Location.Y);
				leftBoderBtn.Visible = true;
				leftBoderBtn.BringToFront();

				iconCurrentChildForm.IconChar = currentBtn.IconChar;
				iconCurrentChildForm.IconColor = currentBtn.IconColor;
				//   labelTitleChildForm.Text = currentBtn.Text;
				//   labelTitleChildForm.ForeColor = currentBtn.ForeColor;
			}
		}
		private void DisableButton()
		{
			if (currentBtn != null)
			{
				currentBtn.BackColor = Color.FromArgb(192, 237, 250);
				currentBtn.ForeColor = Color.Black;
				currentBtn.TextAlign = ContentAlignment.MiddleLeft;
				currentBtn.IconColor = Color.Black;
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
		}
		private void OpenChildForm(Form childForm)
		{
			if (currentChildForm != null)
			{
				currentChildForm.Close();
			}
			currentChildForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelDesktop.Controls.Add(childForm);
			panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			labelTitleChildForm.Text = childForm.Text;
			labelMaNV.Text = "Welcome: " + Globals.loginName;
		}
		private void Reset()
		{
			DisableButton();
			leftBoderBtn.Visible = false;
			iconCurrentChildForm.IconChar = IconChar.Home;
			iconCurrentChildForm.IconColor = Color.FromArgb(192, 32, 110);
			labelTitleChildForm.Text = "Trang chủ";
		}
		private void iconButtonWarehouse_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColor.color2);
			OpenChildForm(new WarehouseForm());
		}

		private void iconButtonStaff_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColor.color3);
			OpenChildForm(new StaffForm());
		}

		private void iconButtonCustomer_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColor.color5);
            OpenChildForm(new FormCustomer());
        }

		private void pictureBoxHome_Click(object sender, EventArgs e)
		{
			Reset();
			OpenChildForm(new HomeForm());
		}

		private void iconButtonContract_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColor.color4);
			OpenChildForm(new FormContract());
		}

        private void iconButtonImportWarehouse_Click(object sender, EventArgs e)
        {
			ActivateButton(sender, RGBColor.color5);
			OpenChildForm(new ImportWarehouseForm());
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			pictureBoxHome.Image = Image.FromFile("../../Images/Nhom3.PNG");
			OpenChildForm(new HomeForm());
		}

		private void iconButtonRevenue_Click_1(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColor.color1);
			OpenChildForm(new RevenueForm());
		}

        private void IconButtonBaoDuong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            OpenChildForm(new FormBaoDuongFirst());
        }

        private void buttonDesignLogout_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				this.Close();
		}
    }
}
