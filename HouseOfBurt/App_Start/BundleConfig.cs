﻿using System.Web;
using System.Web.Optimization;

namespace HouseOfBurt
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/layoutjs").Include(
                        "~/Scripts/Layout.js",
                        "~/Scripts/google.js"));

            bundles.Add(new ScriptBundle("~/bundles/applicationjs").Include(
                "~/Scripts/google.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/contextneededScripts").Include(
                       "~/Scripts/jquery.backstretch.min.js"));

            bundles.Add(new StyleBundle("~/Content/base/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/site.css"));

            bundles.Add(new StyleBundle("~/Content/base/contextneeded").Include(
                      "~/Content/css/ContextNeeded.css"));

            bundles.Add(new StyleBundle("~/Content/base/news").Include(
                      "~/Content/css/News.css"));
            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
