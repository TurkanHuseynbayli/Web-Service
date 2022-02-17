using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CRUD.CRUDService;
using CRUD.UploadImageService;
using System.IO;
using System.ServiceModel;
using Dapper;
using System.Net;
using System.Reflection;

namespace CRUD
{
    public partial class Form1 :MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                
               StudentServiceSoapClient client = new StudentServiceSoapClient();

                studentBindingSource.DataSource = client.GetAll();
                pContainer.Enabled = false;
                Student obj = studentBindingSource.Current as Student;
               
                if (obj != null)
                {
                    if (!string.IsNullOrEmpty(obj.ImageUrl))
                    {
                     //   MessageBox.Show(obj.ImageUrl);
                        pic.Load(obj.ImageUrl);
                       // pic.Image = Image.FromFile(obj.ImageUrl);
                    }
                }

            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        GetPath pathFile { get; set; }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
                
            if (ofd.ShowDialog() == DialogResult.OK)
                {
                    
                    UploadService1SoapClient client2 = new UploadService1SoapClient();

                    byte[] byteArray = File.ReadAllBytes(ofd.FileName);

                    pathFile = client2.UploadFile(ofd.FileName, byteArray);
                    pic.Load(ofd.FileName);
                  //  pic.Image = Image.FromFile(ofd.FileName);

                    Student obj = studentBindingSource.Current as Student;
                    if (obj != null)
                    {
                        obj.ImageUrl = ofd.FileName;
                    }
                }
        }

        void ClearInput()
        {
            txtFullName.Text = null;
            txtEmail.Text = null;
            txtAddress.Text = null;
            chkGender.Checked = false;
            pic.Image = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = false;
            studentBindingSource.ResetBindings(false);
            this.Form1_Load(sender, e);
            //ClearInput();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pic.Image = null;
            pContainer.Enabled = true;
            List<Student> list = ((IEnumerable<Student>)studentBindingSource.DataSource).ToList();
            //studentBindingSource.Add(new Student());
            list.Add(new Student());
            studentBindingSource.DataSource = list.AsEnumerable();
            studentBindingSource.MoveLast();
            txtFullName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pContainer.Enabled = true;
            txtFullName.Focus();
        }

        private  void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Student obj = studentBindingSource.Current as Student;
                if (obj != null)
                {
                    if (!string.IsNullOrEmpty(obj.ImageUrl))
                    {
                        // pic.Image = Image.FromFile(obj.ImageUrl);
                        pic.WaitOnLoad = true; 
                        pic.Load(obj.ImageUrl);
                       
                        //   Uri url = new Uri(obj.ImageUrl);

                        //  pic.ImageLocation = "https://localhost:44341//Images//920c4648-5d53-4470-bede-2dc3e15f48b2girl11.jpg";


                    }
                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete it?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Student obj = studentBindingSource.Current as Student;
                    if (obj != null)
                    {
                        StudentServiceSoapClient client = new StudentServiceSoapClient();

                        bool result = client.Delete(obj.StudentID);
                        if (result)
                        {
                            studentBindingSource.RemoveCurrent();
                            pContainer.Enabled = false;
                            pic.Image = null;
                            objState = EntityState.Unchanged;
                        }
                    }


                }
                catch (Exception ex)
                {

                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                studentBindingSource.EndEdit();
                Student obj = studentBindingSource.Current as Student;
                if (obj != null)
                {

                    StudentServiceSoapClient client = new StudentServiceSoapClient();

                    if (objState == EntityState.Added)
                    {

                        //string oldpath = pathFile.PathName.Substring(0, 62);
                        //string newpath = pathFile.PathName.Replace(oldpath,"https://localhost:44341");

                        //MessageBox.Show(newpath);
                        obj.ImageUrl = pathFile.PathName;
                        
                        client.Insert(obj);

                    }
                    else if (objState == EntityState.Changed)
                    {
                        obj.ImageUrl = pathFile.PathName;
                        client.Update(obj);
                    }
                    metroGrid.Refresh();
                    pContainer.Enabled = false;
                    objState = EntityState.Unchanged;

                }

            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkGender_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkGender.CheckState == CheckState.Checked)
            {
                chkGender.Text = "Female";

            }
            else if (chkGender.CheckState == CheckState.Unchecked)
                chkGender.Text = "Male";
            else
            {
                chkGender.Text = "???";
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                e.Cancel = true;
                txtFullName.Focus();
                errorProviderApp.SetError(txtFullName, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtFullName, "");
            }
        }
    }
}
