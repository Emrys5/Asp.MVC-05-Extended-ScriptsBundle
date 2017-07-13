using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ScriptBundleDemo.App_Start
{
    public class CustomScriptBundle : Bundle
    {
        public CustomScriptBundle(string virtualPath) : this(virtualPath, null)
        {
        }

        public CustomScriptBundle(string virtualPath, string cdnPath) : base(virtualPath, cdnPath, new IBundleTransform[]
        {
           new CustomJsMinify()
        })
        {
            base.ConcatenationToken = ";";
        }
    }
}