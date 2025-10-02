using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa hh=new HangHoa();
            hh.MaHang = "H01";
            hh.TenHang = "Dầu ăn";
            hh.DVT = "chai";
            hh.SoLuong = 20;
            hh.DonGia = 200000;
            lbThongbao.Text = hh.HienThi();
        }
    }
}
