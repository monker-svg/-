using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bysj.BLL.teacherinfo bll = new bysj.BLL.teacherinfo();
            //System.Data.DataSet ds = bll.GetAllList();
System.Data.DataSet ds = bll.GetList("TeacherName='马秀荣'");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Response.Write(ds.Tables[0].Rows.Count);

        }
    }
}