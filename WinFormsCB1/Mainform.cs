using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCB1
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            var ten=txtTen.Text;
            MessageBox.Show($"Xin chào ban {ten} đến với lớp học");
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtCopy.Text=txtTen.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtCopy.Text = txtTen.Text;
        }
    }
}
