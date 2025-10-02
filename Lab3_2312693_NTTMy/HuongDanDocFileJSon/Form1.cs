using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuongDanDocFileJSon
{
    public partial class frmReadFileJSon : Form
    {
        public frmReadFileJSon()
        {
            InitializeComponent();
        }

        private void btnFileJSon_Click(object sender, EventArgs e)
        {
            string str = "";
            string path = "students.json";

            List<Student> list = new LoadStudent().LoadJSon(path);

            for (int i = 0; i < list.Count; i++)
            {
                Student info = list[i];
                string tonGiao = info.TonGiao ? "Có" : "Không";
                str += string.Format("Sinh viên {0} có MSSV: {1}, họ tên: {2},tuổi: {3}, điểm TB: {4}, tôn giáo:{5}\n",
                                     (i + 1), info.MSSV, info.HoTen,info.Tuoi, info.Diem,tonGiao);
            }

            MessageBox.Show(str);
        }

        private void btnFileXML_Click(object sender, EventArgs e)
        {
            string str = "";
            string path = "book.xml";
            List<Book> list =LoadBook.LoadXMLFile(path);
            for (int i = 0; i < list.Count; i++)
            {
                Book info = list[i];
                str += string.Format("{0}, {1}, {2}, {3}, {4} \n",info.ISBN, info.Title, info.Author,info.Price,info.YearPublished);
            }
            MessageBox.Show(str);
        }
    }
}
