﻿namespace _2212453_NgoBaTai_Part3_BT4
{
	partial class frmBai2
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtLyThuyet = new System.Windows.Forms.TextBox();
			this.txtThucHanh = new System.Windows.Forms.TextBox();
			this.btnXepLoai = new System.Windows.Forms.Button();
			this.lblXepLoai = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(104, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập điểm lý thuyết:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(95, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nhập điểm thực hành:";
			// 
			// txtLyThuyet
			// 
			this.txtLyThuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLyThuyet.Location = new System.Drawing.Point(247, 33);
			this.txtLyThuyet.Name = "txtLyThuyet";
			this.txtLyThuyet.Size = new System.Drawing.Size(100, 23);
			this.txtLyThuyet.TabIndex = 2;
			// 
			// txtThucHanh
			// 
			this.txtThucHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtThucHanh.Location = new System.Drawing.Point(247, 65);
			this.txtThucHanh.Name = "txtThucHanh";
			this.txtThucHanh.Size = new System.Drawing.Size(100, 23);
			this.txtThucHanh.TabIndex = 3;
			// 
			// btnXepLoai
			// 
			this.btnXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXepLoai.Location = new System.Drawing.Point(232, 105);
			this.btnXepLoai.Name = "btnXepLoai";
			this.btnXepLoai.Size = new System.Drawing.Size(75, 23);
			this.btnXepLoai.TabIndex = 4;
			this.btnXepLoai.Text = "Xếp loại";
			this.btnXepLoai.UseVisualStyleBackColor = true;
			this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
			// 
			// lblXepLoai
			// 
			this.lblXepLoai.AutoSize = true;
			this.lblXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblXepLoai.Location = new System.Drawing.Point(278, 149);
			this.lblXepLoai.Name = "lblXepLoai";
			this.lblXepLoai.Size = new System.Drawing.Size(12, 17);
			this.lblXepLoai.TabIndex = 5;
			this.lblXepLoai.Text = ".";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(133, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Kết quả xếp loại:";
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 233);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblXepLoai);
			this.Controls.Add(this.btnXepLoai);
			this.Controls.Add(this.txtThucHanh);
			this.Controls.Add(this.txtLyThuyet);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai2";
			this.Text = "Xếp loại";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLyThuyet;
		private System.Windows.Forms.TextBox txtThucHanh;
		private System.Windows.Forms.Button btnXepLoai;
		private System.Windows.Forms.Label lblXepLoai;
		private System.Windows.Forms.Label label4;
	}
}