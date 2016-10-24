using ledsangviet_chuongnh.Areas.Admin.Models;
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
    public class LoginController : Controller
    {
        DBContext db = new DBContext();
        // GET: Admin/Login
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(string username, string password)
        {
            if (Membership.ValidateUser(username, password))
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Đăng nhập không thành công.");
            }
            return View("Index");
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }

    }
}