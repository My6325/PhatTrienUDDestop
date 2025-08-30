using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWinForm2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat {  get; set; }
        public int DonGia {  get; set; }
        public int SoLuong { get; set; }
        public  ThietBi(string ma, string ten, string nuocSX, int donGia, int soLuong) 
        {
            this.MaThietBi = ma;
            this.TenThietBi = ten;
            this.NuocSanXuat = nuocSX;
            this.DonGia = donGia; 
            this.SoLuong = soLuong;
        }

        public int ThanhTien()
        {
            return DonGia*SoLuong;
        }
        public string HienThi()
        {
            return $"Mã thiết bị: {MaThietBi}\nTên thiết bị: {TenThietBi}\nNước SX: {NuocSanXuat}\nĐơn giá: {DonGia}\nSố lượng: {SoLuong}";
        }
    }
}
