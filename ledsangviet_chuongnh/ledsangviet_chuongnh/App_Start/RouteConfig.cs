using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ledsangviet_chuongnh
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // client
            routes.MapRoute(
                name: "Search",
                url: "tim-kiem",
                defaults: new { controller = "Product", action = "Search", id = UrlParameter.Optional },
                namespaces: new[] { "ledsangviet_chuongnh.Controllers" }
            );

            routes.MapRoute(
                name: "Home",
                url: "trang-chu",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ledsangviet_chuongnh.Controllers" }
            );

            routes.MapRoute(
                name: "About",
                url: "gioi-thieu",
                defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ledsangviet_chuongnh.Controllers" }
            );

            routes.MapRoute(
               name: "News",
               url: "tin-tuc",
               defaults: new { controller = "News", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "ledsangviet_chuongnh.Controllers" }
           );

            routes.MapRoute(
               name: "Consultant",
               url: "tu-van",
               defaults: new { controller = "Consultant", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "ledsangviet_chuongnh.Controllers" }
           );

            routes.MapRoute(
               name: "Supplier",
               url: "he-thong-phan-phoi",
               defaults: new { controller = "Supplier", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "ledsangviet_chuongnh.Controllers" }
           );

            routes.MapRoute(
               name: "Contact",
               url: "lien-he",
               defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "ledsangviet_chuongnh.Controllers" }
           );

            routes.MapRoute(
                name: "Category",
                url: "loai-san-pham/{metatitle}-{id}",
                defaults: new { controller = "Category", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "ledsangviet_chuongnh.Controllers" }
            );

            routes.MapRoute(
                name: "Product",
                url: "san-pham/{metatitle}-{id}",
                defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "ledsangviet_chuongnh.Controllers" }
            );

            routes.MapRoute(
               name: "News Detail",
               url: "tin-tuc/{metatitle}-{id}",
               defaults: new { controller = "News", action = "Detail", id = UrlParameter.Optional },
               namespaces: new[] { "ledsangviet_chuongnh.Controllers" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ledsangviet_chuongnh.Controllers" }
            );

        }
    }
}
