﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_Part3_BT4
{
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		private void btnChay_Click(object sender, EventArgs e)
		{
			bool kq = true;
			if (rdNu.Checked) {
				kq = false;
			}
			Cau3_Bai4.ChaoHoi(txtHoTen.Text, kq);
			
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			int m=int.Parse(txtA.Text);
			int n=int.Parse(txtB.Text);
			int kq = 0;
			kq=Cau3_Bai4.USCLN(m, n);
			lblKetQua.Text=kq.ToString();
		}
	}
}
