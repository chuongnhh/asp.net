using ledsangviet_chuongnh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Controllers
{
    public class NewsController : Controller
    {
        DBContext db = new DBContext();
        // GET: News
        public ActionResult Index()
        {
            ViewBag.News = db.News.ToList<News>();
            return View();
        }
        public ActionResult Detail(int ?id)
        {
            ViewBag.News = db.News.ToList<News>();
            var model = db.News.Find(id);
            return View(model);
        }
    }
}