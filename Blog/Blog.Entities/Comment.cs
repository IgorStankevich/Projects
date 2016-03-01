using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class Comment
    {
        public Comment()
        {
           Id = Guid.NewGuid(); 
        }
        public Guid Id { get; set; }
        //public int PostId { get; set; }
        //public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Post Post { get; set; }
        public virtual  User User { get; set; }
    }
}
