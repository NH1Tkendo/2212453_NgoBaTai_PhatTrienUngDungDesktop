using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_Part3_BT2
{
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		private void btnGhepChuoi_Click(object sender, EventArgs e)
		{
			string a = txtChuoi1.Text;
			string b = txtChuoi2.Text;
			string kq = "";
			BT2.NoiChuoi(a, b, ref kq);
			lblGhepChuoi.Text = kq;
		}

		private void btnGiaiThua_Click(object sender, EventArgs e)
		{
			int a = int.Parse(txtSo.Text);
			long kq = 0;

			kq = BT2.GiaiThua(a);
			lblGiaiThua.Text = kq.ToString();
		}
	}
}
