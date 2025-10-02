using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BTTTForm1
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random r=new Random();
            for(int i = 1; i <= 10; i++) 
            {
                int soNgauNhien = r.Next(100);
                listBox1.Items.Add(soNgauNhien);
            }
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            int so = int.Parse(txtNhap.Text);
            bool kt=false;
            foreach(int i in listBox1.Items)
            {
                if (so == i)
                {
                    kt = true;
                    break;
                }
            }
            if(kt==true)
            {
                lbResult.Text = "Tìm thấy";
            }
            else
            {
                lbResult.Text = "Không tìm thấy";
            }
        }
    }
}
