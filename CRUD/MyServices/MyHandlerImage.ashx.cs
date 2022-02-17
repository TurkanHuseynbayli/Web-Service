using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyServices
{
    /// <summary>
    /// Summary description for MyHandlerImage
    /// </summary>
    public class MyHandlerImage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //UploadService1 uploadService = new UploadService1();
            
            //byte[] binImage = uploadService.GetImageFile(context.Request["fileName"]);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}