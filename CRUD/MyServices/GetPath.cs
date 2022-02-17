using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Windows.Forms;

namespace MyServices
{
    public  class GetPath
    {
        public  string PathName { get; set; }

        public  string PathFile(string filename)
        {
            GetPath getPath = new GetPath();
            string path = Path.GetFileName(filename);
           
            var imageFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/Images/") + Guid.NewGuid().ToString() + path;
            getPath.PathName = imageFilePath;
            return imageFilePath; 
        }

       
        

        //public static void POST(string url, string jsonContent)
        //{
        //    url = "blabla.com/api/blala" + url;
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseURL);
        //    request.Method = "POST";

        //    System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
        //    Byte[] byteArray = encoding.GetBytes(jsonContent);

        //    request.ContentLength = byteArray.Length;
        //    request.ContentType = @"application/json";

        //    using (Stream dataStream = request.GetRequestStream())
        //    {
        //        dataStream.Write(byteArray, 0, byteArray.Length);
        //    }
        //    long length = 0;
        //    try
        //    {
        //        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //        {
        //            length = response.ContentLength;

        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
    }
}