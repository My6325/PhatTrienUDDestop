using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm3
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            if(rdTachChuoi.Checked)
            {
                string ho = "";
                string ten = "";
                string hoTen=txtNhap.Text;
                BaiTap3.TachChuoi(hoTen, ref ho,ref ten);
                lbKQ.Text = "Họ: " + ho+ "\nTên: " + ten;
            }
            else
            {
                int s1=int.Parse(txtNhap1.Text);
                int s2=int.Parse(txtNhap2.Text);
                bool kq=BaiTap3.ThuTu(s1, s2);
                if (kq == true)
                    lbKQ.Text = "Số " + s1 + " và số " + s2 + " là 2 số liên tiếp";
                else
                    lbKQ.Text = "Số " + s1 + " và số " + s2 + " không là 2 số liên tiếp";
            }
        }
    }
}
