using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212453_NgoBaTai_Part3
{
	public class HangHoa
	{
		public string MaHang { get; set; }
		public string TenHang { get; set; }
		public string DVT { get; set; }
		public int SoLuong { get; set; }
		public double DonGia { get; set; }

		public HangHoa()
		{

		}
		public string HienThi()
		{
			return string.Format("{0}, {1}, {2}, {3}, {4}",MaHang,TenHang,DVT,SoLuong,DonGia);
		}
	}
}
