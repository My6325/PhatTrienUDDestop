using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTGiangVien
{
    public delegate int SoSanh (object a, object b);
    internal class QuanLyGiangVien
    {
        List<GiangVien> dsGiangVien;
        public GiangVien this[int index]
        {
            get { return dsGiangVien[index]; }
            set { dsGiangVien[index] = value; }
        }
        public QuanLyGiangVien()
        {
            dsGiangVien = new List<GiangVien>();
        }
        public bool Them(GiangVien gv)
        {
            foreach(GiangVien gvien in dsGiangVien)
            {
                if (gvien.MaSo == gv.MaSo)
                    return false;
            }
            dsGiangVien.Add(gv);
            return true;
        }

    }
}
