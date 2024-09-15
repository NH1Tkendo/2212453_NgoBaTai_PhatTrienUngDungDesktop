namespace _2212453_NgoBaTai_Part3
{
	partial class frmBai3
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
			this.label3 = new System.Windows.Forms.Label();
			this.txtSoA = new System.Windows.Forms.TextBox();
			this.txtSoB = new System.Windows.Forms.TextBox();
			this.txtSoN = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTong1N = new System.Windows.Forms.RadioButton();
			this.rdTongAB = new System.Windows.Forms.RadioButton();
			this.btnKetQua = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số a:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(35, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số b:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(35, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Số n:";
			// 
			// txtSoA
			// 
			this.txtSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoA.Location = new System.Drawing.Point(104, 26);
			this.txtSoA.Name = "txtSoA";
			this.txtSoA.Size = new System.Drawing.Size(124, 23);
			this.txtSoA.TabIndex = 3;
			this.txtSoA.Text = "0";
			// 
			// txtSoB
			// 
			this.txtSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoB.Location = new System.Drawing.Point(104, 55);
			this.txtSoB.Name = "txtSoB";
			this.txtSoB.Size = new System.Drawing.Size(124, 23);
			this.txtSoB.TabIndex = 4;
			this.txtSoB.Text = "0";
			// 
			// txtSoN
			// 
			this.txtSoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoN.Location = new System.Drawing.Point(104, 84);
			this.txtSoN.Name = "txtSoN";
			this.txtSoN.Size = new System.Drawing.Size(124, 23);
			this.txtSoN.TabIndex = 5;
			this.txtSoN.Text = "0";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTong1N);
			this.groupBox1.Controls.Add(this.rdTongAB);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(63, 135);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 80);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn phương thức tính toán";
			// 
			// rdTong1N
			// 
			this.rdTong1N.AutoSize = true;
			this.rdTong1N.Location = new System.Drawing.Point(6, 42);
			this.rdTong1N.Name = "rdTong1N";
			this.rdTong1N.Size = new System.Drawing.Size(145, 21);
			this.rdTong1N.TabIndex = 1;
			this.rdTong1N.TabStop = true;
			this.rdTong1N.Text = "Tính tổng từ 1 tới n";
			this.rdTong1N.UseVisualStyleBackColor = true;
			// 
			// rdTongAB
			// 
			this.rdTongAB.AutoSize = true;
			this.rdTongAB.Checked = true;
			this.rdTongAB.Location = new System.Drawing.Point(6, 19);
			this.rdTongAB.Name = "rdTongAB";
			this.rdTongAB.Size = new System.Drawing.Size(129, 21);
			this.rdTongAB.TabIndex = 0;
			this.rdTongAB.TabStop = true;
			this.rdTongAB.Text = "Tính tổng a và b";
			this.rdTongAB.UseVisualStyleBackColor = true;
			// 
			// btnKetQua
			// 
			this.btnKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKetQua.Location = new System.Drawing.Point(104, 230);
			this.btnKetQua.Name = "btnKetQua";
			this.btnKetQua.Size = new System.Drawing.Size(101, 23);
			this.btnKetQua.TabIndex = 7;
			this.btnKetQua.Text = "Xem kết quả";
			this.btnKetQua.UseVisualStyleBackColor = true;
			this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(60, 299);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Kết quả là:";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKetQua.Location = new System.Drawing.Point(161, 299);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(12, 17);
			this.lblKetQua.TabIndex = 9;
			this.lblKetQua.Text = ".";
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 450);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnKetQua);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoN);
			this.Controls.Add(this.txtSoB);
			this.Controls.Add(this.txtSoA);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "Bài 3";
			this.Load += new System.EventHandler(this.frmBai3_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSoA;
		private System.Windows.Forms.TextBox txtSoB;
		private System.Windows.Forms.TextBox txtSoN;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTong1N;
		private System.Windows.Forms.RadioButton rdTongAB;
		private System.Windows.Forms.Button btnKetQua;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblKetQua;
	}
}