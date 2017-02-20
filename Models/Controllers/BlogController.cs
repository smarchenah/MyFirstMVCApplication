using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplication.Controllers
{
    public class BlogController : Controller
    {
        // GET the latest post in the Blog
        public ActionResult Index()
        {
            using (var manager = new Models.BlogManager())
            {
                var posts = manager.GetLatestPosts(10); // 10 latests posts 
                if (posts == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View("Index", posts); //By Default Index -> "return View(posts);"
                }
            }
        }

        // GET /Blog/Archive/2005/3 
        public ActionResult Archive(int year, int month)
        {
            using (var manager = new Models.BlogManager())
            {
                var posts = manager.GetPostsByDate(year, month);
                if (posts == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(posts); // oder "return View("Archive", posts);"
                }
            }
        }

        // GET /Blog/Hello-world
        public ActionResult ViewPost(string code)
        {
            using (var manager = new Models.BlogManager())
            {
                var post = manager.GetPost(code);
                if(post == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(post); //oder "return View("Post", post);"
                }
            }
        }

    }
}