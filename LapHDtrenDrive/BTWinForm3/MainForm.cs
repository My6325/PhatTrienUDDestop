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
    public partial class frmchinh : Form
    {
        public frmchinh()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            var bai = new frmBai1();
            bai.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            var bai = new frmBai2();
            bai.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            var bai = new frmBai3();
            bai.ShowDialog();
        }
    }
}
