using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class User
    {
        public User()
        {
            Id= Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
