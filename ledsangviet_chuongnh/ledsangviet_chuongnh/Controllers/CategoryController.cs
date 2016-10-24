using ledsangviet_chuongnh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Controllers
{
    public class CategoryController : Controller
    {
        DBContext db = new DBContext();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        [OutputCache(Duration = int.MaxValue, VaryByParam = "id",Location =System.Web.UI.OutputCacheLocation.Server)]
        public ActionResult Detail(int? id)
        {
            var model = db.Categories.Find(id);
            ViewBag.ProductRelate = db.Products.Where(x => x.CategoryId == id).ToList<Product>();
            return View(model);
        }
    }
}