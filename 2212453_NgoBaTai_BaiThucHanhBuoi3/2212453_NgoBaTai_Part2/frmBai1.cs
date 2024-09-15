using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_Part2
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

		private void rdXanh_CheckedChanged(object sender, EventArgs e)
		{
			txtDonGia.Text = "22.000";
		}

		private void rdDo_CheckedChanged(object sender, EventArgs e)
		{
			txtDonGia.Text = "21.000";
		}

		private void rdTrang_CheckedChanged(object sender, EventArgs e)
		{
			txtDonGia.Text = "20.000";
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
			int SoTien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
			lblSoTien.Text = SoTien.ToString();
		}
	}
}
