using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDanDocFileJSon
{
    public class Student
    {
        public string MSSV {  get; set; }
        public string HoTen { get; set; }
        public int Tuoi {  get; set; }
        public double Diem {  get; set; }
        public bool TonGiao {  get; set; }
        public Student(string mSSV, string hoTen, int tuoi, double diem, bool tonGiao)
        {
            MSSV = mSSV;
            HoTen = hoTen;
            Tuoi = tuoi;
            Diem = diem;
            TonGiao = tonGiao;
        }
    }
}
