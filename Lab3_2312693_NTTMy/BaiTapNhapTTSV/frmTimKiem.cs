using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapNhapTTSV
{
    public partial class frmTimKiem : Form
    {
        //private string mon = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\MonHoc.txt"));
        private List<SinhVien> dsSinhVien;
        private List<string> dsMonHoc;
        public frmTimKiem(List<SinhVien> dssv, List<string> dsMon)
        {
            InitializeComponent();
            this.dsSinhVien = dssv;
            this.dsMonHoc = dsMon;
            LoadKetQuaTimKiem(dsSinhVien);
        }
        private void LoadKetQuaTimKiem(List<SinhVien> ketQua)
        {
            lvTimThongtin.Items.Clear();
            foreach (SinhVien sv in ketQua)
            {
                ListViewItem lvitem = new ListViewItem(sv.MSSV);
                lvitem.SubItems.Add(sv.HoTenLot);
                lvitem.SubItems.Add(sv.Ten);
                lvitem.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                string gt = sv.GioiTinh ? "Nam" : "Nữ";
                lvitem.SubItems.Add(gt);
                lvitem.SubItems.Add(sv.Lop);
                lvitem.SubItems.Add(sv.CMND);
                lvitem.SubItems.Add(sv.SoDienThoai);
                lvitem.SubItems.Add(sv.DiaChi);
                string mh = "";
                if (sv.MonHoc != null && sv.MonHoc.Count > 0)
                    mh = string.Join("; ", sv.MonHoc);
                lvitem.SubItems.Add(mh);
                lvTimThongtin.Items.Add(lvitem);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            LoadMonHocToComboBox();
            dtNgay.CustomFormat = "dd/MM/yyyy";
            dtNgay.Format = DateTimePickerFormat.Custom;
        }
        private void LoadMonHocToComboBox()
        {
            cboMon.Items.Clear();

            if (dsMonHoc != null && dsMonHoc.Count > 0)
            {
                foreach (var m in dsMonHoc)
                {
                    cboMon.Items.Add(m);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            IEnumerable<SinhVien> ketQuaLoc = dsSinhVien.AsEnumerable();
            bool coTieuChi = false;
            if (ckbMSSV.Checked)
            {
                string mssvCanTim = mtbMSSV.Text.Trim();
                mssvCanTim = new string(mssvCanTim.Where(c => char.IsLetterOrDigit(c)).ToArray());

                ketQuaLoc = ketQuaLoc.Where(sv => sv.MSSV.Equals(mssvCanTim, StringComparison.OrdinalIgnoreCase));
                coTieuChi = true;
            }

            if (ckbLop.Checked)
            {
                string lopCanTim = cboLop.SelectedItem.ToString();
                ketQuaLoc = ketQuaLoc.Where(sv => sv.Lop.Equals(lopCanTim, StringComparison.OrdinalIgnoreCase));
                coTieuChi = true;
            }

            if (ckbHoLot.Checked)
            {
                string hoLot = txtHoLot.Text.Trim();
                ketQuaLoc = ketQuaLoc.Where(sv => sv.HoTenLot.IndexOf(hoLot, StringComparison.OrdinalIgnoreCase) >= 0);
                coTieuChi = true;
            }

            if (ckbTen.Checked)
            {
                string ten = txtTen.Text.Trim();
                ketQuaLoc = ketQuaLoc.Where(sv => sv.Ten.IndexOf(ten, StringComparison.OrdinalIgnoreCase) >= 0);
                coTieuChi = true;
            }

            if (ckbNgaySinh.Checked)
            {
                DateTime ngaySinhCanTim = dtNgay.Value.Date;
                ketQuaLoc = ketQuaLoc.Where(sv => sv.NgaySinh.Date == ngaySinhCanTim);
                coTieuChi = true;
            }

            if (rdNam.Checked || rdNu.Checked)
            {
                bool gtCanTim = rdNam.Checked;
                ketQuaLoc = ketQuaLoc.Where(sv => sv.GioiTinh == gtCanTim);
                coTieuChi = true;
            }

            if (ckbCMND.Checked)
            {
                string cmndCanTim = mtbCMND.Text.Trim();
                cmndCanTim = new string(cmndCanTim.Where(c => char.IsDigit(c)).ToArray());

                ketQuaLoc = ketQuaLoc.Where(sv => sv.CMND.Equals(cmndCanTim, StringComparison.OrdinalIgnoreCase));
                coTieuChi = true;
            }

            if (ckbSDT.Checked)
            {
                string sdtCanTim = mtbSDT.Text.Trim();
                sdtCanTim = new string(sdtCanTim.Where(c => char.IsDigit(c)).ToArray());

                ketQuaLoc = ketQuaLoc.Where(sv => sv.SoDienThoai.Equals(sdtCanTim, StringComparison.OrdinalIgnoreCase));
                coTieuChi = true;
            }

            if (ckbDC.Checked)
            {
                string diaChiCanTim = txtDC.Text.Trim();
                ketQuaLoc = ketQuaLoc.Where(sv => sv.DiaChi.IndexOf(diaChiCanTim, StringComparison.OrdinalIgnoreCase) >= 0);
                coTieuChi = true;
            }

            if (ckbMonHoc.Checked)
            {
                string monHocCanTim = cboMon.SelectedItem.ToString();
                ketQuaLoc = ketQuaLoc.Where(sv => sv.MonHoc != null && sv.MonHoc.Contains(monHocCanTim));
                coTieuChi = true;
            }


            if (!coTieuChi)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<SinhVien> ketQuaCuoiCung = ketQuaLoc.ToList();
            LoadKetQuaTimKiem(ketQuaCuoiCung); 

            if (ketQuaCuoiCung.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên nào phù hợp", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
