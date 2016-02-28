using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Library.Entities;

namespace Library.Models
{
    public class MagazineModel
    {
        //TO DO Without static
        private static List<Magazine> _magazines = new List<Magazine>();
        private static Magazine _magazine = new Magazine();
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Magazine>));

        public void AddMagazine(Magazine magazine)
        {
            _magazine = magazine;
            _magazines.Add(magazine);
            WriteToXml();
        }

        public void UpdateMagazine(Magazine magazine)
        {
            var mag = _magazines.Where(x => x.ID == magazine.ID).FirstOrDefault();
            if (mag != null)
            {
                mag.Author = magazine.Author;
                mag.Name = magazine.Name;
                mag.Publisher = magazine.Publisher;
                mag.DatePublishing = magazine.DatePublishing;
                mag.Periodicity = magazine.Periodicity;
                WriteToXml();
                ReadFromXml();
            }
        }

        public Magazine GetMagazine()
        {
            return _magazines.Last();
        }

        public void DeleteMagazine(Magazine magazine)
        {
            var item = _magazines.SingleOrDefault(x => x.ID == magazine.ID);
            if (item != null)
            {
                _magazines.Remove(item);
            }
            WriteToXml();
        }

        public List<Magazine> GetAllMagazines()
        {
            ReadFromXml();
            return _magazines;
        }

        public void ReadFromXml()
        {
            TextReader textReader = new StreamReader("magazines.xml");
            _magazines = (List<Magazine>)xmlSerializer.Deserialize(textReader);
            textReader.Close();
        }

        public void WriteToXml()
        {
            using (StreamWriter stream = new StreamWriter("magazines.xml"))
            {
                xmlSerializer.Serialize(stream, _magazines);
                stream.Close();
            }
        }
    }
}
