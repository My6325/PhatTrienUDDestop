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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.ParseExact("03/06/2005", "dd/MM/yyyy", null);
            SanPham sp = new SanPham();
            sp.MaSanPham = "SP01";
            sp.TenSanPham = "\nDầu ăn";
            sp.LoaiSanPham = "\nNấu ăn";
            sp.NgaySanXuat = dateTime;
            lbHienThi.Text = sp.HienThi();
            lbHH.Text = sp.NamHetHan().ToString();
        }      
    }
}
