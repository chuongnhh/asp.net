using ledsangviet_chuongnh.App_Start;
using ledsangviet_chuongnh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ledsangviet_chuongnh
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Session_Start()
        {
            Application.Lock();
            DBContext db = new DBContext();
            Visitor visitor = new Visitor();
            visitor.Browser = HttpContext.Current.Request.Browser.Browser;
            visitor.Version = HttpContext.Current.Request.Browser.Version;
            visitor.Type = HttpContext.Current.Request.Browser.Type;
            visitor.Platform = HttpContext.Current.Request.Browser.Platform;
            visitor.UserAgent = HttpContext.Current.Request.UserAgent;
            visitor.UserHostAddress = HttpContext.Current.Request.UserHostAddress;
            string[] userLang = HttpContext.Current.Request.UserLanguages;
            foreach (var u in userLang)
            {
                visitor.UserLanguages += (u + ", ");
            }
            db.Visitors.Add(visitor);
            db.SaveChanges();
            Application.UnLock();
        }
    }
}
