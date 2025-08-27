using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTTForm1
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var hanghoa = listBoxHH.SelectedItem;
            listBoxMua.Items.Add(hanghoa);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            listBoxMua.Items.Remove(listBoxMua.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            foreach(string hanghoa in listBoxMua.Items)
            {
                switch(hanghoa)
                {
                    case "Chuột":
                        tongtien += 100000;
                        break;
                    case "Bàn phím":
                        tongtien += 150000;
                        break;
                    case "Máy in":
                        tongtien += 2000000;
                        break;
                    case "USB Kingmax":
                        tongtien += 200000;
                        break;
                    default:
                        break;
                }
                lbTien.Text=tongtien+" đồng";
            }
        }
    }
}
