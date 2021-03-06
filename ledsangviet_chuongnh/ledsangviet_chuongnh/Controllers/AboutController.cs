﻿using ledsangviet_chuongnh.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Controllers
{
    public class AboutController : Controller
    {
        DBContext db = new DBContext();
        // GET: About
        public ActionResult Index()
        {
            ViewBag.Title = ConfigurationManager.AppSettings["AboutTitle"].ToString();
            ViewBag.About = db.Abouts.FirstOrDefault<About>();
            return View();
        }
    }
}