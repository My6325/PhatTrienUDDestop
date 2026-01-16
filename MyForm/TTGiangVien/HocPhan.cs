using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTGiangVien
{
    public class HocPhan
    {
        public int ID {  get; set; }
        public int SoTC { get; set; }
        public string TenHP {  get; set; }
        public HocPhan(int id,int tc, string ten)
        {
            this.ID = id;
            this.SoTC = tc;
            this.TenHP = ten;
        }
        public HocPhan(string ten)
        { 
            this.TenHP = ten;
        }
        public override string ToString()
        {
            return TenHP;
        }
    }
}
