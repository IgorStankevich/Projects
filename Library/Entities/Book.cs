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
    public class Book:ILibraryItem
=======
    public class Book
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
<<<<<<< HEAD
        public int DatePublishing { get; set; }

        public string ID { get; set; }

        public Book(string author, string name, string publisher, int yearpublishing,string id)
        {
            this.Author = author;
            this.Name = name;
            this.Publisher = publisher;
            this.DatePublishing = yearpublishing;
            this.ID = id;
        }
        public Book(string author, string name, string publisher, int yearpublishing)
          
=======
        public int YearPublishing { get; set; }

        public Book(string author, string name, string publisher, int yearpublishing)
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
        {
            this.Author = author;
            this.Name = name;
            this.Publisher = publisher;
<<<<<<< HEAD
            this.DatePublishing = yearpublishing;
            this.ID = Guid.NewGuid().ToString();
=======
            this.YearPublishing = yearpublishing;
>>>>>>> a59f243ab85b2dc03956a58b86d7af7f439e719f
        }

        public Book()
        {

        }
    }
}
