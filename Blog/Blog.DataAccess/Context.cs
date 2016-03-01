using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.DataAccess.Migrations;
using Blog.Entities;

namespace Blog.DataAccess
{
    public class Context:DbContext
    {
        public Context()
            : base("BlogDBContext")
        {
            Database.SetInitializer<Context>(new ContextInitializer());
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
