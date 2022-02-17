using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using MyServices.ServiceReference1;
using System.IO;
using System.Windows.Forms;

namespace MyServices
{
    /// <summary>
    /// Summary description for StudentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StudentService : System.Web.Services.WebService
    {

       
        [WebMethod]
        public int Insert(Student obj)
        {
           
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
               

                DynamicParameters p = new DynamicParameters();
                p.Add("@StudentID", dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.AddDynamicParams(new { FullName = obj.FullName, Email = obj.Email, Address = obj.Address, Gender = obj.Gender, ImageUrl = obj.ImageUrl });
                
                int result = db.Execute("sp_Students_insert", p, commandType: CommandType.StoredProcedure);
                if (result!=0)
                    return p.Get<int>("@StudentID");
                    
                return 0;
            }
        }
        [WebMethod]
        public bool Update(Student obj)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();

                }
               
                DynamicParameters p = new DynamicParameters();
                int result= db.Execute("sp_Students_Update", new { StudentID = obj.StudentID, FullName = obj.FullName, Email = obj.Email, Address = obj.Address, Gender = obj.Gender, ImageUrl = obj.ImageUrl }, commandType: CommandType.StoredProcedure);
                
                return result != 0;

            }

        }
            [WebMethod]
        public List<Student> GetAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                   
                   
                }
                return db.Query<Student>("select *from Students", commandType: CommandType.Text).ToList();

            }
        }
        [WebMethod]
        public bool Delete(int studentId)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                   
                }
                int result = db.Execute("delete from Students where StudentID=@StudentID", new { StudentID = studentId }, commandType: CommandType.Text);
                 return result != 0;    
            }
        }

    }
}
