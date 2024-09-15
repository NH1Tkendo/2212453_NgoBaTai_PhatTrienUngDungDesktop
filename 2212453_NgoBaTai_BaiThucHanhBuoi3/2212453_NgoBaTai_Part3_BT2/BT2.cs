using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212453_NgoBaTai_Part3_BT2
{
	internal class BT2
	{
		public static void NoiChuoi(string ho, string ten,ref string s)
		{
			s = ho + ten;
		}
		public static long GiaiThua(int n)
		{
			int ketQua = 1;
			for (int i = n; i >= 1; i--)
			{
				ketQua *= i;
			}
			return ketQua;
		}
	}
}
