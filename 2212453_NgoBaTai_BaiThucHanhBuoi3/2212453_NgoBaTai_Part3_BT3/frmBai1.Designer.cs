namespace _2212453_NgoBaTai_Part3_BT3
{
	partial class frmBai1
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblLuong = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblThongTin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thông tin nhân viên:";
			// 
			// lblLuong
			// 
			this.lblLuong.AutoSize = true;
			this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLuong.Location = new System.Drawing.Point(205, 91);
			this.lblLuong.Name = "lblLuong";
			this.lblLuong.Size = new System.Drawing.Size(12, 17);
			this.lblLuong.TabIndex = 1;
			this.lblLuong.Text = ".";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(44, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tính lương";
			// 
			// lblThongTin
			// 
			this.lblThongTin.AutoSize = true;
			this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblThongTin.Location = new System.Drawing.Point(205, 49);
			this.lblThongTin.Name = "lblThongTin";
			this.lblThongTin.Size = new System.Drawing.Size(12, 17);
			this.lblThongTin.TabIndex = 3;
			this.lblThongTin.Text = ".";
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 155);
			this.Controls.Add(this.lblThongTin);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblLuong);
			this.Controls.Add(this.label1);
			this.Name = "frmBai1";
			this.Text = "Bài 1";
			this.Load += new System.EventHandler(this.frmBai1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblLuong;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblThongTin;
	}
}