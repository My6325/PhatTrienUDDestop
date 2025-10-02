using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HuongDanDocFileJSon
{
    public class LoadBook
    {
/*        public static void SaveToXMLFile(List<Book> books)
        {
            XmlSerializer serializer =new XmlSerializer(typeof(List<Book>));
            using (StreamWriter writer=new StreamWriter("book.xml"))
            {
                serializer.Serialize(writer, books);
                writer.Close();
            }
        }*/
        public static List<Book> LoadXMLFile(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (StreamReader reader = new StreamReader(path))
            {
                return (List<Book>)serializer.Deserialize(reader);
            }
        }
    }
}
