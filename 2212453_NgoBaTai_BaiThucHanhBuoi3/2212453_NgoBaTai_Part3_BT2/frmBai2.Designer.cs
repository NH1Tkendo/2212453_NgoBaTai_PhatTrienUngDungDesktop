namespace _2212453_NgoBaTai_Part3_BT2
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
			this.txtSoThuHai = new System.Windows.Forms.TextBox();
			this.txtSoThuNhat = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdCong = new System.Windows.Forms.RadioButton();
			this.rdTru = new System.Windows.Forms.RadioButton();
			this.rdChia = new System.Windows.Forms.RadioButton();
			this.rdNhan = new System.Windows.Forms.RadioButton();
			this.btnKetQua = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(75, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số thứ nhất:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(82, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số thứ hai:";
			// 
			// txtSoThuHai
			// 
			this.txtSoThuHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoThuHai.Location = new System.Drawing.Point(167, 83);
			this.txtSoThuHai.Name = "txtSoThuHai";
			this.txtSoThuHai.Size = new System.Drawing.Size(100, 23);
			this.txtSoThuHai.TabIndex = 2;
			this.txtSoThuHai.Text = "0";
			// 
			// txtSoThuNhat
			// 
			this.txtSoThuNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoThuNhat.Location = new System.Drawing.Point(167, 44);
			this.txtSoThuNhat.Name = "txtSoThuNhat";
			this.txtSoThuNhat.Size = new System.Drawing.Size(100, 23);
			this.txtSoThuNhat.TabIndex = 3;
			this.txtSoThuNhat.Text = "0";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdChia);
			this.groupBox1.Controls.Add(this.rdNhan);
			this.groupBox1.Controls.Add(this.rdTru);
			this.groupBox1.Controls.Add(this.rdCong);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(167, 122);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(139, 114);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Các phép toán";
			// 
			// rdCong
			// 
			this.rdCong.AutoSize = true;
			this.rdCong.Checked = true;
			this.rdCong.Location = new System.Drawing.Point(15, 19);
			this.rdCong.Name = "rdCong";
			this.rdCong.Size = new System.Drawing.Size(57, 21);
			this.rdCong.TabIndex = 0;
			this.rdCong.TabStop = true;
			this.rdCong.Text = "cộng";
			this.rdCong.UseVisualStyleBackColor = true;
			// 
			// rdTru
			// 
			this.rdTru.AutoSize = true;
			this.rdTru.Location = new System.Drawing.Point(15, 42);
			this.rdTru.Name = "rdTru";
			this.rdTru.Size = new System.Drawing.Size(48, 21);
			this.rdTru.TabIndex = 1;
			this.rdTru.Text = "Trừ";
			this.rdTru.UseVisualStyleBackColor = true;
			// 
			// rdChia
			// 
			this.rdChia.AutoSize = true;
			this.rdChia.Location = new System.Drawing.Point(15, 88);
			this.rdChia.Name = "rdChia";
			this.rdChia.Size = new System.Drawing.Size(54, 21);
			this.rdChia.TabIndex = 0;
			this.rdChia.Text = "Chia";
			this.rdChia.UseVisualStyleBackColor = true;
			// 
			// rdNhan
			// 
			this.rdNhan.AutoSize = true;
			this.rdNhan.Location = new System.Drawing.Point(15, 65);
			this.rdNhan.Name = "rdNhan";
			this.rdNhan.Size = new System.Drawing.Size(60, 21);
			this.rdNhan.TabIndex = 1;
			this.rdNhan.Text = "Nhân";
			this.rdNhan.UseVisualStyleBackColor = true;
			// 
			// btnKetQua
			// 
			this.btnKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKetQua.Location = new System.Drawing.Point(167, 253);
			this.btnKetQua.Name = "btnKetQua";
			this.btnKetQua.Size = new System.Drawing.Size(100, 23);
			this.btnKetQua.TabIndex = 5;
			this.btnKetQua.Text = "Xem kết quả";
			this.btnKetQua.UseVisualStyleBackColor = true;
			this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(164, 295);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Kết quả là:";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKetQua.Location = new System.Drawing.Point(257, 295);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(12, 17);
			this.lblKetQua.TabIndex = 7;
			this.lblKetQua.Text = ".";
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 368);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnKetQua);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoThuNhat);
			this.Controls.Add(this.txtSoThuHai);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai2";
			this.Text = "Bài 2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSoThuHai;
		private System.Windows.Forms.TextBox txtSoThuNhat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdChia;
		private System.Windows.Forms.RadioButton rdNhan;
		private System.Windows.Forms.RadioButton rdTru;
		private System.Windows.Forms.RadioButton rdCong;
		private System.Windows.Forms.Button btnKetQua;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblKetQua;
	}
}