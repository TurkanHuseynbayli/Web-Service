using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public static class Helper
    {
        public static bool DeleteImage(string root, string folder, string fileName)
        {
            string path = Path.Combine(root, folder, fileName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return true;
            }
            return false;
        }
    }
}
