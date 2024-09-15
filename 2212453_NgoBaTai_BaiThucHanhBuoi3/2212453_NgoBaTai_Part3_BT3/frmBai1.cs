using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_Part3_BT3
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
			NhanVien nv = new NhanVien("2212453", "Ngô Bá Tài","17/11/2004", 10, 2.3);
			lblThongTin.Text=nv.HienThi();

			kq = nv.TinhLuong();
			lblLuong.Text=kq.ToString();
		}
	}
}
