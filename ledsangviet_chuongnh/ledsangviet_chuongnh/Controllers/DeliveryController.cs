using ledsangviet_chuongnh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Controllers
{
    public class DeliveryController : Controller
    {
        private DBContext db = new DBContext();
        // GET: Supplier
        public ActionResult Index()
        {
            ViewBag.Deliveries = db.Deliveries.ToList<Delivery>();
            return View();
        }
    }
}