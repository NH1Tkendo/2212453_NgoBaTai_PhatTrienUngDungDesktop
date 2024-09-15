using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212453_NgoBaTai_Part3_BT2
{
	internal class ThietBi
	{
		public string MaThietBi {  get; set; }
		public string TenThietBi { get; set; }
		public string NuocSanXuat {  get; set; }
		public double DonGia {  get; set; }
		public int SoLuong { get; set; }
		public ThietBi(string maThietBi, string tenThietBi, string nuocSanXuat, double donGia, int soLuong)
		{
			this.MaThietBi = maThietBi;
			this.TenThietBi = tenThietBi;
			this.NuocSanXuat = nuocSanXuat;
			this.DonGia = donGia;
			this.SoLuong = soLuong;
		}
		public double ThanhTien(double DonGia, int SoLuong)
		{
			return DonGia * SoLuong;
		}
		public string HienThi()
		{
			return string.Format("{0}, {1}, {2}, {3}, {4}", MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
		}
	}
}
