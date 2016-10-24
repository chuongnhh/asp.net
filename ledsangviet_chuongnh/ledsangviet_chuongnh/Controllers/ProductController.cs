using ledsangviet_chuongnh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Controllers
{
    public class ProductController : Controller
    {
        DBContext db = new DBContext();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [OutputCache(Duration = int.MaxValue, VaryByParam = "id", Location = System.Web.UI.OutputCacheLocation.Server)]
        public ActionResult Detail(int? id)
        {
            var model = db.Products.Find(id);
            Category categoryId = db.Categories.Where(x => x.Id == model.CategoryId).FirstOrDefault<Category>();
            ViewBag.productRelate = db.Products.Where(x => x.CategoryId == categoryId.Id).ToList<Product>();

            return View(model);
        }

        public ActionResult Search(string keyword)
        {
            ViewBag.Keyword = keyword;
            var result = db.Products
                .Where(x => x.Name.ToUpper().Contains(keyword.ToUpper()))
                .ToList<Product>();
            return View(result);
        }
    }
}