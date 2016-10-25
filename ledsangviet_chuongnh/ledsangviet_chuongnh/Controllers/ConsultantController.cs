using ledsangviet_chuongnh.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Controllers
{
    public class ConsultantController : Controller
    {
        DBContext db = new DBContext();
        // GET: Consultant
        public ActionResult Index()
        {
            ViewBag.Title = ConfigurationManager.AppSettings["ConsultantTitle"].ToString();
            ViewBag.About = db.Abouts.FirstOrDefault<About>();
            return View();
        }
    }
}