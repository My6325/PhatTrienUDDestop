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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            double liThuyet= double.Parse(txtLT.Text);
            double thucHanh = double.Parse(txtTH.Text);
            double dtb = (liThuyet+thucHanh)/2;
            string xepLoai = "";
            if (liThuyet > 10 || thucHanh > 10)
            { MessageBox.Show("Điểm không được vượt quá 10", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (liThuyet < 5 || thucHanh < 5)
                xepLoai = "Yếu";
            else
            {
                if (dtb < 7) xepLoai="Trung Bình";
                else if (dtb>=7&&dtb<8) xepLoai="Khá";
                else if(dtb>=8&&dtb<9) xepLoai="Giỏi";
                else xepLoai="Xuất Sắc";
            }
            lbKQ.Text=xepLoai;
        }
    }
}
