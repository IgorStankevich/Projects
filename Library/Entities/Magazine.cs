using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Magazine : ILibraryItem
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int DatePublishing { get; set; }
        public int Periodicity { get; set; }
        public string ID { get; set; }

        public Magazine(string author, string name, string publisher, int datepublishing, int periodicity)
        {
            Author = author;
            Name = name;
            Publisher = publisher;
            DatePublishing = datepublishing;
            Periodicity = periodicity;
            ID = Guid.NewGuid().ToString();

        }
        public Magazine(string id,string author, string name, string publisher, int datepublishing, int periodicity)
        {
            Author = author;
            Name = name;
            Publisher = publisher;
            DatePublishing = datepublishing;
            Periodicity = periodicity;
            ID = id;

        }

        public Magazine()
        {

        }
    }
}
