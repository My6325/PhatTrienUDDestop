using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm3
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int n=int.Parse(txtNhapN.Text);
            int tong = 0;
            long giaiThua = 1;
            if(n>0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (rdTong.Checked)
                    {
                        tong = tong + i;
                        lbKQ.Text = tong.ToString();
                    }
                    else
                    {
                        giaiThua *= i;
                        lbKQ.Text = giaiThua.ToString();
                    }
                }
            }
        }
    }
}
