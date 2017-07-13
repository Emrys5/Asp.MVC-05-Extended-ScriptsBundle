using ScriptBundleDemo.App_Start;
using System.Web;
using System.Web.Optimization;

namespace ScriptBundleDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        { 
            bundles.Add(new CustomScriptBundle("~/bundles/layout").Include(
                        "~/Scripts/layout.js"
                        ));
        }
    }
}
