using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Book:ILibraryItem
    {
        private string id;
        public string ID 
        {
            get { return string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id; } 
            set { id = value; }
        }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int DatePublishing { get; set; }
       
        public Book(string id,string author, string name, string publisher, int yearpublishing)
        {
            this.Author = author;
            this.Name = name;
            this.Publisher = publisher;
            this.DatePublishing = yearpublishing;
            this.ID = id;
        }
        public Book(string author, string name, string publisher, int yearpublishing)
          
        {
            this.Author = author;
            this.Name = name;
            this.Publisher = publisher;
            this.DatePublishing = yearpublishing;
            this.ID = Guid.NewGuid().ToString();
        }

        public Book()
        {

        }
    }
}
