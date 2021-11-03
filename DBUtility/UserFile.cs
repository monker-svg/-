using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace DBUtility
{
     public  class UserFile
    {
        public static String FileUP(System.Web.UI.Page page, string filrType, string dir, int maxSize, FileUpload FileUpload1)
        {
          
           


            try
            {
                string fileName = FileUpload1.PostedFile.FileName;
                string Txt = fileName.Substring(fileName.LastIndexOf('.'));
                string NewFileName = DateTime.Now.ToString("yyyyMMddhhmmss") + Txt;
                if (!filrType.Contains(Txt))
                {
                    page.ClientScript.RegisterStartupScript(page.GetType(),
                       "message", "<script>alert('文件类型不符合要求')</script>");
                    //Response.Write("<script>alert('文件不符合要求')</script>");
                    return null;
                }
                int fileSize = FileUpload1.PostedFile.ContentLength;
                if (fileSize > maxSize)
                {
                    page.ClientScript.RegisterStartupScript(page.GetType(),
                      "message", "<script>alert('文件大小符合大小')</script>");
                    //Response.Write("<script>alert('文件大小不得大于70kb')</script>");
                    return null;
                }

                FileUpload1.SaveAs(dir + NewFileName);
                return NewFileName;
            }
            catch
            {
                page.ClientScript.RegisterStartupScript(page.GetType(),
                         "message", "<script>alert('上传失败')</script>");
                return null;
            }

            


        }

    }
}
