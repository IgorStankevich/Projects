using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Dynamic;
=======
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
<<<<<<< HEAD
    public class Magazine:ILibraryItem
=======
    public class Magazine
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int DatePublishing { get; set; }
        public int Periodicity { get; set; }
<<<<<<< HEAD
        public string ID { get; set; }
=======
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f

        public Magazine(string author, string name, string publisher, int datepublishing, int periodicity)
        {
            Author = author;
            Name = name;
            Publisher = publisher;
            DatePublishing = datepublishing;
            Periodicity = periodicity;
<<<<<<< HEAD
            ID = Guid.NewGuid().ToString();

=======
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
        }

        public Magazine()
        {

        }
    }
}
