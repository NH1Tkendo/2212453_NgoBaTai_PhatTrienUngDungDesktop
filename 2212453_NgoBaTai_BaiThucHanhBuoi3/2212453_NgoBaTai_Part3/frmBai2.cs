﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_Part3
{
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void cboHang_SelectedIndexChanged(object sender, EventArgs e)
		{
			var stt=cboHang.SelectedIndex;

			switch (stt)
			{
				case 0:
					txtDonGia.Text = "100000";
					break;
				case 1:
					txtDonGia.Text = "2000000";
					break;
				case 2:
					txtDonGia.Text = "150000";
					break;
			}
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
			int donGia = int.Parse(txtDonGia.Text);
			int soLuong = int.Parse(txtSoLuong.Text);
			double thanhTien = donGia * soLuong;

			if (rdChuyenKhoan.Checked)
				thanhTien = donGia * soLuong * 0.95;

			lblSoTien.Text= thanhTien.ToString();
			
		}
	}
}
