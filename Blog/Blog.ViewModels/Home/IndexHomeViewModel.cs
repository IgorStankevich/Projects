using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities;

namespace Blog.ViewModels.Home
{
    public class IndexHomeViewModel
    {
        public List<Post> Posts { get; set; }

        //public List<Comment> Comments { get; set; }

        //public int TotalComments { get; set; }
    }
}
