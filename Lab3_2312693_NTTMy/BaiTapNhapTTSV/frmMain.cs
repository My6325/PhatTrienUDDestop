using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using static BaiTapNhapTTSV.SinhVien;

namespace BaiTapNhapTTSV
{
    public partial class frmTTSV : Form
    {
        private QuanLySinhVien qlsv = new QuanLySinhVien();
        private string filenametxt = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\DSSV.txt"));
        private string filenamejson = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\DSSV.json"));
        private string filenamexml = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\DSSV.xml"));
        private string mon = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\MonHoc.txt"));

        public frmTTSV()
        {
            InitializeComponent();
        }

        private void frmTTSV_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            LoadMonHoc();
            qlsv.DocTuFile(filenametxt);
            //qlsv.DocTuFileJson(filenamejson);
            //qlsv.DocTuFileXml(filenamexml);
            LoadListView();
        }
        public List<string> GetDanhSachMonHoc()
        {
            List<string> monHocList = new List<string>();

            if (File.Exists(mon))
            {
                try
                {
                    var monHoc = File.ReadAllLines(mon);
                    foreach (var m in monHoc)
                    {
                        if (!string.IsNullOrWhiteSpace(m))
                            monHocList.Add(m.Trim());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đọc file môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return monHocList;
        }
        private void LoadMonHoc()
        {
            checkedListBoxMonHoc.Items.Clear();
            List<string> dsMonHoc = GetDanhSachMonHoc();
            /*if (File.Exists(mon))
            {
                var monHoc = File.ReadAllLines(mon);
                foreach (var m in monHoc)
                {
                    if (!string.IsNullOrWhiteSpace(m)) 
                        checkedListBoxMonHoc.Items.Add(m.Trim());
                }
            }
            else
            {
                MessageBox.Show("File môn học không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            if (dsMonHoc.Count > 0)
            {
                foreach (var m in dsMonHoc)
                {
                    // Đổ vào CheckedListBox bên frmTTSV
                    checkedListBoxMonHoc.Items.Add(m);
                }
            }
            else if (!File.Exists(mon))
            {
                MessageBox.Show("File môn học không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoTenLot ?? "");
            lvitem.SubItems.Add(sv.Ten ?? "");
            lvitem.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            string gt = sv.GioiTinh ? "Nam" : "Nữ";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.Lop ?? "");
            lvitem.SubItems.Add(sv.CMND);
            lvitem.SubItems.Add(sv.SoDienThoai);
            lvitem.SubItems.Add(sv.DiaChi ?? "");
            string mh = "";
            if (sv.MonHoc != null && sv.MonHoc.Count > 0)
                mh = string.Join("; ", sv.MonHoc);
            lvitem.SubItems.Add(mh);
            listViewDSSV.Items.Add(lvitem);
        }
        private void LoadListView()
        {
            listViewDSSV.Items.Clear();
            foreach (SinhVien sv in qlsv.dssv)
            {
                ThemSV(sv);
            }
        }
        private SinhVien LayTTSinhVienFromList(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HoTenLot = lvitem.SubItems[1].Text;
            sv.Ten = lvitem.SubItems[2].Text;
            sv.NgaySinh = DateTime.ParseExact(lvitem.SubItems[3].Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            sv.GioiTinh = false;
            if (lvitem.SubItems[4].Text == "Nam")
                sv.GioiTinh = true;
            sv.Lop = lvitem.SubItems[5].Text;
            sv.CMND = lvitem.SubItems[6].Text;
            sv.SoDienThoai = lvitem.SubItems[7].Text;
            sv.DiaChi = lvitem.SubItems[8].Text;
            List<string> mh = new List<string>();
            string[] s = lvitem.SubItems[9].Text.Trim().Split(';');
            foreach (string t in s)
                mh.Add(t);
            sv.MonHoc = mh;
            return sv;
        }

        private void DienTTFromLV(SinhVien sv)
        {
            mtbMSSV.Text = sv.MSSV;
            txtHoTenLot.Text = sv.HoTenLot;
            txtTen.Text = sv.Ten;
            dtNgaySinh.Format = DateTimePickerFormat.Custom;
            dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtNgaySinh.Value = sv.NgaySinh;
            if (sv.GioiTinh)
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            cbLop.Text = sv.Lop;
            mtbCMND.Text = sv.CMND;
            mtbSDT.Text = sv.SoDienThoai;
            txtDiaChi.Text = sv.DiaChi;
            for (int i = 0; i < checkedListBoxMonHoc.Items.Count; i++)
                checkedListBoxMonHoc.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBoxMonHoc.Items.Count; i++)
            {
                string itemText = checkedListBoxMonHoc.Items[i].ToString().Trim();
                //Check hết list 
                if (sv.MonHoc.Any(m => m.Trim() == itemText))
                {
                    checkedListBoxMonHoc.SetItemChecked(i, true);
                }
            }

        }
        private void listViewDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listViewDSSV.SelectedItems.Count;
            if (i > 0)
            {
                ListViewItem lvitem = listViewDSSV.SelectedItems[0];
                SinhVien sv = LayTTSinhVienFromList(lvitem);
                DienTTFromLV(sv);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool KTTTSinhVien()
        {
            if (string.IsNullOrWhiteSpace(mtbMSSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập MSSV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbMSSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTenLot.Text))
            {
                MessageBox.Show("Bạn chưa nhập Họ tên lót", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenLot.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa chọn Ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLop.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbLop.Text))
            {
                MessageBox.Show("Bạn chưa chọn Lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLop.Focus();
                return false;
            }
            if (!rdNam.Checked && !rdNu.Checked)
            {
                MessageBox.Show("Bạn chưa chọn Giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(mtbCMND.Text))
            {
                MessageBox.Show("Bạn chưa nhập CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbCMND.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(mtbSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập SĐT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbSDT.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ liên lạc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            if (checkedListBoxMonHoc.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn Môn học đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private SinhVien LayTTSV()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> mh = new List<string>();
            sv.MSSV = mtbMSSV.Text;
            sv.HoTenLot = txtHoTenLot.Text;
            sv.Ten = txtTen.Text;
            sv.NgaySinh = dtNgaySinh.Value;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            sv.Lop = cbLop.Text;
            sv.CMND = mtbCMND.Text;
            sv.SoDienThoai = mtbSDT.Text.Replace(".", "");
            sv.DiaChi = txtDiaChi.Text;
            for (int i = 0; i < checkedListBoxMonHoc.Items.Count; i++)
            {
                if (checkedListBoxMonHoc.GetItemChecked(i))
                    mh.Add(checkedListBoxMonHoc.Items[i].ToString());
            }

            sv.MonHoc = mh;
            return sv;
        }

        private void MacDinh()
        {
            mtbMSSV.Text = "";
            txtHoTenLot.Text = "";
            txtTen.Text = "";
            dtNgaySinh.Value = DateTime.Now;
            rdNam.Checked = true;
            cbLop.Text = cbLop.Items[0].ToString();
            mtbCMND.Text = "";
            mtbSDT.Text = "";
            txtDiaChi.Text = "";
            for (int i = 0; i < checkedListBoxMonHoc.Items.Count; i++)
                checkedListBoxMonHoc.SetItemChecked(i, false);
        }
        
        private void CapNhatFileTuDsSinhVien(string file)
        {
            using (StreamWriter sw = new StreamWriter(file, false, Encoding.UTF8))
            {
                foreach (SinhVien sv in qlsv.dssv)
                {
                    string hoTen = sv.HoTenLot + " " + sv.Ten;
                    string mh = sv.MonHoc != null && sv.MonHoc.Count > 0 ? string.Join(";", sv.MonHoc) : "";
                    string line = $"{sv.MSSV},{hoTen},{sv.NgaySinh:dd/MM/yyyy},{sv.GioiTinh},{sv.Lop},{sv.CMND},{sv.SoDienThoai},{sv.DiaChi},{mh}";
                    sw.WriteLine(line);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KTTTSinhVien())
                return;
            SinhVien sv = LayTTSV();
            if (!KiemTraDuLieu.KiemTraMSSV(sv.MSSV, sv.Lop))
            {
                MessageBox.Show("MSSV không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbMSSV.Focus();
                return;
            }
            if (!KiemTraDuLieu.KiemTraCMND(sv.CMND))
            {
                MessageBox.Show("CMND phải đúng 9 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbCMND.Focus();
                return;
            }
            if (!KiemTraDuLieu.KiemTraSDT(sv.SoDienThoai))
            {
                MessageBox.Show("Số điện thoại phải đúng 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbSDT.Focus();
                return;
            }
            if (qlsv.dssv.Any(x => x.MSSV == sv.MSSV))
            {
                MessageBox.Show("MSSV đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbMSSV.Focus();
                return;
            }
            if (qlsv.dssv.Any(x => x.CMND == sv.CMND))
            {
                MessageBox.Show("CMND đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbCMND.Focus();
                return;
            }
            if (qlsv.dssv.Any(x => x.SoDienThoai == sv.SoDienThoai))
            {
                MessageBox.Show("SĐT đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbSDT.Focus();
                return;
            }
            qlsv.ThemSV(sv);
            try
            {

                CapNhatFileTuDsSinhVien(filenametxt);
                MessageBox.Show("Thêm sinh viên thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu thông tin sinh viên!" + ex.Message);
            }
            LoadListView();
            MacDinh();
        }
        //Cập nhật thông tin sinh viên
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KTTTSinhVien())
                return;
            SinhVien sv = LayTTSV();
            bool kq = qlsv.CapNhatSV(sv, sv.MSSV, SoSanhTheoMa);
            if (!kq )
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã số trên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbMSSV.Focus();
                return;
            }
            try
            {
                CapNhatFileTuDsSinhVien(filenametxt);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật!" + ex.Message);
            }

            LoadListView();
            MacDinh();
        }

        private void checkedListBoxMonHoc_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = checkedListBoxMonHoc.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    checkedListBoxMonHoc.SelectedIndex = index;
                }
                else
                {
                    checkedListBoxMonHoc.ClearSelected();
                }
            }
        }
        
        //Thêm môn học
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newMon = Interaction.InputBox("Nhập tên môn học mới:", "Thêm môn học", "");
            if (newMon == null)
                return;
            newMon = newMon.Trim();
            if (string.IsNullOrEmpty(newMon))
            {
                MessageBox.Show("Bạn chưa nhập tên môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (checkedListBoxMonHoc.Items.Contains(newMon))
            {
                MessageBox.Show("Môn học này đã tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            checkedListBoxMonHoc.Items.Add(newMon);
            File.WriteAllLines(Path.GetFullPath(mon), checkedListBoxMonHoc.Items.Cast<string>());

        }
        //Xóa môn học
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkedItems = checkedListBoxMonHoc.CheckedItems.Cast<string>().ToList();

            if (checkedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa check môn học nào để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (var mhMuonXoa in checkedItems)
            {
                bool mhDaDK = qlsv.dssv.Any(sv => sv.MonHoc.Contains(mhMuonXoa));

                if (mhDaDK)
                {
                    DialogResult dr = MessageBox.Show($"Có sinh viên đã đăng ký môn '{mhMuonXoa}'. Bạn có muốn xóa không?","Cảnh báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        foreach (var sv in qlsv.dssv)
                        {
                            if (sv.MonHoc.Contains(mhMuonXoa))
                                sv.MonHoc.Remove(mhMuonXoa);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                checkedListBoxMonHoc.Items.Remove(mhMuonXoa);
            }

            File.WriteAllLines(Path.GetFullPath(mon), checkedListBoxMonHoc.Items.Cast<string>());
            CapNhatFileTuDsSinhVien(filenametxt);
            LoadListView();
            MessageBox.Show("Xóa môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<string> dsMon = GetDanhSachMonHoc();
            frmTimKiem frm = new frmTimKiem(qlsv.dssv,dsMon);
            frm.ShowDialog();
        }

        //Xóa sinh viên
        private void listViewDSSV_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = listViewDSSV.HitTest(e.Location);
                if (hit.Item != null)
                {
                    hit.Item.Selected = true;
                }
            }
        }
        private int SoSanhTheoMa(object sv1, object sv2)
        {
            SinhVien sv = sv2 as SinhVien;
            return sv.MSSV.CompareTo(sv1);
        }
        private void xóaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewDSSV.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (ListViewItem item in listViewDSSV.CheckedItems)
                {
                    string mssv = item.SubItems[0].Text; 

                    qlsv.Xoa(mssv, SoSanhTheoMa);
                    listViewDSSV.Items.Remove(item);
                }

                CapNhatFileTuDsSinhVien(filenametxt);
                LoadListView();
                MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
