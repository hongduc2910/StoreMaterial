using System.Web.Optimization;

namespace StoreMaterial
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/easing.js",
                "~/Scripts/jquery.etalage.min.js",
                "~/Scripts/jquery.flexisel.js",
                "~/Scripts/jquery.jscrollpane.min.js",
                "~/Scripts/jquery.wmuSlider.js",
                "~/Scripts/megamenu.js",
                "~/Scripts/move-top.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/etalage.css",
                      "~/Content/form.css",
                      "~/Content/megamenu.css",
                      "~/Content/style.css"));
        }
    }
}
