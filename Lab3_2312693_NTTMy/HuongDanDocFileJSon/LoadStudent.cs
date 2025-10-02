using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HuongDanDocFileJSon
{
    public class LoadStudent
    {
        public List<Student> LoadJSon(string path)
        {
            List<Student> list = new List<Student>();
            StreamReader sr = new StreamReader(path);
            string json = sr.ReadToEnd();
            var array = (JObject)JsonConvert.DeserializeObject(json);

            var students = array["sinhvien"].Children();
            foreach ( var item in students )
            {
                string mSSV = item["MSSV"].Value<string>();
                string hoTen = item["hoten"].Value<string>();
                int tuoi = item["tuoi"].Value<int>();
                double diem = item["diem"].Value<double>();
                bool tonGiao = item["tongiao"].Value<bool>();
                Student student = new Student(mSSV, hoTen, tuoi, diem, tonGiao);
                list.Add(student);
            }
            return list;
        }
    }
}
