using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.DataAccess;
using Blog.ViewModels.About;
using Blog.ViewModels.Admin;
using Blog.ViewModels.Home;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public Context Context;
        public HomeController()
        {
            Context = new Context();
        }
        // GET: /Home/
        public ActionResult Index()
        {
            var view = new IndexHomeViewModel();
            view.Posts = Context.Posts.ToList();
            return View(view);
        }

        public ActionResult FullPost(Guid? Id)
        {
            var view = new GetBlogPostViewModel();
            view.BlogPost = Context.Posts.Where(x => x.Id == Id).FirstOrDefault();
            return View(view);
        }


        public ActionResult About()
        {
            var view = new AboutViewModel();
            view.Posts = Context.Posts.ToList();

            return View(view);
        }

    }
}