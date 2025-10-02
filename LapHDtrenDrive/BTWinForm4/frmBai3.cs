using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm4
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            string hoTen = txtNhapHT.Text;
            bool gioiTinhNam = rdNam.Checked; 
            BaiTap3.ChaoHoi(hoTen, gioiTinhNam);
        }

        private void btnUSCLN_Click(object sender, EventArgs e)
        {
            int m=int.Parse(txtNhap1.Text);
            int n=int.Parse(txtNhap2.Text);
            string kq = BaiTap3.USCLN(m, n).ToString();
            MessageBox.Show("Ước số chung lớn nhất là: "+kq, "Thông báo");
        }
    }
}
