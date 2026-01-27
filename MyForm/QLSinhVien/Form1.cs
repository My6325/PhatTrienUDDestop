using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLSinhVien.frmTuyChon;

namespace QLSinhVien
{
    public partial class frmSinhVien : Form
    {
        private QuanLySinhVien qlsv=new QuanLySinhVien();
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile("DanhSachSV.txt");
            LoadListView();
            toolStripStatuslblTongSV.Text="Tổng sinh viên: "+qlsv.dsSinhVien.Count.ToString();
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";
            cn = cn.Substring(0, cn.Length - 1);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lvitem);
        }
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach(SinhVien sv in qlsv.dsSinhVien)
            {
                ThemSV(sv);
            }    
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv=new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.mtxtMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh = this.txtHinh.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                if (clbChuyenNganh.GetItemChecked(i))
                    cn.Add(clbChuyenNganh.Items[i].ToString());
            }
            sv.ChuyenNganh = cn;
            return sv;
        }

        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;
            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach (string t in s)
                cn.Add(t);
            sv.ChuyenNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                    if (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
                        this.clbChuyenNganh.SetItemChecked(i, true);
            }
        }
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i=lvSinhVien.SelectedItems.Count;
            if(i>0)
            {
                ListViewItem lvitem = lvSinhVien.SelectedItems[0];
                SinhVien sv =GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }    
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMaSo.Text = "";                
            this.txtHoTen.Text = "";                
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";          
            this.cboLop.Text = this.cboLop.Items[0].ToString(); 
            this.txtHinh.Text = "";                
            this.pbHinh.ImageLocation = "";        
            this.rdNam.Checked = true;
            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                clbChuyenNganh.SetItemChecked(i, false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int SoSanhTheoMa(object sv1, object sv2)
        {
            SinhVien sv=sv2 as SinhVien;
            return sv.MaSo.CompareTo(sv1);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kqsua)
            {
                this.LoadListView();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();    
            qlsv.Them(sv);                  
            LoadListView();                 
            btnMacDinh.PerformClick();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogHinh = new OpenFileDialog();
            openFileDialogHinh.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            openFileDialogHinh.Title = "Chọn hình ảnh sinh viên";

            if (openFileDialogHinh.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = openFileDialogHinh.FileName; 
                pbHinh.ImageLocation = openFileDialogHinh.FileName; 
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void moFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBrowse.PerformClick();
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThem.PerformClick();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        private void suaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }
        private int SoSanhTheoMaSV(SinhVien x, SinhVien y)
        {
            return x.MaSo.CompareTo(y.MaSo);
        }

        private int SoSanhTheoHoTen(SinhVien x, SinhVien y)
        {
            return x.HoTen.CompareTo(y.HoTen);
        }

        private int SoSanhTheoNgaySinh(SinhVien x, SinhVien y)
        {
            return x.NgaySinh.CompareTo(y.NgaySinh);
        }

        private void toolStripMenuItemSapXep_Click(object sender, EventArgs e)
        {
            frmTuyChon frm=new frmTuyChon();
            foreach(Control c in frm.Controls)
            {
                if(c is GroupBox &&c.Name=="groupBoxTim")
                {
                    c.Enabled = false;
                    break;

                }    
            }    
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TuyChon tuyChon = frm.Kieu;
                switch (tuyChon)
                {
                    case TuyChon.MaSV:
                        qlsv.dsSinhVien.Sort(SoSanhTheoMaSV);
                        break;
                    case TuyChon.HoTen:
                        qlsv.dsSinhVien.Sort(SoSanhTheoHoTen);
                        break;
                    case TuyChon.NgaySinh:
                        qlsv.dsSinhVien.Sort(SoSanhTheoNgaySinh);
                        break;
                }
                LoadListView();
            }           
        }

        private void toolStripMenuItemTimKiem_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon();
            foreach (Control c in frm.Controls)
            {
                if (c is Button && c.Name == "btnSapXep")
                {
                    c.Enabled = false;
                    break;

                }
            }
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                TuyChon tuyChon = frm.Kieu;
                string chuoiTim = frm.ChuoiTim;
                List<SinhVien> ketQua = new List<SinhVien>();

                switch (tuyChon)
                {
                    case TuyChon.MaSV:
                        ketQua = qlsv.dsSinhVien
                            .Where(sv => !string.IsNullOrEmpty(sv.MaSo) &&
                                         sv.MaSo.ToLower().Contains(chuoiTim.ToLower()))
                            .ToList();
                        break;

                    case TuyChon.HoTen:
                        ketQua = qlsv.dsSinhVien
                            .Where(sv => !string.IsNullOrEmpty(sv.HoTen) &&
                                         sv.HoTen.ToLower().Contains(chuoiTim.ToLower()))
                            .ToList();
                        break;

                    case TuyChon.NgaySinh:
                        ketQua = qlsv.dsSinhVien
                            .Where(sv => sv.NgaySinh.ToShortDateString().Contains(chuoiTim))
                            .ToList();
                        break;

                }
                this.lvSinhVien.Items.Clear();
                foreach (SinhVien sv in ketQua)
                {
                    ThemSV(sv);
                    
                }
                MessageBox.Show($"Số sinh viên tìm thấy: {ketQua.Count}", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void toolStripMenuItemFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                lvSinhVien.Font = fontDialog.Font;
            }
        }

        private void toolStripMenuItemMauChu_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lvSinhVien.ForeColor = colorDialog.Color;
            }
        }
    }
}
