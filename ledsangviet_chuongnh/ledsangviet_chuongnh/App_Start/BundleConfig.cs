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
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                         //Morris Chart CSS
                         "~/Assets/plugins/morris/morris.css",
                         //<!-- Switchery css -->
                         "~/Assets/plugins/switchery/switchery.min.css",
                         // <!-- App CSS -->
                         //"~/Assets/css/style.css",
                         "~/Assets/css/site.css"
                         ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                         // jquery 
                         "~/Assets/js/jquery.min.js",
                         "~/Assets/js/tether.min.js",
                         "~/Assets/js/bootstrap.min.js",
                         "~/Assets/js/waves.js",
                         "~/Assets/js/jquery.nicescroll.js",
                         "~/Assets/plugins/switchery/switchery.min.js",
                         // Morris Chart
                         "~/Assets/plugins/morris/morris.min.js",
                         "~/Assets/plugins/raphael/raphael-min.js",
                         // Counter Up
                         "~/Assets/plugins/waypoints/lib/jquery.waypoints.js",
                         "~/Assets/plugins/counterup/jquery.counterup.min.js",
                         // App js
                         "~/Assets/js/jquery.core.js",
                         "~/Assets/js/jquery.app.js",

                         //Page specific js
                         //"~/Assets/pages/jquery.dashboard.js",
                         "~/Assets/js/site.js"
                         ));

            // Code removed for clarity.
            BundleTable.EnableOptimizations = true;
        }
    }
}