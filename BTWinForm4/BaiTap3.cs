using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm4
{
    internal class BaiTap3
    {
        public static void ChaoHoi(string hoTen, bool gioitinh)
        {
            if (gioitinh==true) 
                MessageBox.Show($"Chào Ông {hoTen}","Thông báo");
            else 
                MessageBox.Show($"Chào Bà {hoTen}","Thông báo");
        }
        public static int USCLN(int m, int n)
        {
            while(m!=n)
            {
                if (m > n)
                    m = m - n;
                else
                    n = n - m;
            }
            return m;
        }
    }
}
