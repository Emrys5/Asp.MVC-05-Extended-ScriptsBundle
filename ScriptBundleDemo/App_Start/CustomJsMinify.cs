using Dean.Edwards;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Optimization;


namespace ScriptBundleDemo.App_Start
{
    public class CustomJsMinify : IBundleTransform
    {
        public void Process(BundleContext context, BundleResponse response)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (response == null)
            {
                throw new ArgumentNullException("response");
            }
            if (!context.EnableInstrumentation)
            {
                try
                {
                    ECMAScriptPacker p = new ECMAScriptPacker(ECMAScriptPacker.PackerEncoding.Normal, true, true);
                    response.Content = p.Pack(response.Content);
                }
                catch (Exception ex)
                {
                    response.Content = "/*\r\nError:" + ex.Message + "\r\n*/\r\n" + response.Content;
                }
            }
            response.ContentType = "text/javascript";
        }
    }
}