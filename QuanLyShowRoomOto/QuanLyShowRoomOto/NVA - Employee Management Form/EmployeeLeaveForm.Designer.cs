
namespace QuanLyShowRoomOto
{
	partial class EmployeeLeaveForm
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
            this.labelEmployeeLeave = new System.Windows.Forms.Label();
            this.panelEmployeeLeave = new System.Windows.Forms.Panel();
            this.dataGridViewEmployeeLeave = new System.Windows.Forms.DataGridView();
            this.panelEmployeeLeave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmployeeLeave
            // 
            this.labelEmployeeLeave.AutoSize = true;
            this.labelEmployeeLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeLeave.Location = new System.Drawing.Point(367, 76);
            this.labelEmployeeLeave.Name = "labelEmployeeLeave";
            this.labelEmployeeLeave.Size = new System.Drawing.Size(533, 39);
            this.labelEmployeeLeave.TabIndex = 4;
            this.labelEmployeeLeave.Text = "Danh sách nhân viên đã nghỉ việc";
            // 
            // panelEmployeeLeave
            // 
            this.panelEmployeeLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmployeeLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.panelEmployeeLeave.Controls.Add(this.dataGridViewEmployeeLeave);
            this.panelEmployeeLeave.Location = new System.Drawing.Point(57, 176);
            this.panelEmployeeLeave.Name = "panelEmployeeLeave";
            this.panelEmployeeLeave.Size = new System.Drawing.Size(1170, 523);
            this.panelEmployeeLeave.TabIndex = 3;
            // 
            // dataGridViewEmployeeLeave
            // 
            this.dataGridViewEmployeeLeave.AllowUserToAddRows = false;
            this.dataGridViewEmployeeLeave.AllowUserToDeleteRows = false;
            this.dataGridViewEmployeeLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployeeLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployeeLeave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.dataGridViewEmployeeLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeLeave.Location = new System.Drawing.Point(15, 27);
            this.dataGridViewEmployeeLeave.Name = "dataGridViewEmployeeLeave";
            this.dataGridViewEmployeeLeave.ReadOnly = true;
            this.dataGridViewEmployeeLeave.RowHeadersVisible = false;
            this.dataGridViewEmployeeLeave.Size = new System.Drawing.Size(1140, 476);
            this.dataGridViewEmployeeLeave.TabIndex = 0;
            // 
            // EmployeeLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1282, 731);
            this.Controls.Add(this.labelEmployeeLeave);
            this.Controls.Add(this.panelEmployeeLeave);
            this.Name = "EmployeeLeaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeLeaveForm";
            this.Load += new System.EventHandler(this.EmployeeLeaveForm_Load);
            this.panelEmployeeLeave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelEmployeeLeave;
		private System.Windows.Forms.Panel panelEmployeeLeave;
		private System.Windows.Forms.DataGridView dataGridViewEmployeeLeave;
	}
}