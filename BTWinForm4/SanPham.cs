using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWinForm4
{
    internal class SanPham
    {
        public string MaSanPham {  get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat {  get; set; }

        public SanPham() { }
        public int NamHetHan()
        {
            return NgaySanXuat.AddYears(3).Year;
        }
        public string HienThi()
        {
            return $"Mã sản phầm: {MaSanPham}\nTên sản phẩm: {TenSanPham}\nLoại sản phẩm: {LoaiSanPham}\nNgày sản xuất: {NgaySanXuat}";
        }
    }
}
