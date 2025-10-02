using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCB2
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void rdbtnNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnNam.Checked)
                MessageBox.Show($"Bạn chọn giới tính Nam", "Thông báo");
        }

        private void rdbtnNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnNu.Checked)
                MessageBox.Show($"Bạn chọn giới tính Nữ", "Thông báo");
        }


        private void btnToMau_Click(object sender, EventArgs e)
        {
            if(rdbtnDo.Checked)
                txtMau.BackColor=Color.Red;
            else 
                txtMau.BackColor = Color.Green;

        }

    }
}
