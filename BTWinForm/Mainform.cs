using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm
{
    public partial class frmchinh : Form
    {
        public frmchinh()
        {
            InitializeComponent();
        }

        private void toolStripBai1_Click(object sender, EventArgs e)
        {
            var bai = new frmBai1();
            bai.ShowDialog();
        }

        private void toolStripBai2_Click(object sender, EventArgs e)
        {
            var bai = new frmBai2();
            bai.ShowDialog();
        }

        private void toolStripBai3_Click(object sender, EventArgs e)
        {
            var bai = new frmBai3();
            bai.ShowDialog();
        }

    }
}
