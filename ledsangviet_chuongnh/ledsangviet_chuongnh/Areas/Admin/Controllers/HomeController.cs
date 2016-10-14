using ledsangviet_chuongnh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        DBContext db = new DBContext();
        // GET: Admin/Default
        public ActionResult Index()
        {
            ViewBag.CategoryCount = db.Categories.Count();
            ViewBag.ProductCount = db.Products.Count();
            ViewBag.NewsCount = db.News.Count();
            ViewBag.AccountCount = db.Accounts.Count();
            return View();
        }
    }
}