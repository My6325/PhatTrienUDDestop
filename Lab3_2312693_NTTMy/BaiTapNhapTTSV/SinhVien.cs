using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhapTTSV
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTenLot { get; set; }
        public string Ten {  get; set; }
        public string HoTen
        {
            get
            {
                return string.Join(" ", new string[] { HoTenLot, Ten }.Where(x => !string.IsNullOrEmpty(x)));
            }
        }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh {  get; set; }
        public string Lop { get; set; }
        public string CMND {  get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public List<string> MonHoc { get; set; }
        public SinhVien()
        {
            MonHoc = new List<string>();
        }

        public SinhVien(string mSSV, string hoTen, DateTime ngaySinh, bool gioiTinh, string lop, string cMND, string soDienThoai, string diaChi, List<string> mh)
        {
            MSSV = mSSV;
            TachHoTen(hoTen);
            NgaySinh = ngaySinh;
            GioiTinh=gioiTinh;
            Lop = lop;
            CMND = cMND;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
            MonHoc = mh;
        }
        private void TachHoTen(string hoTen)
        {
            string[] parts = hoTen.Trim().Split(' ');
            if (parts.Length == 1)
            {
                HoTenLot = "";
                Ten = parts[0];
            }
            else
            {
                Ten = parts[parts.Length - 1];
                HoTenLot = string.Join(" ", parts, 0, parts.Length - 1);
            }
        }
        public static class KiemTraDuLieu
        {
            public static bool KiemTraMSSV(string mssv, string lop)
            {
                if (string.IsNullOrWhiteSpace(mssv) || mssv.Length != 7 || !mssv.All(char.IsDigit))
                    return false;
                if (string.IsNullOrWhiteSpace(lop) || lop.Length < 2) return false;

                string namNhapHocMSSV = mssv.Substring(0, 2);
                string phanCoDinh = mssv.Substring(2, 2);

                if (phanCoDinh != "10") return false;

                string digits = new string(lop.Where(char.IsDigit).ToArray());
                if (digits.Length < 2) return false;
                string khoaHoc = digits.Substring(0, 2);

                string namNhapHocLop = "";


                if (khoaHoc == "47") namNhapHocLop = "23";
                else if (khoaHoc == "46") namNhapHocLop = "22";
                else return false;

                return (namNhapHocMSSV == namNhapHocLop);
            }

            public static bool KiemTraCMND(string cmnd)
            {
                return !string.IsNullOrWhiteSpace(cmnd)
                       && cmnd.Length == 9
                       && cmnd.All(char.IsDigit);
            }

            public static bool KiemTraSDT(string sdt)
            {
                return !string.IsNullOrWhiteSpace(sdt)
                       && sdt.Length == 10
                       && sdt.All(char.IsDigit);
            }
        }
    }
}
