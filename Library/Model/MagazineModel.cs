using System;
using System.Collections.Generic;
using System.Data;
<<<<<<< HEAD
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
using Library.Entities;

namespace Library.Models
{
    public class MagazineModel
    {
<<<<<<< HEAD
        private static List<Magazine> _magazines = new List<Magazine>();
        private static Magazine _magazine = new Magazine();
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Magazine>));
        private string filepath = @"c:\Users\stankevich\Desktop\magazines.xml";

        public void AddMagazine(Magazine magazine)
        {
            _magazine = magazine;
            _magazines.Add(magazine);
            using (StreamWriter stream = new StreamWriter(filepath))
            {
                xmlSerializer.Serialize(stream, _magazines);
                stream.Close();
            }
        }

        public void UpdateMagazine(Magazine magazine)
        {
            var mag = _magazines.Where(x => x.ID == magazine.ID).First();
            if (mag != null)
            {
                mag.Author = magazine.Author;
                mag.Name = magazine.Name;
                mag.Publisher = magazine.Publisher;
                mag.DatePublishing = magazine.DatePublishing;
                mag.Periodicity = magazine.Periodicity;
            }
        }

        public Magazine GetMagazine()
        {
            return _magazines.Last();
        }

        public void DeleteMagazine()
        {
            _magazines.Remove(_magazine);
        }

        public List<Magazine> GetAllMagazines()
        {
            if (File.Exists(filepath))
            {
                TextReader textReader = new StreamReader(filepath);
                _magazines = (List<Magazine>)xmlSerializer.Deserialize(textReader);
                textReader.Close();
            }
            else
            {
                XmlTextWriter writer = new XmlTextWriter(filepath, System.Text.Encoding.UTF8);
                writer.Close();
            }
            return _magazines;
        }
=======
        public static List<Magazine> _magazines = new List<Magazine>();
        public static Magazine _magazine = new Magazine();

        public static void AddMagazine(Magazine magazine)
        {
            _magazines.Add(magazine);
        }
        public static DataTable GetMagazinesTable(List<Magazine> magazines)
        {
            DataTable dataTable = new DataTable("Magazines");
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Author", typeof(string));
            dataTable.Columns.Add("Publisher", typeof(string));
            dataTable.Columns.Add("Date of Publishing", typeof(int));
            dataTable.Columns.Add("Periodicity", typeof(int));
            foreach (var magazine in magazines)
            {
                dataTable.Rows.Add(magazine.Name, magazine.Author, magazine.Publisher, magazine.DatePublishing, magazine.Periodicity);
            }
            return dataTable;
        }

>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
    }
}
