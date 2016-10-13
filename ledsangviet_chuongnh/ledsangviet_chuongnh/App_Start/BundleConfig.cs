using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ledsangviet_chuongnh.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // client
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                         //Morris Chart CSS
                         "~/Assets/Client/plugins/morris/morris.css",
                         //<!-- Switchery css -->
                         "~/Assets/Client/plugins/switchery/switchery.min.css",
                         // <!-- App CSS -->
                         //"~/Assets/css/style.css",
                         "~/Assets/Client/css/site.css"
                         ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                         // jquery 
                         "~/Assets/Client/js/jquery.min.js",
                         "~/Assets/Client/js/tether.min.js",
                         "~/Assets/Client/js/bootstrap.min.js",
                         "~/Assets/Client/js/waves.js",
                         "~/Assets/Client/js/jquery.nicescroll.js",
                         "~/Assets/Client/plugins/switchery/switchery.min.js",
                         // Morris Chart
                         "~/Assets/Client/plugins/morris/morris.min.js",
                         "~/Assets/Client/plugins/raphael/raphael-min.js",
                         // Counter Up
                         "~/Assets/Client/plugins/waypoints/lib/jquery.waypoints.js",
                         "~/Assets/Client/plugins/counterup/jquery.counterup.min.js",
                         // App js
                         "~/Assets/Client/js/jquery.core.js",
                         "~/Assets/Client/js/jquery.app.js",

                         //Page specific js
                         //"~/Assets/Client/pages/jquery.dashboard.js",
                         "~/Assets/Client/js/site.js"
                         ));

            // admin
            bundles.Add(new StyleBundle("~/bundles/admin/css").Include(
                        // Switchery css
                        //"~/Assets/Admin/plugins/switchery/switchery.min.css",
                        "~/Assets/Admin/css/site.css"
                        ));

            // Code removed for clarity.
            BundleTable.EnableOptimizations = true;
        }
    }
}