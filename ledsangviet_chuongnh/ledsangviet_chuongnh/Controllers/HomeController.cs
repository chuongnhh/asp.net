using ledsangviet_chuongnh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Controllers
{
    public class HomeController : Controller
    {
        DBContext db = new DBContext();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Category = db.Categories.ToList<Category>();
            ViewBag.Slide = db.Slides.ToList<Slide>();
            ViewBag.Product = db.Products.ToList<Product>();
            ViewBag.News = db.News.ToList<News>();

            return View();
        }

        [ChildActionOnly]
        public PartialViewResult NavigationBar()
        {
            var model = db.Categories.ToList<Category>();
            return PartialView(model);
        }

        [ChildActionOnly]
        public PartialViewResult Footer()
        {
            var model = db.Abouts.FirstOrDefault();
            return PartialView(model);
        }
    }
}