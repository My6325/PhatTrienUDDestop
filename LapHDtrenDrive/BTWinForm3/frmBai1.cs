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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            DateTime dateTime= DateTime.Parse("06/03/2005");
            NhanVien nv = new NhanVien("2312693", "Nguyễn Thị Trà My",dateTime, 2, 3);
            lbHTThongTin.Text = nv.HienThi();
            lbTong.Text = nv.TongLuong().ToString();
        }
    }
}
