using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public static class Extension
    {
        public static string PathFile2(string filename)
        {
            
            string path = Path.GetFileName(filename);

            var imageFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/Images/") + Guid.NewGuid().ToString() + path;
            
            return imageFilePath;
        }  

    }
}
