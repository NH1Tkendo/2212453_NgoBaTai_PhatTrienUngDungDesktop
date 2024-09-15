using System;
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
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void frmBai1_Load(object sender, EventArgs e)
		{
			SanPham sp=new SanPham();
			sp.MaSanPham = "M001";
			sp.LoaiSanPham = "Kẹo";
			sp.TenSanPham = "Kẹo dẻo";
			sp.NgaySanXuat = DateTime.Parse("12/12/2024");

			lblThongTin.Text = sp.HienThi();
		}
	}
}
