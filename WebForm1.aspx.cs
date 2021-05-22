using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideControlsDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");
        }

        protected void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Ok You will not be redirected");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                IList<HttpPostedFile> files=FileUpload1.PostedFiles;
                foreach (var item in files)
                {
                    FileUpload1.SaveAs(@"C:\Users\deore\Desktop\189-Mphasis\C#Demos\ServerSideControlsDemo\Myfiles\" + item.FileName);
                }
                //string fname = FileUpload1.FileName;
                
                
                Response.Write("Uplaoded successfully...");
            }
            

        }
    }
}