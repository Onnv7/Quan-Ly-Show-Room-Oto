
namespace QuanLyShowRoomOto
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCancel = new QuanLyShowRoomOto.ButtonDesign();
			this.buttonLogin = new QuanLyShowRoomOto.ButtonDesign();
			this.textBoxPass = new QuanLyShowRoomOto.TextBoxDesign();
			this.textBoxUsername = new QuanLyShowRoomOto.TextBoxDesign();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(191, 270);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(95, 17);
			this.checkBox1.TabIndex = 14;
			this.checkBox1.Text = "Hiện mật khẩu";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(79, 228);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 18);
			this.label2.TabIndex = 11;
			this.label2.Text = "Mật khẩu:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(79, 174);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 18);
			this.label1.TabIndex = 10;
			this.label1.Text = "Tên đăng nhập:";
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
			this.buttonCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
			this.buttonCancel.BorderColor = System.Drawing.Color.Black;
			this.buttonCancel.BorderRadius = 18;
			this.buttonCancel.BorderSize = 1;
			this.buttonCancel.FlatAppearance.BorderSize = 0;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCancel.ForeColor = System.Drawing.Color.Black;
			this.buttonCancel.Location = new System.Drawing.Point(76, 318);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(112, 32);
			this.buttonCancel.TabIndex = 13;
			this.buttonCancel.Text = "Thoát";
			this.buttonCancel.TextColor = System.Drawing.Color.Black;
			this.buttonCancel.UseVisualStyleBackColor = false;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonLogin
			// 
			this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
			this.buttonLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
			this.buttonLogin.BorderColor = System.Drawing.Color.Black;
			this.buttonLogin.BorderRadius = 18;
			this.buttonLogin.BorderSize = 1;
			this.buttonLogin.FlatAppearance.BorderSize = 0;
			this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.ForeColor = System.Drawing.Color.Black;
			this.buttonLogin.Location = new System.Drawing.Point(275, 318);
			this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(112, 32);
			this.buttonLogin.TabIndex = 12;
			this.buttonLogin.Text = "Đăng nhập";
			this.buttonLogin.TextColor = System.Drawing.Color.Black;
			this.buttonLogin.UseVisualStyleBackColor = false;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// textBoxPass
			// 
			this.textBoxPass.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.textBoxPass.BorderFocusColor = System.Drawing.Color.HotPink;
			this.textBoxPass.BorderSize = 2;
			this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPass.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxPass.Location = new System.Drawing.Point(191, 219);
			this.textBoxPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxPass.Multiline = false;
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.textBoxPass.PasswordChar = true;
			this.textBoxPass.Size = new System.Drawing.Size(196, 36);
			this.textBoxPass.TabIndex = 9;
			this.textBoxPass.Texts = "";
			this.textBoxPass.UnderlinedStyle = false;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.textBoxUsername.BorderFocusColor = System.Drawing.Color.HotPink;
			this.textBoxUsername.BorderSize = 2;
			this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUsername.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxUsername.Location = new System.Drawing.Point(191, 165);
			this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxUsername.Multiline = false;
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.textBoxUsername.PasswordChar = false;
			this.textBoxUsername.Size = new System.Drawing.Size(196, 36);
			this.textBoxUsername.TabIndex = 8;
			this.textBoxUsername.Texts = "";
			this.textBoxUsername.UnderlinedStyle = false;
			// 
			// iconPictureBox1
			// 
			this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(92)))), ((int)(((byte)(84)))));
			this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox1.IconSize = 111;
			this.iconPictureBox1.Location = new System.Drawing.Point(82, 12);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(305, 111);
			this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.iconPictureBox1.TabIndex = 15;
			this.iconPictureBox1.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(505, 361);
			this.Controls.Add(this.iconPictureBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.textBoxUsername);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox1;
		private ButtonDesign buttonCancel;
		private ButtonDesign buttonLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private TextBoxDesign textBoxPass;
		private TextBoxDesign textBoxUsername;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}