using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyServices
{
    public partial class upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnupload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string pathoffolder = Server.MapPath("~/upload images/");
                if (!Directory.Exists(pathoffolder))
                {
                    Directory.CreateDirectory(pathoffolder);    
                }
                string getFileName=Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(pathoffolder + getFileName);
                lblmsg.Visible=true;
                lblmsg.Text = getFileName+"uploded";
            }
        }
    }
}