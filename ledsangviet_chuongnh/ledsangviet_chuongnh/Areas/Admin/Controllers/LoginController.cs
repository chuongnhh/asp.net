using ledsangviet_chuongnh.Areas.Admin.Models;
using ledsangviet_chuongnh.Common;
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
            //Account acc = db.Accounts.Find(username);
            if (Membership.ValidateUser(username, password))
            {
                //var accLogin = new LoginModel();

                //accLogin.Username = acc.Username;
                //accLogin.Password = acc.Password;
                //accLogin.Image = acc.Image;

                //Session.Add(CommonContants.ACCOUNT_SESSION, accLogin);
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