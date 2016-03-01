using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class Post
    {
        public Post()
        {
            this.Id = Guid.NewGuid();
            this.DateCreated=DateTime.Today;
            this.Modified = DateTime.Today;
        }
        public Guid Id { get; set; }
       // public int UserId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime Modified { get; set; }
        public string Content { get; set; }
        public string ShortContent { get; set; }
        public virtual  User User { get; set; }

    }
}
