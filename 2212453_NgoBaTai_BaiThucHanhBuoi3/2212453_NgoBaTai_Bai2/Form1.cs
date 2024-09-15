using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da chon gioi tinh nam", "Thong bao");
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da chon gioi tinh nu", "Thong bao");
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if(rbDo.Checked)
            {
                txtToMau.BackColor = Color.Red;
            }
            else
                txtToMau.BackColor = Color.Blue;
        }
	}
}
