using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Blog.DataAccess;
using Blog.Entities;
using Blog.ViewModels.Admin;
using Blog.ViewModels.Home;

namespace Blog.Controllers
{
    public class AdminController : Controller
    {
        private Context Context;
        public AdminController()
        {
            Context = new Context();
        }
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            var view = new IndexAdminViewModel();
            view.Posts = Context.Posts.ToList();

            return View(view);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Post post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Context.Posts.Add(post);
                    Context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException exception)
            {

                ModelState.AddModelError("", "Unable to save changes. Try again.");
            }

            return View(post);
        }
        [HttpPost]
        public ActionResult EditPost(Post post)
        {

            if (ModelState.IsValid)
            {
                Context.Entry(post).State = EntityState.Modified;
                Context.SaveChanges();
                RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult EditPost(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var post = new EditPostViewModel();
            post.Post = Context.Posts.Where(x => x.Id == id).FirstOrDefault();
            return View(post);
        }

        public ActionResult GetBlogPost(Guid? id)
        {
            var view = new GetBlogPostViewModel();
            view.BlogPost = Context.Posts.Where(x => x.Id == id).FirstOrDefault();
            return View(view);
        }

        [HttpGet]
        public ActionResult DeletePost(Guid Id)
        {
            try
            {
                Post post = Context.Posts.Find(Id);
                Context.Posts.Remove(post);
                Context.SaveChanges();
            }
            catch (DataException exception)
            {

                return RedirectToAction("DeletePost");
            }
            return RedirectToAction("Index");
        }

        public ActionResult DeleteComment(Guid Id)
        {
            try
            {
                Comment comment = Context.Comments.Find(Id);
                Context.Comments.Remove(comment);
            }
            catch (DataException exception)
            {

                return RedirectToAction("DeleteComment");
            }
            return RedirectToAction("Index");
        }
    }
}