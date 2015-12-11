using System.Web;
using System.Web.Optimization;

namespace Ops
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/plugins/bootstrap/bootstrap.css",
                      "~/assets/font-awesome/css/font-awesome.css",
                      "~/assets/plugins/pace/pace-theme-big-counter.css",
                      "~/assets/css/style.css",
                      "~/assets/css/main-style.css",
                      "~/assets/plugins/social-buttons/social-buttons.css",
                      "~/assets/plugins/timeline/timeline.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/assets/plugins/jquery-1.10.2.js",
                      "~/assets/plugins/bootstrap/bootstrap.min.js",
                      "~/assets/plugins/metisMenu/jquery.metisMenu.js",
                      "~/assets/scripts/siminta.js"));
        }
    }
}
