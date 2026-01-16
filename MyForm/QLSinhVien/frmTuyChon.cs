using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmTuyChon : Form
    {
        public TuyChon Kieu;
        public string ChuoiTim;
        public enum TuyChon
        {
            MaSV,
            HoTen,
            NgaySinh
        }
        public frmTuyChon()
        {
            InitializeComponent();
        }

        private void frmTuyChon_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (rdbtnMaSV.Checked)
                Kieu = TuyChon.MaSV;
            else if (rdbtnHoTen.Checked)
                Kieu = TuyChon.HoTen;
            else Kieu = TuyChon.NgaySinh;
            this.DialogResult = DialogResult.OK;
        }

        

        private void btnTimTT_Click(object sender, EventArgs e)
        {
            string tt = txtNhapThongTin.Text.Trim();
            if (string.IsNullOrWhiteSpace(tt))
            {
                MessageBox.Show("Hãy nhập thông tin tìm!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.ChuoiTim = tt;
            if (rdbtnMaSV.Checked)
                Kieu = TuyChon.MaSV;
            else if (rdbtnHoTen.Checked)
                Kieu = TuyChon.HoTen;
            else
                Kieu = TuyChon.NgaySinh;

            this.DialogResult = DialogResult.Yes;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
