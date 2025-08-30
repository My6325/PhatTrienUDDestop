using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWinForm2
{
    internal class BaiTap3
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s=ho+" "+ten;
        }
        public static long GiaiThua(int n)
        {
            long giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }
    }
}
