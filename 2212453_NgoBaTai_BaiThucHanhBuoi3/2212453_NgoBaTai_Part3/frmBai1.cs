using System;
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
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void frmBai1_Load(object sender, EventArgs e)
		{
			HangHoa hh = new HangHoa();
			hh.MaHang = "M001";
			hh.TenHang = "@@";
			hh.DVT = "Chiếc";
			hh.SoLuong = 100;
			hh.DonGia = 100000;

			lblThongBao.Text = hh.HienThi();
		}
	}
}
