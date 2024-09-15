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
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void frmBai1_Load(object sender, EventArgs e)
		{
			double kq = 0;
			ThietBi tb = new ThietBi("M001","Chuột","Mỹ",50000,5);
			double donGia=tb.DonGia;
			int soLuong=tb.SoLuong;
			lblThongTin.Text=tb.HienThi();

			kq=tb.ThanhTien(donGia, soLuong);
			lblThanhTien.Text = kq.ToString();
		}
	}
}
