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
    public partial class frmchinh : Form
    {
        public frmchinh()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.ShowDialog();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBai3();
            form.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBai4();
            form.ShowDialog();
        }

    }
}
