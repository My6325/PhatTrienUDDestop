using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTTForm1
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }
        private void frmBai1_Load(object sender, EventArgs e)
        {
            rdbtnXanh.Checked = true;
        }
        private void rdbtnXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
            pictureXe.Image = Image.FromFile(@"Image\Buggati_Divo_blue.jpg");

        }

        private void rdbtnDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "21000";
            pictureXe.Image = Image.FromFile(@"Image\Buggati_Divo_red.jpg");
        }

        private void rdbtnTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
            pictureXe.Image = Image.FromFile(@"Image\Buggati_Divo_white.jpg");
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongTien=int.Parse(txtDonGia.Text)* int.Parse(txtSL.Text);
            lbTien.Text=tongTien.ToString();
        }

    }
}
