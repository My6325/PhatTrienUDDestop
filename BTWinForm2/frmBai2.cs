using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            double so1=double.Parse(txtSo1.Text);
            double so2=double.Parse(txtSo2.Text);
            double kq = 0;
            if(rdCong.Checked)
                kq=so1+so2;
            if(rdTru.Checked)
                kq=so1-so2;
            if (rdNhan.Checked)
                kq=so1*so2;
            if(rdChia.Checked)
            {
                if (so2 != 0)
                    kq = so1 / so2;
                else
                {
                    MessageBox.Show("Không thể chia cho 0");
                    return;
                }
            }
            lbKQ.Text=kq.ToString();
        }
    }
}
