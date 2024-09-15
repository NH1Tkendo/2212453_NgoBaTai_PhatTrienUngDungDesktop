using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_Part3_BT4
{
	internal class Cau3_Bai4
	{
		public static void ChaoHoi(string hoTen, bool gioiTinh)
		{
			string loaiGioiTinh = gioiTinh ? "Ông" : "Bà";
			MessageBox.Show($"Chào {loaiGioiTinh} {hoTen}");
		}
		public static int USCLN(int m,int n)
		{
			while (n != 0)
			{
				int UCLN = m % n;
				m = n;
				n = UCLN;
			}
			return m;
		}
	}
}
