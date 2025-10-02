using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Serialization;
using System.IO;
using static BaiTapNhapTTSV.SinhVien;

namespace BaiTapNhapTTSV
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QuanLySinhVien
    {
        public List<SinhVien> dssv;
        public QuanLySinhVien()
        {
            dssv = new List<SinhVien>();
        }
        public SinhVien this[int index]
        {
            get { return dssv[index]; }
            set { dssv[index] = value; }
        }
        
        public void DocTuFile(string filename)
        {
            string t;
            string[] s;
            using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open)))
            {
                while ((t = sr.ReadLine()) != null)
                {
                    SinhVien sv = new SinhVien();
                    s = t.Split(',');
                    sv.MSSV = s[0];
                    if (s.Length > 1)
                    {
                        var nameParts = s[1].Trim().Split(' ');
                        sv.Ten = nameParts.Last();
                        sv.HoTenLot = string.Join(" ", nameParts.Take(nameParts.Length - 1));
                    }
                    sv.NgaySinh = DateTime.ParseExact(s[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    if (s.Length > 3)
                        sv.GioiTinh = (s[3] == "1");
                    else
                        sv.GioiTinh = false;
                    sv.Lop = s.Length > 4 ? s[4] : "";
                    sv.CMND = s.Length > 5 ? s[5] : "";
                    sv.SoDienThoai = s.Length > 6 ? s[6] : "";
                    sv.DiaChi = s.Length > 7 ? s[7] : "";
                    if (s.Length > 8 && !string.IsNullOrWhiteSpace(s[8]))
                        sv.MonHoc = s[8].Split(';').ToList();
                    else
                        sv.MonHoc = new List<string>();
                    if (KiemTraDuLieu.KiemTraMSSV(sv.MSSV, sv.Lop)
                        && KiemTraDuLieu.KiemTraCMND(sv.CMND)
                        && KiemTraDuLieu.KiemTraSDT(sv.SoDienThoai)
                        && !dssv.Any(x => x.MSSV == sv.MSSV))   
                    {
                        ThemSV(sv);
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi dữ liệu sinh viên {sv.MSSV}, bỏ qua dòng này!");
                    }
                }
            }
        }
        public void DocTuFileJson(string filename)
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException("Không tìm thấy file JSON", filename);

            string json = File.ReadAllText(filename);

            List<SinhVien> dsTuFile = JsonConvert.DeserializeObject<List<SinhVien>>(json);

            if (dsTuFile != null)
            {
                foreach (var sv in dsTuFile)
                {
                    // kiểm tra hợp lệ trước khi thêm
                    if (KiemTraDuLieu.KiemTraMSSV(sv.MSSV, sv.Lop)
                        && KiemTraDuLieu.KiemTraCMND(sv.CMND)
                        && KiemTraDuLieu.KiemTraSDT(sv.SoDienThoai)
                        && !dssv.Any(x => x.MSSV == sv.MSSV))
                    {
                        dssv.Add(sv);
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi dữ liệu sinh viên {sv.MSSV}, bỏ qua dòng này!");
                    }
                }
            }
        }
        public void DocTuFileXml(string fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Không tìm thấy file XML!");
                return;
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<SinhVien>));
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    List<SinhVien> dsTuFile = (List<SinhVien>)serializer.Deserialize(fs);

                    foreach (var sv in dsTuFile)
                    {
                        if (KiemTraDuLieu.KiemTraMSSV(sv.MSSV, sv.Lop)
                            && KiemTraDuLieu.KiemTraCMND(sv.CMND)
                            && KiemTraDuLieu.KiemTraSDT(sv.SoDienThoai)
                            && !dssv.Any(x => x.MSSV == sv.MSSV))
                        {
                            dssv.Add(sv);
                        }
                        else
                        {
                            MessageBox.Show($"Lỗi dữ liệu sinh viên {sv.MSSV}, bỏ qua dòng này!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file XML: " + ex.Message);
            }
        }

        public void ThemSV(SinhVien sv)
        {
            dssv.Add(sv);
        }
        public void Xoa(object obj, SoSanh ss)
        {
            for (int i = dssv.Count - 1; i >= 0; i--)
            {
                if (ss(obj, this[i]) == 0)
                    dssv.RemoveAt(i);
            }
        }
        public bool CapNhatSV(SinhVien svCapNhat, object obj, SoSanh ss)
        {
            for (int i = 0; i < dssv.Count; i++)
            {
                if (ss(obj, dssv[i]) == 0)
                {
                    dssv[i].HoTenLot = svCapNhat.HoTenLot;
                    dssv[i].Ten = svCapNhat.Ten;
                    dssv[i].NgaySinh = svCapNhat.NgaySinh;
                    dssv[i].GioiTinh = svCapNhat.GioiTinh;
                    dssv[i].Lop = svCapNhat.Lop;
                    dssv[i].CMND = svCapNhat.CMND;
                    dssv[i].SoDienThoai = svCapNhat.SoDienThoai;
                    dssv[i].DiaChi = svCapNhat.DiaChi;
                    dssv[i].MonHoc = new List<string>(svCapNhat.MonHoc);
                    return true;
                }
            }
            return false;
        }
    }
}
