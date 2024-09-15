namespace _2212453_NgoBaTai_Part3_BT2
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
			this.lblThongTin = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblThanhTien = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(45, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thông tin thiết bị:";
			// 
			// lblThongTin
			// 
			this.lblThongTin.AutoSize = true;
			this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblThongTin.Location = new System.Drawing.Point(189, 51);
			this.lblThongTin.Name = "lblThongTin";
			this.lblThongTin.Size = new System.Drawing.Size(12, 17);
			this.lblThongTin.TabIndex = 1;
			this.lblThongTin.Text = ".";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(45, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Thành tiền:";
			// 
			// lblThanhTien
			// 
			this.lblThanhTien.AutoSize = true;
			this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblThanhTien.Location = new System.Drawing.Point(189, 83);
			this.lblThanhTien.Name = "lblThanhTien";
			this.lblThanhTien.Size = new System.Drawing.Size(12, 17);
			this.lblThanhTien.TabIndex = 3;
			this.lblThanhTien.Text = ".";
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 261);
			this.Controls.Add(this.lblThanhTien);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblThongTin);
			this.Controls.Add(this.label1);
			this.Name = "frmBai1";
			this.Text = "Bài 1";
			this.Load += new System.EventHandler(this.frmBai1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblThongTin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblThanhTien;
	}
}