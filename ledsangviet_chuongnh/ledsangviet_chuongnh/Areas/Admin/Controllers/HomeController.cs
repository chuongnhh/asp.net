using ledsangviet_chuongnh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ledsangviet_chuongnh.Areas.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        DBContext db = new DBContext();
        // GET: Admin/Default
        public ActionResult Index()
        {
            ViewBag.CategoryCount = db.Categories.Count();
            ViewBag.ProductCount = db.Products.Count();
            ViewBag.NewsCount = db.News.Count();
            ViewBag.AccountCount = db.Accounts.Count();
            ViewBag.VisitorCount = db.Visitors.Count();
            ViewBag.DeliveryCount = db.Deliveries.Count();
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult TopMenu()
        {
            var model = db.Accounts.Find(Membership.GetUser().UserName);
            return PartialView(model);
        }
    }
}