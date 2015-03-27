using System.Web;
using System.Web.Optimization;

namespace classRoomWebSite.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/kendojs").Include(
                "~/Scripts/jquery-*",
                "~/Scripts/kendo/2012.2.710/kendo.web.min.js"));

            bundles.Add(new StyleBundle("~/Content/kendocss").Include(
                "~/Content/kendo/2012.2.710/kendo.common.min.css",
                "~/Content/kendo/2012.2.710/kendo.default.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
        }
    }
}