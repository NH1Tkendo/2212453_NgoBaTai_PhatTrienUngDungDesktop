﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_VD2
{
	public partial class frmTBGiaoVien : Form
	{
		public frmTBGiaoVien()
		{
			InitializeComponent();
		}
		public void SetText(string s)
		{
			this.lblThongBao.Text = s;
		}
	}
}
