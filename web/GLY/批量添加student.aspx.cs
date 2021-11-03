using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web.GLY.学生管理
{
    public partial class 批量添加student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                string fName = FileUP(Server.MapPath("~/临时文件/"), 5 * 1024 * 1024, ".xlsx,.xls", FileUpload1);
                string fileUrl = Server.MapPath("~/临时文件/") + fName;
                // 支持.xls和.xlsx，即包括office2010等版本的   HDR=Yes代表第一行是标题，不是数据；
                Label1.Text = fileUrl;
                string constr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data source={0};Extended Properties='Excel 12.0;HDR=YES;IMEX=1;'", fileUrl);


                OleDbConnection conn = new OleDbConnection(constr);

                OleDbCommand cmd = new OleDbCommand("select * from [Sheet1$]", conn);

                OleDbDataAdapter daap = new OleDbDataAdapter(cmd);

                DataTable dt = new DataTable();
                daap.Fill(dt);

                //Repeater1.DataSource = dt;
                // Repeater1.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write(ex.HelpLink);
            }


        }

        public string FileUP(string dir, int Maxsize, string Filetype, FileUpload f1)
        {
            //string dir = Server.MapPath(@"~\img\");
            string Filename = FileUpload1.PostedFile.FileName;
            string Txt = Filename.Substring(Filename.LastIndexOf(".")).ToLower();
            //Response.Write(Filename);
            //Response.Write("<br/>" + Txt);

            string NewFilename = DateTime.Now.ToString("yyyyMMddhhmmss") + Txt;
            int Filesize = FileUpload1.PostedFile.ContentLength;
            //int Maxsize = 8 * 1024 * 1024; //8M
            if (Filesize > Maxsize) { Response.Write("<script>alert('文件太大，超过限定')</script>"); return null; }

            //string Filetype = ".jpg,.png,.gif";
            if (!Filetype.Contains(Txt))  //判断指定的子串(Txt)是否出现在此字符串中(Filetype)。
            {
                Response.Write("<script>alert('文件类型不符合要求')</script>"); return null;
            }

            f1.SaveAs(dir + NewFilename);
            return NewFilename;

        }

    }
}