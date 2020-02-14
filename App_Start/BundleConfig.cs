using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
namespace WebAngular9mvc5.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/Script/Bundles").Include(
                      "~/bundles/runtime-es2015.*",
                       "~/bundles/runtime-es5.*",
                      "~/bundles/polyfills-es2015.*",
                       "~/bundles/polyfills-es5.*",
                      "~/bundles/main-es2015.*",
                       "~/bundles/main-es5.*"));

            bundles.Add(new StyleBundle("~/Content/Styles").Include(
                      "~/bundles/style.*"));
        }
    }
}