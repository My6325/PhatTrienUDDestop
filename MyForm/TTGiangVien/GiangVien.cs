using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTGiangVien
{
    public class GiangVien
    {
        public string HoTen { get; set; }
        public string MaSo {  get; set; }
        public DateTime NgaySinh { get; set; }

        public DanhSachHocPhan dsHocPhan;
        public string GioiTinh;
        public string Mail;
        public string[] NgoaiNgu;
        public string SoDT;

        public GiangVien() 
        { 
            dsHocPhan=new DanhSachHocPhan();
            NgoaiNgu=new string[20];
        }

        public GiangVien(string maso, string sdt, string mail, string hoten, DateTime ngaysinh, DanhSachHocPhan ds,string gt, string[] nn)
        {
            this.MaSo=maso;
            this.HoTen = hoten;
            this.NgaySinh=ngaysinh;
            this.GioiTinh = gt;
            this.SoDT=sdt; 
            this.Mail=mail;
            this.dsHocPhan = ds;
            this.NgoaiNgu = nn;
        }
        public override string ToString()
        {
            string s = "Mã số: " + MaSo + "\n" + "Họ Tên: " + HoTen + "\n" + "Ngày sinh: " + NgaySinh + "\n" + "Giới tính: " + GioiTinh + "\n" + "Số ĐT: " + SoDT + "\n" + "Mail: " + Mail + "\n";
            string ngoaingu = "Ngoại ngữ: ";
            foreach (var v in NgoaiNgu)
                ngoaingu += v + "; ";
            string mon = "Danh sách môn dạy: ";
            foreach (var v in dsHocPhan.ds)
                mon += v + "; ";
            s += "\n" + ngoaingu + "\n" + mon;
            return s;
        }
    }
}
