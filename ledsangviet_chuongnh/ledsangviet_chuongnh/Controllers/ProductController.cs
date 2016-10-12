﻿using ledsangviet_chuongnh.Models;
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

        public ActionResult Detail(int ? id)
        {
            var model = db.Products.Find(id);
            Category categoryId = db.Categories.Where(x => x.Id == model.CategoryId).FirstOrDefault<Category>();
            ViewBag.productRelate = db.Products.Where(x => x.CategoryId == categoryId.Id).ToList<Product>();

            return View(model);
        }
    }
}