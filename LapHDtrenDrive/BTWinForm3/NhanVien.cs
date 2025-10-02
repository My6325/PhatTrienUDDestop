using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWinForm3
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen {  get; set; }
        public DateTime NgaySinh { get; set; }
        public int HeSoLuong { get; set; }
        public int HeSoPhuCap { get; set; }
        public NhanVien(string ma, string hoTen, DateTime ngaySinh, int hsLuong, int hsPhuCap)
        {
            MaNV=ma;
            HoTen=hoTen;
            NgaySinh=ngaySinh;
            HeSoLuong=hsLuong;
            HeSoPhuCap=hsPhuCap;
        }
        public int TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }
        public string HienThi()
        {
            return $"Mã nhân viên: {MaNV}\nHọ tên nhân viên: {HoTen}\nNgày sinh: {NgaySinh}\nHệ số lương: {HeSoLuong}\nHệ số phụ cấp: {HeSoPhuCap}";
        }
    }
}
