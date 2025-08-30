using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if(rdHoTen.Checked)
            {
                string ho = txtHo.Text;
                string ten = txtTen.Text;
                string hoTen = " ";
                BaiTap3.NoiChuoi(ho, ten, ref hoTen);
                lbKQ.Text = hoTen;
            }
            if(rdGiaiThua.Checked)
            {
                int n = int.Parse(txtN.Text);
                if (n >= 0)
                {
                    long ketQua = BaiTap3.GiaiThua(n);
                    lbKQ.Text = ketQua.ToString();
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }
    }
}
