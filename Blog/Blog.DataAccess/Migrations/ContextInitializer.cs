using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Migrations
{
    public class ContextInitializer: DropCreateDatabaseIfModelChanges<Blog.DataAccess.Context>
    {

    }
}
