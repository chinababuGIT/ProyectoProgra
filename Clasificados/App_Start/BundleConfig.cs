﻿using System.Web;
using System.Web.Optimization;

namespace Clasificados
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                         "~/Scripts/bootstrap.js",
                          "~/Scripts/respond.js",
                          "~/Scripts/Facebook.js", 
                          "~/Scripts/Q&A.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/DetalleCategory.css",
                      "~/Content/Login.css",
                      "~/Content/Q&A.css",
                      "~/Content/Register.css",
                      "~/Content/TermsConditions.css"));
        }
    }
}
