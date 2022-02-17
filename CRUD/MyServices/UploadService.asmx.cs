using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Dapper;
using System.Configuration;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Web.Hosting;

namespace MyServices
{
    /// <summary>
    /// Summary description for UploadService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UploadService1 : System.Web.Services.WebService
    {

      


        [WebMethod]
        public UploadService FileToByteArray(string fileName)
        {

            byte[] image = null;
            System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(fs);
            long byteLength = new System.IO.FileInfo(fileName).Length;
            image = binaryReader.ReadBytes((Int32)byteLength);
            fs.Close();
            fs.Dispose();
            binaryReader.Close();
            UploadService uploadService = new UploadService();
            uploadService.FileName = fileName;
            uploadService.Image = image;
            return uploadService;
        }

       


        [WebMethod]
        public GetPath UploadFile(string fileName,byte[] byteArr)
        {
         
            UploadService uploadService = new UploadService();
            GetPath getPath = new GetPath();
             
            try
            {
                MemoryStream ms = new MemoryStream(byteArr);
                
                string path = Path.GetFileName(fileName);
                var img = System.Web.Hosting.HostingEnvironment.MapPath("~/Images/");
                int index = img.LastIndexOf(img);
                var imageFilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/Images/") + Guid.NewGuid().ToString() + path;
             
                FileStream fs = new FileStream(imageFilePath, FileMode.Create);
                

                ms.WriteTo(fs);
                ms.Close();
                fs.Close();
                fs.Dispose();
                
               
                //uploadService.FileName = fileName;
                uploadService.Image = byteArr;
                //getPath.PathName = fileName;    
                //uploadService.FileName = getPath.PathName;
                //int index = img.LastIndexOf(img);
                //char r = imageFilePath.Length - 1; 
                var r= imageFilePath.Replace(img,@"https://localhost:44341/Images/");
                getPath.PathName = r;
           //     MessageBox.Show(r); 
               
                //getPath.PathName = imageFilePath

                //MessageBox.Show(path);


                return getPath;
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
               
                return getPath;
            }
           
        }

        //[WebMethod]
        //public void UploadFile2(string fileName, byte[] bytes)
        //{
        //    //Save the Byte Array as File.
        //    string filePath = Server.MapPath(string.Format("~/Uploads/{0}", fileName));
        //    File.WriteAllBytes(filePath, bytes);
        //    UploadService uploadService = new UploadService();
        //    uploadService.FileName = fileName;
        //    uploadService.Image = bytes;
        //    return uploadService;   
        //}
        //[WebMethod]
        //public void Show(string fileName, byte[] fileContent)
        //{
        //    //Split the string by character . to get file extension type  
        //    string[] stringParts = fileName.Split(new char[] { '.' });
        //    string strType = stringParts[1];



        //    Response.Clear();
        //    Response.ClearContent();
        //    Response.ClearHeaders();
        //    Response.AddHeader("content-disposition", "attachment; filename=" + fileName);
        //    //Set the content type as file extension type  
        //    Response.ContentType = strType;
        //    //Write the file content  
        //    this.Response.BinaryWrite(fileContent);
        //    this.Response.End();
        //}

        //[WebMethod]
        //public void UploadImage(string filename, byte[] bytearr)
        //{

        //    OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        openFileDialog1.FileName = Path.GetFileName(openFileDialog1.FileName);

        //        //Read Image File into Image object.
        //        Image img = Image.FromFile(openFileDialog1.FileName);

        //        //ImageConverter Class convert Image object to Byte Array.
        //        byte[] bytes = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));

        //        //Convert Byte Array to Image and display in PictureBox.
        //        pic.Image = Image.FromStream(new MemoryStream(bytes));

        //    }


        //}

        //    [WebMethod,Description("Get image content")]
        //public byte[] GetImageFile(string filename)
        //{
        //    if (System.IO.File.Exists(Server.MapPath("/Images/") + filename))
        //    {
        //        return System.IO.File.ReadAllBytes(Server.MapPath("~/Images/") + filename);
        //    }
        //    else
        //    {
        //        return new byte[] {0}; 
        //    }
        //}
       
    }
}
