namespace _2212453_NgoBaTai_Part3_BT3
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
			this.btnGiaiThua = new System.Windows.Forms.Button();
			this.lblGiaiThua = new System.Windows.Forms.Label();
			this.txtSo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTinhTong = new System.Windows.Forms.RadioButton();
			this.rdGiaiThua = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGiaiThua
			// 
			this.btnGiaiThua.Location = new System.Drawing.Point(215, 160);
			this.btnGiaiThua.Name = "btnGiaiThua";
			this.btnGiaiThua.Size = new System.Drawing.Size(75, 23);
			this.btnGiaiThua.TabIndex = 13;
			this.btnGiaiThua.Text = "Xem kết quả";
			this.btnGiaiThua.UseVisualStyleBackColor = true;
			this.btnGiaiThua.Click += new System.EventHandler(this.btnGiaiThua_Click);
			// 
			// lblGiaiThua
			// 
			this.lblGiaiThua.AutoSize = true;
			this.lblGiaiThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGiaiThua.Location = new System.Drawing.Point(302, 213);
			this.lblGiaiThua.Name = "lblGiaiThua";
			this.lblGiaiThua.Size = new System.Drawing.Size(12, 17);
			this.lblGiaiThua.TabIndex = 12;
			this.lblGiaiThua.Text = ".";
			// 
			// txtSo
			// 
			this.txtSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSo.Location = new System.Drawing.Point(260, 20);
			this.txtSo.Name = "txtSo";
			this.txtSo.Size = new System.Drawing.Size(155, 23);
			this.txtSo.TabIndex = 10;
			this.txtSo.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(212, 213);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 17);
			this.label8.TabIndex = 11;
			this.label8.Text = "Kết quả:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(201, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Nhập một số nguyên dương N:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdGiaiThua);
			this.groupBox1.Controls.Add(this.rdTinhTong);
			this.groupBox1.Location = new System.Drawing.Point(215, 61);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 81);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn công việc";
			// 
			// rdTinhTong
			// 
			this.rdTinhTong.AutoSize = true;
			this.rdTinhTong.Checked = true;
			this.rdTinhTong.Location = new System.Drawing.Point(6, 19);
			this.rdTinhTong.Name = "rdTinhTong";
			this.rdTinhTong.Size = new System.Drawing.Size(119, 17);
			this.rdTinhTong.TabIndex = 0;
			this.rdTinhTong.TabStop = true;
			this.rdTinhTong.Text = "Tính tổng 1+2+..+N";
			this.rdTinhTong.UseVisualStyleBackColor = true;
			// 
			// rdGiaiThua
			// 
			this.rdGiaiThua.AutoSize = true;
			this.rdGiaiThua.Location = new System.Drawing.Point(6, 48);
			this.rdGiaiThua.Name = "rdGiaiThua";
			this.rdGiaiThua.Size = new System.Drawing.Size(119, 17);
			this.rdGiaiThua.TabIndex = 1;
			this.rdGiaiThua.TabStop = true;
			this.rdGiaiThua.Text = "Tính N giai thừa(N!)";
			this.rdGiaiThua.UseVisualStyleBackColor = true;
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 284);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnGiaiThua);
			this.Controls.Add(this.lblGiaiThua);
			this.Controls.Add(this.txtSo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label2);
			this.Name = "frmBai2";
			this.Text = "Bài 2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGiaiThua;
		private System.Windows.Forms.Label lblGiaiThua;
		private System.Windows.Forms.TextBox txtSo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdGiaiThua;
		private System.Windows.Forms.RadioButton rdTinhTong;
	}
}