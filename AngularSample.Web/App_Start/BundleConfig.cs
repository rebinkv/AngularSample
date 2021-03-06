﻿using System.Web.Optimization;

namespace AngularSample.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                "~/Scripts/Vendors/jquery.js",
                "~/Scripts/Vendors/bootstrap.js",
                "~/Scripts/Vendors/toastr.js",
                "~/Scripts/Vendors/jquery.raty.js",
                "~/Scripts/Vendors/respond.src.js",
                "~/Scripts/Vendors/angular.js",
                "~/Scripts/Vendors/angular-route.js",
                "~/Scripts/Vendors/angular-cookies.js",
                "~/Scripts/Vendors/angular-validator.js",
                "~/Scripts/Vendors/angular-base64.js",
                "~/Scripts/Vendors/angular-file-upload.js",
                "~/Scripts/Vendors/angucomplete-alt.min.js",
                "~/Scripts/Vendors/ui-bootstrap-tpls-0.13.1.js",
                "~/Scripts/Vendors/underscore.js",
                "~/Scripts/Vendors/raphael.js",
                "~/Scripts/Vendors/morris.js",
                "~/Scripts/Vendors/jquery.fancybox.js",
                "~/Scripts/Vendors/jquery.fancybox-media.js",
                "~/Scripts/Vendors/loading-bar.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/site.css",
                "~/Content/css/bootstrap.css",
                "~/Content/css/bootstrap-theme.css",
                "~/Content/css/font-awesome.css",
                //"~/Content/css/morris.css",
                "~/Content/css/toastr.css",
                "~/Content/css/jquery.fancybox.css",
                "~/Content/css/loading-bar.css"));

            bundles.Add(new ScriptBundle("~/bundles/spa").Include(
                "~/Scripts/spa/modules/common.core.js",
                "~/Scripts/spa/modules/common.ui.js",
                "~/Scripts/spa/app.js",
                "~/Scripts/spa/home/rootCtrl.js",
                //"~/Scripts/spa/movies/moviesCtrl.js",
                //"~/Scripts/spa/services/apiService.js",
                //"~/Scripts/spa/services/notificationService.js",
                "~/Scripts/spa/app.js",
                "~/Scripts/spa/layout/topBar.directive.js",
                "~/Scripts/spa/layout/sideBar.directive.js",
                //"~/Scripts/spa/customers/customersCtrl.js",
                //"~/Scripts/spa/customers/customersRegCtrl.js",
                //"~/Scripts/spa/customers/customerEditCtrl.js",
                //"~/Scripts/spa/layout/customPager.directive.js",
                //"~/Scripts/spa/directives/componentRating.directive.js",
                //"~/Scripts/spa/directives/availableMovie.directive.js",
                // "~/Scripts/spa/account/loginCtrl.js",
                //"~/Scripts/spa/account/registerCtrl.js",
                "~/Scripts/spa/home/rootCtrl.js",
                "~/Scripts/spa/home/indexCtrl.js"
                // "~/Scripts/spa/rental/rentMovieCtrl.js",
                //"~/Scripts/spa/rental/rentStatsCtrl.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/Vendors/modernizr.js"));

            BundleTable.EnableOptimizations = false;
        }
    }
}