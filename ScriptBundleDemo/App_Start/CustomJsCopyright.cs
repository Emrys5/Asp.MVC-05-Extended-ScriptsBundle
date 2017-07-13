using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ScriptBundleDemo.App_Start
{
    public class CustomJsCopyright : IBundleTransform
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
                    response.Content = "/*\r\nAuthor:Emrys\r\nVerson:1.1\r\n*/\r\n" + response.Content;
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